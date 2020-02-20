using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotePad
{
    public partial class frm_NotePad : Form
    {
        public frm_NotePad()
        {
            InitializeComponent();
        }

        private void cutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtb.Cut();
        }

        private void mi_Open_Click(object sender, EventArgs e)
        {
            try
            {
                ofd_OpenFile.InitialDirectory = Data.Path;
                ofd_OpenFile.FileName = Data.FileName;
                if (ofd_OpenFile.ShowDialog() == DialogResult.OK)
                {
                    rtb.Text = File.ReadAllText(ofd_OpenFile.FileName);
                    Data.FullPath = ofd_OpenFile.FileName;
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Unable to Open File\n\n" + ex, "Note Pad", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void frm_NotePad_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (!Data.Saved)
            {
                switch(MessageBox.Show("Do you want to Save Changes?","Note Pad",MessageBoxButtons.YesNoCancel,MessageBoxIcon.Warning))
                {
                    case DialogResult.Yes:
                        saveToolStripMenuItem_Click(null, null);
                        break;
                    case DialogResult.Cancel:
                        e.Cancel = true;
                        return;
                }
            }
        }

        private void saveAsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            try
            {
                sfd_SaveFile.InitialDirectory = Data.Path;
                sfd_SaveFile.FileName = Data.FileName;
                if (sfd_SaveFile.ShowDialog() == DialogResult.OK)
                {
                    Functions.SaveFile(sfd_SaveFile.FileName, rtb.Text);
                    Data.Saved = true;
                    Data.FullPath = sfd_SaveFile.FileName;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Unable to Save File\n\n" + ex, "Note Pad", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (Data.FileName.Length == 0)
                saveAsToolStripMenuItem_Click(null, null);
            else
            {
                Functions.SaveFile(Data.FullPath, rtb.Text);
                Data.Saved = true;
            }

        }

        private void rtb_TextChanged(object sender, EventArgs e)
        {
            Data.Saved = false;
        }

        private void fontToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FontDialog FD = new FontDialog();
            FD.Font = rtb.Font;
            if(FD.ShowDialog() == DialogResult.OK)
            {
                rtb.Font = FD.Font;
            }
            
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtb.Undo();
        }

        private void copyToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtb.Copy();
        }

        private void pasteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtb.Paste();
        }

        private void selectAllToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtb.SelectAll();
        }

        private void timeDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rtb.Text += DateTime.Now.ToShortTimeString() + " ";
            rtb.Text += DateTime.Now.ToShortDateString();
        }

        private void pageSetupToolStripMenuItem_Click(object sender, EventArgs e)
        {
            pageSetupDialog.ShowDialog();
        }

        private void printToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Data.Lines = new List<string>(rtb.Lines.Count());
            Data.Lines.AddRange(rtb.Lines);
            Data.MinX = (int)printDocument.DefaultPageSettings.Margins.Left;
            Data.Y = Data.MinY = (int)printDocument.DefaultPageSettings.Margins.Top;
            Data.MaxX = printDocument.DefaultPageSettings.PaperSize.Width - printDocument.DefaultPageSettings.Margins.Right;
            Data.MaxY = printDocument.DefaultPageSettings.PaperSize.Height - printDocument.DefaultPageSettings.Margins.Bottom;
            Data.CurrentLine = 0;
            printDocument.Print();
        }

        private void printDocument_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            e.HasMorePages = false;
            for (; Data.CurrentLine < Data.Lines.Count; Data.CurrentLine++)
            {
                Data.X = Data.MinX;
                bool LineBreak = true;
                /* Measuring and Re-arranging the Printing Line */
                while(e.Graphics.MeasureString(Data.Lines[Data.CurrentLine], rtb.Font).Width >= Data.PageWidth)
                {
                    string tmp = Data.Lines[Data.CurrentLine];
                    Data.Lines[Data.CurrentLine] = tmp.Substring(0, Data.Lines[Data.CurrentLine].Length - 1);
                    if (Data.CurrentLine == Data.Lines.Count - 1)
                        Data.Lines.Add(tmp.Substring(tmp.Length - 1));
                    else // A Space is added if it is a Line Break
                        Data.Lines[Data.CurrentLine + 1] = tmp.Substring(tmp.Length - 1) 
                        + (LineBreak ? " " : "") + Data.Lines[Data.CurrentLine + 1];
                    LineBreak = false;
                }
                /* Writing Line In the Document */
                e.Graphics.DrawString(Data.Lines[Data.CurrentLine], rtb.Font, Brushes.Black, new Point(Data.X,Data.Y));
                Data.Y += (int)e.Graphics.MeasureString(Data.Lines[Data.CurrentLine], rtb.Font).Height; // Increase Y
                if (Data.Y + e.Graphics.MeasureString("Y", rtb.Font).Height >= Data.MaxY)
                {
                    e.HasMorePages = true;
                    Data.X = Data.MinX;
                    Data.Y = Data.MinY;
                    Data.CurrentLine++;
                    break;
                } 
            }
        }

        private void rtb_SelectionChanged(object sender, EventArgs e)
        {
            int x = rtb.SelectionStart;            
            lbl_Status.Text = String.Format("Ln {0}, Col {1}",
                (rtb.GetLineFromCharIndex(x) + 1).ToString("N0"),
                (x - rtb.GetFirstCharIndexOfCurrentLine() + 1).ToString("N0"));
        }

        private void statusBarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            statusBarToolStripMenuItem.Checked = !statusBarToolStripMenuItem.Checked;
            tlp_Status.Visible = statusBarToolStripMenuItem.Checked;
        }

        private void tlp_Status_VisibleChanged(object sender, EventArgs e)
        {
            if (tlp_Status.Visible)
            {
                rtb.Height -= tlp_Status.Height;
            }
            else
            {
                rtb.Height += tlp_Status.Height;
            }
        }

        private void findToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Find frm = new frm_Find(frm_Find.FormTypes.Find);
            //frm.Parent = this;
            
            AddOwnedForm(frm);
            frm.Show();
        }

        private void findNextToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Find frm = new frm_Find(frm_Find.FormTypes.Find);
            //frm.Parent = this;
            frm.Show();
        }

        private void replaceToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frm_Find frm = new frm_Find(frm_Find.FormTypes.Replace);
            //frm.Parent = this;
            frm.Show();
        }
    }
}
