namespace DVLD.UI
{
    partial class CtrlUserLoginInformation
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lnkLblUpdateUserInformation = new ReaLTaiizor.Controls.MetroLinkLabel();
            lblUsername = new ReaLTaiizor.Controls.BigLabel();
            lblUserID = new ReaLTaiizor.Controls.BigLabel();
            bigLabel9 = new ReaLTaiizor.Controls.BigLabel();
            bigLabel8 = new ReaLTaiizor.Controls.BigLabel();
            lblActivetion = new ReaLTaiizor.Controls.BigLabel();
            bigLabel2 = new ReaLTaiizor.Controls.BigLabel();
            SuspendLayout();
            // 
            // lnkLblUpdateUserInformation
            // 
            lnkLblUpdateUserInformation.Font = new Font("Microsoft Sans Serif", 10F);
            lnkLblUpdateUserInformation.IsDerivedStyle = true;
            lnkLblUpdateUserInformation.LinkBehavior = LinkBehavior.HoverUnderline;
            lnkLblUpdateUserInformation.Location = new Point(10, 76);
            lnkLblUpdateUserInformation.Name = "lnkLblUpdateUserInformation";
            lnkLblUpdateUserInformation.Size = new Size(200, 23);
            lnkLblUpdateUserInformation.Style = ReaLTaiizor.Enum.Metro.Style.Dark;
            lnkLblUpdateUserInformation.StyleManager = null;
            lnkLblUpdateUserInformation.TabIndex = 48;
            lnkLblUpdateUserInformation.TabStop = true;
            lnkLblUpdateUserInformation.Text = "Update User Information";
            lnkLblUpdateUserInformation.ThemeAuthor = "Taiizor";
            lnkLblUpdateUserInformation.ThemeName = "MetroLight";
            lnkLblUpdateUserInformation.VisitedLinkColor = Color.FromArgb(45, 157, 205);
            lnkLblUpdateUserInformation.LinkClicked += lnkLblUpdateUserInformation_LinkClicked;
            // 
            // lblUsername
            // 
            lblUsername.AutoSize = true;
            lblUsername.BackColor = Color.Transparent;
            lblUsername.Font = new Font("Arial Narrow", 13.8F);
            lblUsername.ForeColor = Color.Black;
            lblUsername.Location = new Point(340, 17);
            lblUsername.Name = "lblUsername";
            lblUsername.Size = new Size(42, 27);
            lblUsername.TabIndex = 47;
            lblUsername.Text = "???";
            // 
            // lblUserID
            // 
            lblUserID.AutoSize = true;
            lblUserID.BackColor = Color.Transparent;
            lblUserID.Font = new Font("Arial Narrow", 13.8F);
            lblUserID.ForeColor = Color.Black;
            lblUserID.Location = new Point(105, 17);
            lblUserID.Name = "lblUserID";
            lblUserID.Size = new Size(42, 27);
            lblUserID.TabIndex = 46;
            lblUserID.Text = "???";
            // 
            // bigLabel9
            // 
            bigLabel9.AutoSize = true;
            bigLabel9.BackColor = Color.Transparent;
            bigLabel9.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bigLabel9.ForeColor = Color.Black;
            bigLabel9.Location = new Point(232, 17);
            bigLabel9.Name = "bigLabel9";
            bigLabel9.Size = new Size(102, 27);
            bigLabel9.TabIndex = 45;
            bigLabel9.Text = "Username";
            // 
            // bigLabel8
            // 
            bigLabel8.AutoSize = true;
            bigLabel8.BackColor = Color.Transparent;
            bigLabel8.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bigLabel8.ForeColor = Color.Black;
            bigLabel8.Location = new Point(22, 17);
            bigLabel8.Name = "bigLabel8";
            bigLabel8.Size = new Size(77, 27);
            bigLabel8.TabIndex = 44;
            bigLabel8.Text = "User ID";
            // 
            // lblActivetion
            // 
            lblActivetion.AutoSize = true;
            lblActivetion.BackColor = Color.Transparent;
            lblActivetion.Font = new Font("Arial Narrow", 13.8F);
            lblActivetion.ForeColor = Color.Black;
            lblActivetion.Location = new Point(624, 17);
            lblActivetion.Name = "lblActivetion";
            lblActivetion.Size = new Size(42, 27);
            lblActivetion.TabIndex = 50;
            lblActivetion.Text = "???";
            // 
            // bigLabel2
            // 
            bigLabel2.AutoSize = true;
            bigLabel2.BackColor = Color.Transparent;
            bigLabel2.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bigLabel2.ForeColor = Color.Black;
            bigLabel2.Location = new Point(515, 17);
            bigLabel2.Name = "bigLabel2";
            bigLabel2.Size = new Size(103, 27);
            bigLabel2.TabIndex = 49;
            bigLabel2.Text = "Activation";
            // 
            // CtrlUserLoginInformation
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblActivetion);
            Controls.Add(bigLabel2);
            Controls.Add(lnkLblUpdateUserInformation);
            Controls.Add(lblUsername);
            Controls.Add(lblUserID);
            Controls.Add(bigLabel9);
            Controls.Add(bigLabel8);
            Name = "CtrlUserLoginInformation";
            Size = new Size(738, 102);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.MetroLinkLabel lnkLblUpdateUserInformation;
        private ReaLTaiizor.Controls.BigLabel lblUsername;
        private ReaLTaiizor.Controls.BigLabel lblUserID;
        private ReaLTaiizor.Controls.BigLabel bigLabel9;
        private ReaLTaiizor.Controls.BigLabel bigLabel8;
        private ReaLTaiizor.Controls.BigLabel lblActivetion;
        private ReaLTaiizor.Controls.BigLabel bigLabel2;
    }
}
