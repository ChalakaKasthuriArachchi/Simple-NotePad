using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NotePad
{
    public partial class frm_Find : Form
    {
        public enum FormTypes { Find, Replace};
        public frm_Find(FormTypes FormType)
        {
            InitializeComponent();
            Text = FormType.ToString();
            switch (FormType)
            {
                case FormTypes.Find:
                    tlp_Text.Controls.Remove(lbl_ReplaceText);
                    tlp_Text.Controls.Remove(txt_ReplaceText);
                    tlp_Text.RowCount--;

                    tlp_Buttons.Controls.Remove(btn_Replace);
                    tlp_Buttons.Controls.Remove(btn_ReplaceAll);
                    tlp_Buttons.SetRow(btn_Cancel, 1);
                    tlp_Buttons.RowCount = tlp_Buttons.RowCount - 2;
                    tlp_Buttons.Height = tlp_Buttons.Height / 2;
                    //Height = tlp_Buttons.Height + 45;
                    break;
                case FormTypes.Replace:
                    grp_Direction.Visible = false;
                    break;
                default:
                    break;
            }
        }

        private void frm_Find_Load(object sender, EventArgs e)
        {

        }

        private void btn_FindNext_Click(object sender, EventArgs e)
        {

        }
    }
}
