namespace DVLD.UI
{
    partial class DetainDrivingLicenseForm
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
            lblMainLabel = new ReaLTaiizor.Controls.BigLabel();
            btnDetain = new ReaLTaiizor.Controls.MaterialButton();
            lnkLblShowLicensesHistory = new ReaLTaiizor.Controls.MetroLinkLabel();
            lnkLblShowNewLicense = new ReaLTaiizor.Controls.MetroLinkLabel();
            lblCretedByUsername = new ReaLTaiizor.Controls.BigLabel();
            lblCreatedBy = new ReaLTaiizor.Controls.BigLabel();
            lblLicenseID = new ReaLTaiizor.Controls.BigLabel();
            bigLabel15 = new ReaLTaiizor.Controls.BigLabel();
            lblDetainDate = new ReaLTaiizor.Controls.BigLabel();
            bigLabel11 = new ReaLTaiizor.Controls.BigLabel();
            lblDetainID = new ReaLTaiizor.Controls.BigLabel();
            bigLabel3 = new ReaLTaiizor.Controls.BigLabel();
            bigLabel16 = new ReaLTaiizor.Controls.BigLabel();
            ctrlSearchForLocalLicense1 = new CtrlSearchForLocalLicense();
            foreverClose1 = new ReaLTaiizor.Controls.ForeverClose();
            txtBFees = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            SuspendLayout();
            // 
            // lblMainLabel
            // 
            lblMainLabel.AutoSize = true;
            lblMainLabel.BackColor = Color.Transparent;
            lblMainLabel.Font = new Font("Arial Narrow", 25.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMainLabel.ForeColor = Color.Black;
            lblMainLabel.Location = new Point(8, 8);
            lblMainLabel.Name = "lblMainLabel";
            lblMainLabel.Size = new Size(250, 49);
            lblMainLabel.TabIndex = 184;
            lblMainLabel.Text = "Detain License";
            // 
            // btnDetain
            // 
            btnDetain.AutoSize = false;
            btnDetain.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnDetain.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnDetain.Depth = 0;
            btnDetain.Enabled = false;
            btnDetain.HighEmphasis = true;
            btnDetain.Icon = null;
            btnDetain.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnDetain.Location = new Point(720, 790);
            btnDetain.Margin = new Padding(4, 6, 4, 6);
            btnDetain.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnDetain.Name = "btnDetain";
            btnDetain.NoAccentTextColor = Color.Empty;
            btnDetain.Size = new Size(96, 53);
            btnDetain.TabIndex = 183;
            btnDetain.Text = "Detain";
            btnDetain.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnDetain.UseAccentColor = false;
            btnDetain.UseVisualStyleBackColor = true;
            btnDetain.Click += btnDetain_Click;
            // 
            // lnkLblShowLicensesHistory
            // 
            lnkLblShowLicensesHistory.Enabled = false;
            lnkLblShowLicensesHistory.Font = new Font("Microsoft Sans Serif", 10F);
            lnkLblShowLicensesHistory.IsDerivedStyle = true;
            lnkLblShowLicensesHistory.LinkBehavior = LinkBehavior.HoverUnderline;
            lnkLblShowLicensesHistory.Location = new Point(8, 806);
            lnkLblShowLicensesHistory.Name = "lnkLblShowLicensesHistory";
            lnkLblShowLicensesHistory.Size = new Size(233, 23);
            lnkLblShowLicensesHistory.Style = ReaLTaiizor.Enum.Metro.Style.Dark;
            lnkLblShowLicensesHistory.StyleManager = null;
            lnkLblShowLicensesHistory.TabIndex = 182;
            lnkLblShowLicensesHistory.TabStop = true;
            lnkLblShowLicensesHistory.Text = "Show Driver Licenses History";
            lnkLblShowLicensesHistory.ThemeAuthor = "Taiizor";
            lnkLblShowLicensesHistory.ThemeName = "MetroLight";
            lnkLblShowLicensesHistory.VisitedLinkColor = Color.FromArgb(45, 157, 205);
            lnkLblShowLicensesHistory.LinkClicked += lnkLblShowLicenseHistory_LinkClicked;
            // 
            // lnkLblShowNewLicense
            // 
            lnkLblShowNewLicense.Enabled = false;
            lnkLblShowNewLicense.Font = new Font("Microsoft Sans Serif", 10F);
            lnkLblShowNewLicense.IsDerivedStyle = true;
            lnkLblShowNewLicense.LinkBehavior = LinkBehavior.HoverUnderline;
            lnkLblShowNewLicense.Location = new Point(271, 806);
            lnkLblShowNewLicense.Name = "lnkLblShowNewLicense";
            lnkLblShowNewLicense.Size = new Size(160, 23);
            lnkLblShowNewLicense.Style = ReaLTaiizor.Enum.Metro.Style.Dark;
            lnkLblShowNewLicense.StyleManager = null;
            lnkLblShowNewLicense.TabIndex = 181;
            lnkLblShowNewLicense.TabStop = true;
            lnkLblShowNewLicense.Text = "Show License";
            lnkLblShowNewLicense.ThemeAuthor = "Taiizor";
            lnkLblShowNewLicense.ThemeName = "MetroLight";
            lnkLblShowNewLicense.VisitedLinkColor = Color.FromArgb(45, 157, 205);
            lnkLblShowNewLicense.LinkClicked += lnkLblShowLicenseInformation_LinkClicked;
            // 
            // lblCretedByUsername
            // 
            lblCretedByUsername.AutoSize = true;
            lblCretedByUsername.BackColor = Color.Transparent;
            lblCretedByUsername.Font = new Font("Arial Narrow", 13.8F);
            lblCretedByUsername.ForeColor = Color.Black;
            lblCretedByUsername.Location = new Point(575, 699);
            lblCretedByUsername.Name = "lblCretedByUsername";
            lblCretedByUsername.Size = new Size(42, 27);
            lblCretedByUsername.TabIndex = 178;
            lblCretedByUsername.Text = "???";
            // 
            // lblCreatedBy
            // 
            lblCreatedBy.AutoSize = true;
            lblCreatedBy.BackColor = Color.Transparent;
            lblCreatedBy.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblCreatedBy.ForeColor = Color.Black;
            lblCreatedBy.Location = new Point(414, 697);
            lblCreatedBy.Name = "lblCreatedBy";
            lblCreatedBy.Size = new Size(110, 27);
            lblCreatedBy.TabIndex = 177;
            lblCreatedBy.Text = "Created By";
            // 
            // lblLicenseID
            // 
            lblLicenseID.AutoSize = true;
            lblLicenseID.BackColor = Color.Transparent;
            lblLicenseID.Font = new Font("Arial Narrow", 13.8F);
            lblLicenseID.ForeColor = Color.Black;
            lblLicenseID.Location = new Point(575, 653);
            lblLicenseID.Name = "lblLicenseID";
            lblLicenseID.Size = new Size(42, 27);
            lblLicenseID.TabIndex = 176;
            lblLicenseID.Text = "???";
            // 
            // bigLabel15
            // 
            bigLabel15.AutoSize = true;
            bigLabel15.BackColor = Color.Transparent;
            bigLabel15.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bigLabel15.ForeColor = Color.Black;
            bigLabel15.Location = new Point(414, 653);
            bigLabel15.Name = "bigLabel15";
            bigLabel15.Size = new Size(106, 27);
            bigLabel15.TabIndex = 175;
            bigLabel15.Text = "License ID";
            // 
            // lblDetainDate
            // 
            lblDetainDate.AutoSize = true;
            lblDetainDate.BackColor = Color.Transparent;
            lblDetainDate.Font = new Font("Arial Narrow", 13.8F);
            lblDetainDate.ForeColor = Color.Black;
            lblDetainDate.Location = new Point(165, 697);
            lblDetainDate.Name = "lblDetainDate";
            lblDetainDate.Size = new Size(42, 27);
            lblDetainDate.TabIndex = 172;
            lblDetainDate.Text = "???";
            // 
            // bigLabel11
            // 
            bigLabel11.AutoSize = true;
            bigLabel11.BackColor = Color.Transparent;
            bigLabel11.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bigLabel11.ForeColor = Color.Black;
            bigLabel11.Location = new Point(27, 697);
            bigLabel11.Name = "bigLabel11";
            bigLabel11.Size = new Size(114, 27);
            bigLabel11.TabIndex = 171;
            bigLabel11.Text = "Detain Date";
            // 
            // lblDetainID
            // 
            lblDetainID.AutoSize = true;
            lblDetainID.BackColor = Color.Transparent;
            lblDetainID.Font = new Font("Arial Narrow", 13.8F);
            lblDetainID.ForeColor = Color.Black;
            lblDetainID.Location = new Point(165, 653);
            lblDetainID.Name = "lblDetainID";
            lblDetainID.Size = new Size(42, 27);
            lblDetainID.TabIndex = 170;
            lblDetainID.Text = "???";
            // 
            // bigLabel3
            // 
            bigLabel3.AutoSize = true;
            bigLabel3.BackColor = Color.Transparent;
            bigLabel3.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bigLabel3.ForeColor = Color.Black;
            bigLabel3.Location = new Point(27, 653);
            bigLabel3.Name = "bigLabel3";
            bigLabel3.Size = new Size(93, 27);
            bigLabel3.TabIndex = 169;
            bigLabel3.Text = "Detain ID";
            // 
            // bigLabel16
            // 
            bigLabel16.AutoSize = true;
            bigLabel16.BackColor = Color.Transparent;
            bigLabel16.Font = new Font("Arial Narrow", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bigLabel16.ForeColor = Color.Black;
            bigLabel16.Location = new Point(27, 598);
            bigLabel16.Name = "bigLabel16";
            bigLabel16.Size = new Size(431, 40);
            bigLabel16.TabIndex = 168;
            bigLabel16.Text = "Renew Application Information";
            // 
            // ctrlSearchForLocalLicense1
            // 
            ctrlSearchForLocalLicense1.Location = new Point(12, 80);
            ctrlSearchForLocalLicense1.Name = "ctrlSearchForLocalLicense1";
            ctrlSearchForLocalLicense1.Size = new Size(820, 504);
            ctrlSearchForLocalLicense1.TabIndex = 167;
            ctrlSearchForLocalLicense1.OnLicenseSelected += ctrlSearchForLocalLicense1_OnLicenseSelected;
            // 
            // foreverClose1
            // 
            foreverClose1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            foreverClose1.BackColor = Color.White;
            foreverClose1.BaseColor = Color.FromArgb(45, 47, 49);
            foreverClose1.DefaultLocation = true;
            foreverClose1.DownColor = Color.FromArgb(30, 0, 0, 0);
            foreverClose1.Font = new Font("Marlett", 10F);
            foreverClose1.Location = new Point(812, 16);
            foreverClose1.Name = "foreverClose1";
            foreverClose1.OverColor = Color.FromArgb(30, 255, 255, 255);
            foreverClose1.Size = new Size(18, 18);
            foreverClose1.TabIndex = 193;
            foreverClose1.Text = "foreverClose1";
            foreverClose1.TextColor = Color.FromArgb(243, 243, 243);
            // 
            // txtBFees
            // 
            txtBFees.AnimateReadOnly = false;
            txtBFees.AutoCompleteMode = AutoCompleteMode.None;
            txtBFees.AutoCompleteSource = AutoCompleteSource.None;
            txtBFees.BackgroundImageLayout = ImageLayout.None;
            txtBFees.CharacterCasing = CharacterCasing.Normal;
            txtBFees.Depth = 0;
            txtBFees.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtBFees.HideSelection = true;
            txtBFees.Hint = "Detain Fees";
            txtBFees.LeadingIcon = null;
            txtBFees.Location = new Point(27, 739);
            txtBFees.MaxLength = 32767;
            txtBFees.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtBFees.Name = "txtBFees";
            txtBFees.PasswordChar = '\0';
            txtBFees.PrefixSuffixText = null;
            txtBFees.ReadOnly = false;
            txtBFees.RightToLeft = RightToLeft.No;
            txtBFees.SelectedText = "";
            txtBFees.SelectionLength = 0;
            txtBFees.SelectionStart = 0;
            txtBFees.ShortcutsEnabled = true;
            txtBFees.Size = new Size(385, 48);
            txtBFees.TabIndex = 194;
            txtBFees.TabStop = false;
            txtBFees.TextAlign = HorizontalAlignment.Left;
            txtBFees.TrailingIcon = null;
            txtBFees.UseSystemPasswordChar = false;
            // 
            // DetainDrivingLicenseForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(842, 856);
            Controls.Add(txtBFees);
            Controls.Add(foreverClose1);
            Controls.Add(lblMainLabel);
            Controls.Add(btnDetain);
            Controls.Add(lnkLblShowLicensesHistory);
            Controls.Add(lnkLblShowNewLicense);
            Controls.Add(lblCretedByUsername);
            Controls.Add(lblCreatedBy);
            Controls.Add(lblLicenseID);
            Controls.Add(bigLabel15);
            Controls.Add(lblDetainDate);
            Controls.Add(bigLabel11);
            Controls.Add(lblDetainID);
            Controls.Add(bigLabel3);
            Controls.Add(bigLabel16);
            Controls.Add(ctrlSearchForLocalLicense1);
            Name = "DetainDrivingLicenseForm";
            Text = "DetainDrivingLicenseForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ReaLTaiizor.Controls.BigLabel lblMainLabel;
        private ReaLTaiizor.Controls.MaterialButton btnDetain;
        private ReaLTaiizor.Controls.MetroLinkLabel lnkLblShowLicensesHistory;
        private ReaLTaiizor.Controls.MetroLinkLabel lnkLblShowNewLicense;
        private ReaLTaiizor.Controls.BigLabel lblCretedByUsername;
        private ReaLTaiizor.Controls.BigLabel lblCreatedBy;
        private ReaLTaiizor.Controls.BigLabel lblLicenseID;
        private ReaLTaiizor.Controls.BigLabel bigLabel15;
        private ReaLTaiizor.Controls.BigLabel lblDetainDate;
        private ReaLTaiizor.Controls.BigLabel bigLabel11;
        private ReaLTaiizor.Controls.BigLabel lblDetainID;
        private ReaLTaiizor.Controls.BigLabel bigLabel3;
        private ReaLTaiizor.Controls.BigLabel bigLabel16;
        private CtrlSearchForLocalLicense ctrlSearchForLocalLicense1;
        private ReaLTaiizor.Controls.ForeverClose foreverClose1;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtBFees;
    }
}