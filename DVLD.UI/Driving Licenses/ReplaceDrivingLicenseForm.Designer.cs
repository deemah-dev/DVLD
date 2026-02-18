namespace DVLD.UI
{
    partial class ReplaceDrivingLicenseForm
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
            ctrlSearchForLocalLicense1 = new CtrlSearchForLocalLicense();
            lblMainLabel = new ReaLTaiizor.Controls.BigLabel();
            foreverClose1 = new ReaLTaiizor.Controls.ForeverClose();
            bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            rbtnLostLicense = new ReaLTaiizor.Controls.MaterialRadioButton();
            rbtnDamagedLicense = new ReaLTaiizor.Controls.MaterialRadioButton();
            bigLabel16 = new ReaLTaiizor.Controls.BigLabel();
            lblOldLicenseID = new ReaLTaiizor.Controls.BigLabel();
            bigLabel13 = new ReaLTaiizor.Controls.BigLabel();
            lblNewLicenseID = new ReaLTaiizor.Controls.BigLabel();
            bigLabel15 = new ReaLTaiizor.Controls.BigLabel();
            lblApplicationFees = new ReaLTaiizor.Controls.BigLabel();
            bigLabel6 = new ReaLTaiizor.Controls.BigLabel();
            lblApplicationDate = new ReaLTaiizor.Controls.BigLabel();
            bigLabel11 = new ReaLTaiizor.Controls.BigLabel();
            lblApplicationID = new ReaLTaiizor.Controls.BigLabel();
            bigLabel3 = new ReaLTaiizor.Controls.BigLabel();
            lblCreatedByUsername = new ReaLTaiizor.Controls.BigLabel();
            bigLabel4 = new ReaLTaiizor.Controls.BigLabel();
            lnkLblShowNewLicense = new ReaLTaiizor.Controls.MetroLinkLabel();
            lnkLblShowLicenseHistory = new ReaLTaiizor.Controls.MetroLinkLabel();
            btnIssue = new ReaLTaiizor.Controls.MaterialButton();
            SuspendLayout();
            // 
            // ctrlSearchForLocalLicense1
            // 
            ctrlSearchForLocalLicense1.Location = new Point(12, 68);
            ctrlSearchForLocalLicense1.Name = "ctrlSearchForLocalLicense1";
            ctrlSearchForLocalLicense1.Size = new Size(820, 504);
            ctrlSearchForLocalLicense1.TabIndex = 0;
            ctrlSearchForLocalLicense1.OnLicenseSelected += ctrlSearchForLocalLicense1_OnLicenseSelected;
            // 
            // lblMainLabel
            // 
            lblMainLabel.AutoSize = true;
            lblMainLabel.BackColor = Color.Transparent;
            lblMainLabel.Font = new Font("Arial Narrow", 25.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMainLabel.ForeColor = Color.Black;
            lblMainLabel.Location = new Point(3, 3);
            lblMainLabel.Name = "lblMainLabel";
            lblMainLabel.Size = new Size(368, 49);
            lblMainLabel.TabIndex = 18;
            lblMainLabel.Text = "Replace Local License";
            // 
            // foreverClose1
            // 
            foreverClose1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            foreverClose1.BackColor = Color.White;
            foreverClose1.BaseColor = Color.FromArgb(45, 47, 49);
            foreverClose1.DefaultLocation = true;
            foreverClose1.DownColor = Color.FromArgb(30, 0, 0, 0);
            foreverClose1.Font = new Font("Marlett", 10F);
            foreverClose1.Location = new Point(808, 16);
            foreverClose1.Name = "foreverClose1";
            foreverClose1.OverColor = Color.FromArgb(30, 255, 255, 255);
            foreverClose1.Size = new Size(18, 18);
            foreverClose1.TabIndex = 17;
            foreverClose1.Text = "foreverClose1";
            foreverClose1.TextColor = Color.FromArgb(243, 243, 243);
            // 
            // bigLabel1
            // 
            bigLabel1.AutoSize = true;
            bigLabel1.BackColor = Color.Transparent;
            bigLabel1.Font = new Font("Arial Narrow", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bigLabel1.ForeColor = Color.Black;
            bigLabel1.Location = new Point(12, 595);
            bigLabel1.Name = "bigLabel1";
            bigLabel1.Size = new Size(249, 33);
            bigLabel1.TabIndex = 82;
            bigLabel1.Text = "Replacement Reason";
            // 
            // rbtnLostLicense
            // 
            rbtnLostLicense.AutoSize = true;
            rbtnLostLicense.Checked = true;
            rbtnLostLicense.Depth = 0;
            rbtnLostLicense.Font = new Font("Segoe UI", 13.8F);
            rbtnLostLicense.Location = new Point(291, 591);
            rbtnLostLicense.Margin = new Padding(0);
            rbtnLostLicense.MouseLocation = new Point(-1, -1);
            rbtnLostLicense.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            rbtnLostLicense.Name = "rbtnLostLicense";
            rbtnLostLicense.Ripple = true;
            rbtnLostLicense.Size = new Size(124, 37);
            rbtnLostLicense.TabIndex = 83;
            rbtnLostLicense.TabStop = true;
            rbtnLostLicense.Text = "Lost License";
            rbtnLostLicense.UseAccentColor = false;
            rbtnLostLicense.UseVisualStyleBackColor = true;
            // 
            // rbtnDamagedLicense
            // 
            rbtnDamagedLicense.AutoSize = true;
            rbtnDamagedLicense.Depth = 0;
            rbtnDamagedLicense.Font = new Font("Segoe UI", 13.8F);
            rbtnDamagedLicense.Location = new Point(456, 591);
            rbtnDamagedLicense.Margin = new Padding(0);
            rbtnDamagedLicense.MouseLocation = new Point(-1, -1);
            rbtnDamagedLicense.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            rbtnDamagedLicense.Name = "rbtnDamagedLicense";
            rbtnDamagedLicense.Ripple = true;
            rbtnDamagedLicense.Size = new Size(162, 37);
            rbtnDamagedLicense.TabIndex = 84;
            rbtnDamagedLicense.TabStop = true;
            rbtnDamagedLicense.Text = "Damaged License";
            rbtnDamagedLicense.UseAccentColor = false;
            rbtnDamagedLicense.UseVisualStyleBackColor = true;
            rbtnDamagedLicense.CheckedChanged += rBDamagedLicense_CheckedChanged;
            // 
            // bigLabel16
            // 
            bigLabel16.AutoSize = true;
            bigLabel16.BackColor = Color.Transparent;
            bigLabel16.Font = new Font("Arial Narrow", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bigLabel16.ForeColor = Color.Black;
            bigLabel16.Location = new Point(28, 647);
            bigLabel16.Name = "bigLabel16";
            bigLabel16.Size = new Size(516, 40);
            bigLabel16.TabIndex = 85;
            bigLabel16.Text = "Replacement Application Information";
            // 
            // lblOldLicenseID
            // 
            lblOldLicenseID.AutoSize = true;
            lblOldLicenseID.BackColor = Color.Transparent;
            lblOldLicenseID.Font = new Font("Arial Narrow", 13.8F);
            lblOldLicenseID.ForeColor = Color.Black;
            lblOldLicenseID.Location = new Point(576, 751);
            lblOldLicenseID.Name = "lblOldLicenseID";
            lblOldLicenseID.Size = new Size(42, 27);
            lblOldLicenseID.TabIndex = 108;
            lblOldLicenseID.Text = "???";
            // 
            // bigLabel13
            // 
            bigLabel13.AutoSize = true;
            bigLabel13.BackColor = Color.Transparent;
            bigLabel13.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bigLabel13.ForeColor = Color.Black;
            bigLabel13.Location = new Point(415, 751);
            bigLabel13.Name = "bigLabel13";
            bigLabel13.Size = new Size(143, 27);
            bigLabel13.TabIndex = 107;
            bigLabel13.Text = "Old License ID";
            // 
            // lblNewLicenseID
            // 
            lblNewLicenseID.AutoSize = true;
            lblNewLicenseID.BackColor = Color.Transparent;
            lblNewLicenseID.Font = new Font("Arial Narrow", 13.8F);
            lblNewLicenseID.ForeColor = Color.Black;
            lblNewLicenseID.Location = new Point(576, 702);
            lblNewLicenseID.Name = "lblNewLicenseID";
            lblNewLicenseID.Size = new Size(42, 27);
            lblNewLicenseID.TabIndex = 106;
            lblNewLicenseID.Text = "???";
            // 
            // bigLabel15
            // 
            bigLabel15.AutoSize = true;
            bigLabel15.BackColor = Color.Transparent;
            bigLabel15.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bigLabel15.ForeColor = Color.Black;
            bigLabel15.Location = new Point(415, 702);
            bigLabel15.Name = "bigLabel15";
            bigLabel15.Size = new Size(150, 27);
            bigLabel15.TabIndex = 105;
            bigLabel15.Text = "New License ID";
            // 
            // lblApplicationFees
            // 
            lblApplicationFees.AutoSize = true;
            lblApplicationFees.BackColor = Color.Transparent;
            lblApplicationFees.Font = new Font("Arial Narrow", 13.8F);
            lblApplicationFees.ForeColor = Color.Black;
            lblApplicationFees.Location = new Point(166, 800);
            lblApplicationFees.Name = "lblApplicationFees";
            lblApplicationFees.Size = new Size(42, 27);
            lblApplicationFees.TabIndex = 104;
            lblApplicationFees.Text = "???";
            // 
            // bigLabel6
            // 
            bigLabel6.AutoSize = true;
            bigLabel6.BackColor = Color.Transparent;
            bigLabel6.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bigLabel6.ForeColor = Color.Black;
            bigLabel6.Location = new Point(28, 800);
            bigLabel6.Name = "bigLabel6";
            bigLabel6.Size = new Size(102, 27);
            bigLabel6.TabIndex = 103;
            bigLabel6.Text = "App. Fees";
            // 
            // lblApplicationDate
            // 
            lblApplicationDate.AutoSize = true;
            lblApplicationDate.BackColor = Color.Transparent;
            lblApplicationDate.Font = new Font("Arial Narrow", 13.8F);
            lblApplicationDate.ForeColor = Color.Black;
            lblApplicationDate.Location = new Point(166, 751);
            lblApplicationDate.Name = "lblApplicationDate";
            lblApplicationDate.Size = new Size(42, 27);
            lblApplicationDate.TabIndex = 102;
            lblApplicationDate.Text = "???";
            // 
            // bigLabel11
            // 
            bigLabel11.AutoSize = true;
            bigLabel11.BackColor = Color.Transparent;
            bigLabel11.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bigLabel11.ForeColor = Color.Black;
            bigLabel11.Location = new Point(28, 751);
            bigLabel11.Name = "bigLabel11";
            bigLabel11.Size = new Size(100, 27);
            bigLabel11.TabIndex = 101;
            bigLabel11.Text = "App. Date";
            // 
            // lblApplicationID
            // 
            lblApplicationID.AutoSize = true;
            lblApplicationID.BackColor = Color.Transparent;
            lblApplicationID.Font = new Font("Arial Narrow", 13.8F);
            lblApplicationID.ForeColor = Color.Black;
            lblApplicationID.Location = new Point(166, 702);
            lblApplicationID.Name = "lblApplicationID";
            lblApplicationID.Size = new Size(42, 27);
            lblApplicationID.TabIndex = 100;
            lblApplicationID.Text = "???";
            // 
            // bigLabel3
            // 
            bigLabel3.AutoSize = true;
            bigLabel3.BackColor = Color.Transparent;
            bigLabel3.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bigLabel3.ForeColor = Color.Black;
            bigLabel3.Location = new Point(28, 702);
            bigLabel3.Name = "bigLabel3";
            bigLabel3.Size = new Size(79, 27);
            bigLabel3.TabIndex = 99;
            bigLabel3.Text = "App. ID";
            // 
            // lblCreatedByUsername
            // 
            lblCreatedByUsername.AutoSize = true;
            lblCreatedByUsername.BackColor = Color.Transparent;
            lblCreatedByUsername.Font = new Font("Arial Narrow", 13.8F);
            lblCreatedByUsername.ForeColor = Color.Black;
            lblCreatedByUsername.Location = new Point(576, 800);
            lblCreatedByUsername.Name = "lblCreatedByUsername";
            lblCreatedByUsername.Size = new Size(42, 27);
            lblCreatedByUsername.TabIndex = 110;
            lblCreatedByUsername.Text = "???";
            // 
            // bigLabel4
            // 
            bigLabel4.AutoSize = true;
            bigLabel4.BackColor = Color.Transparent;
            bigLabel4.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bigLabel4.ForeColor = Color.Black;
            bigLabel4.Location = new Point(415, 800);
            bigLabel4.Name = "bigLabel4";
            bigLabel4.Size = new Size(110, 27);
            bigLabel4.TabIndex = 109;
            bigLabel4.Text = "Created By";
            // 
            // lnkLblShowNewLicense
            // 
            lnkLblShowNewLicense.Enabled = false;
            lnkLblShowNewLicense.Font = new Font("Microsoft Sans Serif", 10F);
            lnkLblShowNewLicense.IsDerivedStyle = true;
            lnkLblShowNewLicense.LinkBehavior = LinkBehavior.HoverUnderline;
            lnkLblShowNewLicense.Location = new Point(291, 865);
            lnkLblShowNewLicense.Name = "lnkLblShowNewLicense";
            lnkLblShowNewLicense.Size = new Size(160, 23);
            lnkLblShowNewLicense.Style = ReaLTaiizor.Enum.Metro.Style.Dark;
            lnkLblShowNewLicense.StyleManager = null;
            lnkLblShowNewLicense.TabIndex = 111;
            lnkLblShowNewLicense.TabStop = true;
            lnkLblShowNewLicense.Text = "Show New License";
            lnkLblShowNewLicense.ThemeAuthor = "Taiizor";
            lnkLblShowNewLicense.ThemeName = "MetroLight";
            lnkLblShowNewLicense.VisitedLinkColor = Color.FromArgb(45, 157, 205);
            lnkLblShowNewLicense.LinkClicked += lnkLblShowNewLicense_LinkClicked;
            // 
            // lnkLblShowLicenseHistory
            // 
            lnkLblShowLicenseHistory.Enabled = false;
            lnkLblShowLicenseHistory.Font = new Font("Microsoft Sans Serif", 10F);
            lnkLblShowLicenseHistory.IsDerivedStyle = true;
            lnkLblShowLicenseHistory.LinkBehavior = LinkBehavior.HoverUnderline;
            lnkLblShowLicenseHistory.Location = new Point(28, 865);
            lnkLblShowLicenseHistory.Name = "lnkLblShowLicenseHistory";
            lnkLblShowLicenseHistory.Size = new Size(233, 23);
            lnkLblShowLicenseHistory.Style = ReaLTaiizor.Enum.Metro.Style.Dark;
            lnkLblShowLicenseHistory.StyleManager = null;
            lnkLblShowLicenseHistory.TabIndex = 112;
            lnkLblShowLicenseHistory.TabStop = true;
            lnkLblShowLicenseHistory.Text = "Show Driver Licenses History";
            lnkLblShowLicenseHistory.ThemeAuthor = "Taiizor";
            lnkLblShowLicenseHistory.ThemeName = "MetroLight";
            lnkLblShowLicenseHistory.VisitedLinkColor = Color.FromArgb(45, 157, 205);
            lnkLblShowLicenseHistory.LinkClicked += lnkLblShowLicenseHistory_LinkClicked;
            // 
            // btnIssue
            // 
            btnIssue.AutoSize = false;
            btnIssue.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnIssue.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnIssue.Depth = 0;
            btnIssue.Enabled = false;
            btnIssue.HighEmphasis = true;
            btnIssue.Icon = null;
            btnIssue.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnIssue.Location = new Point(729, 829);
            btnIssue.Margin = new Padding(4, 6, 4, 6);
            btnIssue.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnIssue.Name = "btnIssue";
            btnIssue.NoAccentTextColor = Color.Empty;
            btnIssue.Size = new Size(96, 53);
            btnIssue.TabIndex = 113;
            btnIssue.Text = "Issue";
            btnIssue.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnIssue.UseAccentColor = false;
            btnIssue.UseVisualStyleBackColor = true;
            btnIssue.Click += btnIssue_Click;
            // 
            // ReplaceDrivingLicenseForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(838, 897);
            Controls.Add(btnIssue);
            Controls.Add(lnkLblShowLicenseHistory);
            Controls.Add(lnkLblShowNewLicense);
            Controls.Add(lblCreatedByUsername);
            Controls.Add(bigLabel4);
            Controls.Add(lblOldLicenseID);
            Controls.Add(bigLabel13);
            Controls.Add(lblNewLicenseID);
            Controls.Add(bigLabel15);
            Controls.Add(lblApplicationFees);
            Controls.Add(bigLabel6);
            Controls.Add(lblApplicationDate);
            Controls.Add(bigLabel11);
            Controls.Add(lblApplicationID);
            Controls.Add(bigLabel3);
            Controls.Add(bigLabel16);
            Controls.Add(rbtnDamagedLicense);
            Controls.Add(rbtnLostLicense);
            Controls.Add(bigLabel1);
            Controls.Add(lblMainLabel);
            Controls.Add(foreverClose1);
            Controls.Add(ctrlSearchForLocalLicense1);
            Name = "ReplaceDrivingLicenseForm";
            Text = "ReplaceDrivingLicenseForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CtrlSearchForLocalLicense ctrlSearchForLocalLicense1;
        private ReaLTaiizor.Controls.BigLabel lblMainLabel;
        private ReaLTaiizor.Controls.ForeverClose foreverClose1;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private ReaLTaiizor.Controls.MaterialRadioButton rbtnLostLicense;
        private ReaLTaiizor.Controls.MaterialRadioButton rbtnDamagedLicense;
        private ReaLTaiizor.Controls.BigLabel bigLabel16;
        private ReaLTaiizor.Controls.BigLabel lblOldLicenseID;
        private ReaLTaiizor.Controls.BigLabel bigLabel13;
        private ReaLTaiizor.Controls.BigLabel lblNewLicenseID;
        private ReaLTaiizor.Controls.BigLabel bigLabel15;
        private ReaLTaiizor.Controls.BigLabel lblApplicationFees;
        private ReaLTaiizor.Controls.BigLabel bigLabel6;
        private ReaLTaiizor.Controls.BigLabel lblApplicationDate;
        private ReaLTaiizor.Controls.BigLabel bigLabel11;
        private ReaLTaiizor.Controls.BigLabel lblApplicationID;
        private ReaLTaiizor.Controls.BigLabel bigLabel3;
        private ReaLTaiizor.Controls.BigLabel lblCreatedByUsername;
        private ReaLTaiizor.Controls.BigLabel bigLabel4;
        private ReaLTaiizor.Controls.MetroLinkLabel lnkLblShowNewLicense;
        private ReaLTaiizor.Controls.MetroLinkLabel lnkLblShowLicenseHistory;
        private ReaLTaiizor.Controls.MaterialButton btnIssue;
    }
}