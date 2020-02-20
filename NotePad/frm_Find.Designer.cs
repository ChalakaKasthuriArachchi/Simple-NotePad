namespace NotePad
{
    partial class frm_Find
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tlp_Text = new System.Windows.Forms.TableLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.txt_FindText = new System.Windows.Forms.TextBox();
            this.tlp_Buttons = new System.Windows.Forms.TableLayoutPanel();
            this.btn_FindNext = new System.Windows.Forms.Button();
            this.btn_Replace = new System.Windows.Forms.Button();
            this.btn_ReplaceAll = new System.Windows.Forms.Button();
            this.btn_Cancel = new System.Windows.Forms.Button();
            this.chk_MatchCase = new System.Windows.Forms.CheckBox();
            this.grp_Direction = new System.Windows.Forms.GroupBox();
            this.rdo_Up = new System.Windows.Forms.RadioButton();
            this.rdo_Down = new System.Windows.Forms.RadioButton();
            this.lbl_ReplaceText = new System.Windows.Forms.Label();
            this.txt_ReplaceText = new System.Windows.Forms.TextBox();
            this.tlp_Text.SuspendLayout();
            this.tlp_Buttons.SuspendLayout();
            this.grp_Direction.SuspendLayout();
            this.SuspendLayout();
            // 
            // tlp_Text
            // 
            this.tlp_Text.BackColor = System.Drawing.SystemColors.Control;
            this.tlp_Text.ColumnCount = 2;
            this.tlp_Text.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 23.09783F));
            this.tlp_Text.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 76.90218F));
            this.tlp_Text.Controls.Add(this.txt_ReplaceText, 1, 1);
            this.tlp_Text.Controls.Add(this.txt_FindText, 1, 0);
            this.tlp_Text.Controls.Add(this.lbl_ReplaceText, 0, 1);
            this.tlp_Text.Controls.Add(this.label2, 0, 0);
            this.tlp_Text.Location = new System.Drawing.Point(2, 3);
            this.tlp_Text.Name = "tlp_Text";
            this.tlp_Text.RowCount = 2;
            this.tlp_Text.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Text.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlp_Text.Size = new System.Drawing.Size(368, 61);
            this.tlp_Text.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Find What :";
            // 
            // txt_FindText
            // 
            this.txt_FindText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_FindText.Location = new System.Drawing.Point(87, 5);
            this.txt_FindText.Name = "txt_FindText";
            this.txt_FindText.Size = new System.Drawing.Size(278, 20);
            this.txt_FindText.TabIndex = 1;
            // 
            // tlp_Buttons
            // 
            this.tlp_Buttons.BackColor = System.Drawing.SystemColors.Control;
            this.tlp_Buttons.ColumnCount = 1;
            this.tlp_Buttons.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tlp_Buttons.Controls.Add(this.btn_Cancel, 0, 3);
            this.tlp_Buttons.Controls.Add(this.btn_ReplaceAll, 0, 2);
            this.tlp_Buttons.Controls.Add(this.btn_Replace, 0, 1);
            this.tlp_Buttons.Controls.Add(this.btn_FindNext, 0, 0);
            this.tlp_Buttons.Location = new System.Drawing.Point(376, 3);
            this.tlp_Buttons.Name = "tlp_Buttons";
            this.tlp_Buttons.RowCount = 4;
            this.tlp_Buttons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_Buttons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_Buttons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_Buttons.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tlp_Buttons.Size = new System.Drawing.Size(83, 118);
            this.tlp_Buttons.TabIndex = 1;
            // 
            // btn_FindNext
            // 
            this.btn_FindNext.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_FindNext.Location = new System.Drawing.Point(4, 3);
            this.btn_FindNext.Name = "btn_FindNext";
            this.btn_FindNext.Size = new System.Drawing.Size(75, 23);
            this.btn_FindNext.TabIndex = 0;
            this.btn_FindNext.Text = "&Find Next";
            this.btn_FindNext.UseVisualStyleBackColor = true;
            this.btn_FindNext.Click += new System.EventHandler(this.btn_FindNext_Click);
            // 
            // btn_Replace
            // 
            this.btn_Replace.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Replace.Location = new System.Drawing.Point(4, 32);
            this.btn_Replace.Name = "btn_Replace";
            this.btn_Replace.Size = new System.Drawing.Size(75, 23);
            this.btn_Replace.TabIndex = 2;
            this.btn_Replace.Text = "&Replace";
            this.btn_Replace.UseVisualStyleBackColor = true;
            // 
            // btn_ReplaceAll
            // 
            this.btn_ReplaceAll.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_ReplaceAll.Location = new System.Drawing.Point(4, 61);
            this.btn_ReplaceAll.Name = "btn_ReplaceAll";
            this.btn_ReplaceAll.Size = new System.Drawing.Size(75, 23);
            this.btn_ReplaceAll.TabIndex = 3;
            this.btn_ReplaceAll.Text = "&Replace All";
            this.btn_ReplaceAll.UseVisualStyleBackColor = true;
            // 
            // btn_Cancel
            // 
            this.btn_Cancel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Cancel.Location = new System.Drawing.Point(4, 91);
            this.btn_Cancel.Name = "btn_Cancel";
            this.btn_Cancel.Size = new System.Drawing.Size(75, 23);
            this.btn_Cancel.TabIndex = 4;
            this.btn_Cancel.Text = "&Cancel";
            this.btn_Cancel.UseVisualStyleBackColor = true;
            // 
            // chk_MatchCase
            // 
            this.chk_MatchCase.AutoSize = true;
            this.chk_MatchCase.Location = new System.Drawing.Point(4, 103);
            this.chk_MatchCase.Name = "chk_MatchCase";
            this.chk_MatchCase.Size = new System.Drawing.Size(83, 17);
            this.chk_MatchCase.TabIndex = 2;
            this.chk_MatchCase.Text = "Match Case";
            this.chk_MatchCase.UseVisualStyleBackColor = true;
            // 
            // grp_Direction
            // 
            this.grp_Direction.Controls.Add(this.rdo_Down);
            this.grp_Direction.Controls.Add(this.rdo_Up);
            this.grp_Direction.Location = new System.Drawing.Point(250, 72);
            this.grp_Direction.Name = "grp_Direction";
            this.grp_Direction.Size = new System.Drawing.Size(118, 47);
            this.grp_Direction.TabIndex = 3;
            this.grp_Direction.TabStop = false;
            this.grp_Direction.Text = "Direction";
            // 
            // rdo_Up
            // 
            this.rdo_Up.AutoSize = true;
            this.rdo_Up.Location = new System.Drawing.Point(16, 19);
            this.rdo_Up.Name = "rdo_Up";
            this.rdo_Up.Size = new System.Drawing.Size(39, 17);
            this.rdo_Up.TabIndex = 0;
            this.rdo_Up.TabStop = true;
            this.rdo_Up.Text = "Up";
            this.rdo_Up.UseVisualStyleBackColor = true;
            // 
            // rdo_Down
            // 
            this.rdo_Down.AutoSize = true;
            this.rdo_Down.Checked = true;
            this.rdo_Down.Location = new System.Drawing.Point(61, 19);
            this.rdo_Down.Name = "rdo_Down";
            this.rdo_Down.Size = new System.Drawing.Size(53, 17);
            this.rdo_Down.TabIndex = 1;
            this.rdo_Down.TabStop = true;
            this.rdo_Down.Text = "Down";
            this.rdo_Down.UseVisualStyleBackColor = true;
            // 
            // lbl_ReplaceText
            // 
            this.lbl_ReplaceText.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lbl_ReplaceText.AutoSize = true;
            this.lbl_ReplaceText.Location = new System.Drawing.Point(3, 39);
            this.lbl_ReplaceText.Name = "lbl_ReplaceText";
            this.lbl_ReplaceText.Size = new System.Drawing.Size(78, 13);
            this.lbl_ReplaceText.TabIndex = 1;
            this.lbl_ReplaceText.Text = "Replace With :";
            // 
            // txt_ReplaceText
            // 
            this.txt_ReplaceText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.txt_ReplaceText.Location = new System.Drawing.Point(87, 35);
            this.txt_ReplaceText.Name = "txt_ReplaceText";
            this.txt_ReplaceText.Size = new System.Drawing.Size(278, 20);
            this.txt_ReplaceText.TabIndex = 2;
            // 
            // frm_Find
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(463, 124);
            this.Controls.Add(this.grp_Direction);
            this.Controls.Add(this.chk_MatchCase);
            this.Controls.Add(this.tlp_Buttons);
            this.Controls.Add(this.tlp_Text);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frm_Find";
            this.Text = "frm_Find";
            this.Load += new System.EventHandler(this.frm_Find_Load);
            this.tlp_Text.ResumeLayout(false);
            this.tlp_Text.PerformLayout();
            this.tlp_Buttons.ResumeLayout(false);
            this.grp_Direction.ResumeLayout(false);
            this.grp_Direction.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tlp_Text;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txt_FindText;
        private System.Windows.Forms.TableLayoutPanel tlp_Buttons;
        private System.Windows.Forms.Button btn_Cancel;
        private System.Windows.Forms.Button btn_ReplaceAll;
        private System.Windows.Forms.Button btn_Replace;
        private System.Windows.Forms.Button btn_FindNext;
        private System.Windows.Forms.CheckBox chk_MatchCase;
        private System.Windows.Forms.GroupBox grp_Direction;
        private System.Windows.Forms.RadioButton rdo_Down;
        private System.Windows.Forms.RadioButton rdo_Up;
        private System.Windows.Forms.TextBox txt_ReplaceText;
        private System.Windows.Forms.Label lbl_ReplaceText;
    }
}