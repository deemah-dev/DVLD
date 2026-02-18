namespace DVLD.UI
{
    partial class AddNewLocalDrivingLicenseApplicationForm
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
            bigLabel2 = new ReaLTaiizor.Controls.BigLabel();
            foreverClose1 = new ReaLTaiizor.Controls.ForeverClose();
            tabControl1 = new ReaLTaiizor.Controls.MaterialTabControl();
            tabPPersonInfo = new TabPage();
            ctrlFindPerson1 = new CtrlFindPerson();
            btnNext = new ReaLTaiizor.Controls.MaterialButton();
            bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            tabPAppInfo = new TabPage();
            cmboBLicenseCategories = new ReaLTaiizor.Controls.MaterialComboBox();
            lblCreatedByUsername = new ReaLTaiizor.Controls.BigLabel();
            lblApplicationFees = new ReaLTaiizor.Controls.BigLabel();
            lblApplicationDate = new ReaLTaiizor.Controls.BigLabel();
            lblLicenseApplicationID = new ReaLTaiizor.Controls.BigLabel();
            bigLabel9 = new ReaLTaiizor.Controls.BigLabel();
            bigLabel8 = new ReaLTaiizor.Controls.BigLabel();
            bigLabel7 = new ReaLTaiizor.Controls.BigLabel();
            bigLabel6 = new ReaLTaiizor.Controls.BigLabel();
            bigLabel4 = new ReaLTaiizor.Controls.BigLabel();
            bigLabel3 = new ReaLTaiizor.Controls.BigLabel();
            btnSave = new ReaLTaiizor.Controls.MaterialButton();
            tabControl1.SuspendLayout();
            tabPPersonInfo.SuspendLayout();
            tabPAppInfo.SuspendLayout();
            SuspendLayout();
            // 
            // bigLabel2
            // 
            bigLabel2.AutoSize = true;
            bigLabel2.BackColor = Color.Transparent;
            bigLabel2.Font = new Font("Arial Narrow", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bigLabel2.ForeColor = Color.Black;
            bigLabel2.Location = new Point(3, 9);
            bigLabel2.Name = "bigLabel2";
            bigLabel2.Size = new Size(569, 46);
            bigLabel2.TabIndex = 24;
            bigLabel2.Text = "New Local Driving License Application";
            // 
            // foreverClose1
            // 
            foreverClose1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            foreverClose1.BackColor = Color.White;
            foreverClose1.BaseColor = Color.FromArgb(45, 47, 49);
            foreverClose1.DefaultLocation = true;
            foreverClose1.DownColor = Color.FromArgb(30, 0, 0, 0);
            foreverClose1.Font = new Font("Marlett", 10F);
            foreverClose1.Location = new Point(792, 16);
            foreverClose1.Name = "foreverClose1";
            foreverClose1.OverColor = Color.FromArgb(30, 255, 255, 255);
            foreverClose1.Size = new Size(18, 18);
            foreverClose1.TabIndex = 23;
            foreverClose1.Text = "foreverClose1";
            foreverClose1.TextColor = Color.FromArgb(243, 243, 243);
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPPersonInfo);
            tabControl1.Controls.Add(tabPAppInfo);
            tabControl1.Depth = 0;
            tabControl1.HotTrack = true;
            tabControl1.ItemSize = new Size(164, 30);
            tabControl1.Location = new Point(3, 82);
            tabControl1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            tabControl1.Multiline = true;
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(816, 756);
            tabControl1.TabIndex = 25;
            // 
            // tabPPersonInfo
            // 
            tabPPersonInfo.Controls.Add(ctrlFindPerson1);
            tabPPersonInfo.Controls.Add(btnNext);
            tabPPersonInfo.Controls.Add(bigLabel1);
            tabPPersonInfo.Location = new Point(4, 34);
            tabPPersonInfo.Name = "tabPPersonInfo";
            tabPPersonInfo.Padding = new Padding(3);
            tabPPersonInfo.Size = new Size(808, 718);
            tabPPersonInfo.TabIndex = 0;
            tabPPersonInfo.Text = "Person Inforamtion";
            tabPPersonInfo.UseVisualStyleBackColor = true;
            // 
            // ctrlFindPerson1
            // 
            ctrlFindPerson1.Location = new Point(6, 64);
            ctrlFindPerson1.Name = "ctrlFindPerson1";
            ctrlFindPerson1.Size = new Size(791, 562);
            ctrlFindPerson1.TabIndex = 34;
            ctrlFindPerson1.OnPersonSelected += ctrlFindPerson1_OnPersonSelected;
            // 
            // btnNext
            // 
            btnNext.AutoSize = false;
            btnNext.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnNext.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnNext.Depth = 0;
            btnNext.HighEmphasis = true;
            btnNext.Icon = null;
            btnNext.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnNext.Location = new Point(687, 653);
            btnNext.Margin = new Padding(4, 6, 4, 6);
            btnNext.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnNext.Name = "btnNext";
            btnNext.NoAccentTextColor = Color.Empty;
            btnNext.Size = new Size(96, 53);
            btnNext.TabIndex = 33;
            btnNext.Text = "Next";
            btnNext.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnNext.UseAccentColor = false;
            btnNext.UseVisualStyleBackColor = true;
            btnNext.Click += btnNext_Click;
            // 
            // bigLabel1
            // 
            bigLabel1.AutoSize = true;
            bigLabel1.BackColor = Color.Transparent;
            bigLabel1.Font = new Font("Arial Narrow", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bigLabel1.ForeColor = Color.Black;
            bigLabel1.Location = new Point(9, 17);
            bigLabel1.Name = "bigLabel1";
            bigLabel1.Size = new Size(257, 40);
            bigLabel1.TabIndex = 21;
            bigLabel1.Text = "Person Information";
            // 
            // tabPAppInfo
            // 
            tabPAppInfo.Controls.Add(cmboBLicenseCategories);
            tabPAppInfo.Controls.Add(lblCreatedByUsername);
            tabPAppInfo.Controls.Add(lblApplicationFees);
            tabPAppInfo.Controls.Add(lblApplicationDate);
            tabPAppInfo.Controls.Add(lblLicenseApplicationID);
            tabPAppInfo.Controls.Add(bigLabel9);
            tabPAppInfo.Controls.Add(bigLabel8);
            tabPAppInfo.Controls.Add(bigLabel7);
            tabPAppInfo.Controls.Add(bigLabel6);
            tabPAppInfo.Controls.Add(bigLabel4);
            tabPAppInfo.Controls.Add(bigLabel3);
            tabPAppInfo.Controls.Add(btnSave);
            tabPAppInfo.Location = new Point(4, 34);
            tabPAppInfo.Name = "tabPAppInfo";
            tabPAppInfo.Padding = new Padding(3);
            tabPAppInfo.Size = new Size(808, 718);
            tabPAppInfo.TabIndex = 1;
            tabPAppInfo.Text = "Application Information";
            tabPAppInfo.UseVisualStyleBackColor = true;
            // 
            // cmboBLicenseCategories
            // 
            cmboBLicenseCategories.AutoResize = false;
            cmboBLicenseCategories.BackColor = Color.FromArgb(255, 255, 255);
            cmboBLicenseCategories.Depth = 0;
            cmboBLicenseCategories.DrawMode = DrawMode.OwnerDrawVariable;
            cmboBLicenseCategories.DropDownHeight = 174;
            cmboBLicenseCategories.DropDownStyle = ComboBoxStyle.DropDownList;
            cmboBLicenseCategories.DropDownWidth = 121;
            cmboBLicenseCategories.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cmboBLicenseCategories.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cmboBLicenseCategories.FormattingEnabled = true;
            cmboBLicenseCategories.IntegralHeight = false;
            cmboBLicenseCategories.ItemHeight = 43;
            cmboBLicenseCategories.Location = new Point(347, 318);
            cmboBLicenseCategories.MaxDropDownItems = 4;
            cmboBLicenseCategories.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cmboBLicenseCategories.Name = "cmboBLicenseCategories";
            cmboBLicenseCategories.Size = new Size(422, 49);
            cmboBLicenseCategories.StartIndex = 0;
            cmboBLicenseCategories.TabIndex = 52;
            cmboBLicenseCategories.SelectedIndexChanged += cmboBLicenseCategories_SelectedIndexChanged;
            // 
            // lblCreatedByUsername
            // 
            lblCreatedByUsername.AutoSize = true;
            lblCreatedByUsername.BackColor = Color.Transparent;
            lblCreatedByUsername.Font = new Font("Arial Narrow", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCreatedByUsername.ForeColor = Color.Black;
            lblCreatedByUsername.Location = new Point(347, 520);
            lblCreatedByUsername.Name = "lblCreatedByUsername";
            lblCreatedByUsername.Size = new Size(54, 33);
            lblCreatedByUsername.TabIndex = 51;
            lblCreatedByUsername.Text = "???";
            // 
            // lblApplicationFees
            // 
            lblApplicationFees.AutoSize = true;
            lblApplicationFees.BackColor = Color.Transparent;
            lblApplicationFees.Font = new Font("Arial Narrow", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblApplicationFees.ForeColor = Color.Black;
            lblApplicationFees.Location = new Point(347, 427);
            lblApplicationFees.Name = "lblApplicationFees";
            lblApplicationFees.Size = new Size(54, 33);
            lblApplicationFees.TabIndex = 49;
            lblApplicationFees.Text = "???";
            // 
            // lblApplicationDate
            // 
            lblApplicationDate.AutoSize = true;
            lblApplicationDate.BackColor = Color.Transparent;
            lblApplicationDate.Font = new Font("Arial Narrow", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblApplicationDate.ForeColor = Color.Black;
            lblApplicationDate.Location = new Point(347, 241);
            lblApplicationDate.Name = "lblApplicationDate";
            lblApplicationDate.Size = new Size(54, 33);
            lblApplicationDate.TabIndex = 48;
            lblApplicationDate.Text = "???";
            // 
            // lblLicenseApplicationID
            // 
            lblLicenseApplicationID.AutoSize = true;
            lblLicenseApplicationID.BackColor = Color.Transparent;
            lblLicenseApplicationID.Font = new Font("Arial Narrow", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLicenseApplicationID.ForeColor = Color.Black;
            lblLicenseApplicationID.Location = new Point(347, 148);
            lblLicenseApplicationID.Name = "lblLicenseApplicationID";
            lblLicenseApplicationID.Size = new Size(54, 33);
            lblLicenseApplicationID.TabIndex = 47;
            lblLicenseApplicationID.Text = "???";
            // 
            // bigLabel9
            // 
            bigLabel9.AutoSize = true;
            bigLabel9.BackColor = Color.Transparent;
            bigLabel9.Font = new Font("Arial Narrow", 16.2F, FontStyle.Bold);
            bigLabel9.ForeColor = Color.Black;
            bigLabel9.Location = new Point(35, 520);
            bigLabel9.Name = "bigLabel9";
            bigLabel9.Size = new Size(138, 33);
            bigLabel9.TabIndex = 46;
            bigLabel9.Text = "Created By";
            // 
            // bigLabel8
            // 
            bigLabel8.AutoSize = true;
            bigLabel8.BackColor = Color.Transparent;
            bigLabel8.Font = new Font("Arial Narrow", 16.2F, FontStyle.Bold);
            bigLabel8.ForeColor = Color.Black;
            bigLabel8.Location = new Point(35, 334);
            bigLabel8.Name = "bigLabel8";
            bigLabel8.Size = new Size(208, 33);
            bigLabel8.TabIndex = 45;
            bigLabel8.Text = "License Category";
            // 
            // bigLabel7
            // 
            bigLabel7.AutoSize = true;
            bigLabel7.BackColor = Color.Transparent;
            bigLabel7.Font = new Font("Arial Narrow", 16.2F, FontStyle.Bold);
            bigLabel7.ForeColor = Color.Black;
            bigLabel7.Location = new Point(35, 427);
            bigLabel7.Name = "bigLabel7";
            bigLabel7.Size = new Size(199, 33);
            bigLabel7.TabIndex = 44;
            bigLabel7.Text = "Application Fees";
            // 
            // bigLabel6
            // 
            bigLabel6.AutoSize = true;
            bigLabel6.BackColor = Color.Transparent;
            bigLabel6.Font = new Font("Arial Narrow", 16.2F, FontStyle.Bold);
            bigLabel6.ForeColor = Color.Black;
            bigLabel6.Location = new Point(35, 241);
            bigLabel6.Name = "bigLabel6";
            bigLabel6.Size = new Size(197, 33);
            bigLabel6.TabIndex = 43;
            bigLabel6.Text = "Application Date";
            // 
            // bigLabel4
            // 
            bigLabel4.AutoSize = true;
            bigLabel4.BackColor = Color.Transparent;
            bigLabel4.Font = new Font("Arial Narrow", 16.2F, FontStyle.Bold);
            bigLabel4.ForeColor = Color.Black;
            bigLabel4.Location = new Point(35, 148);
            bigLabel4.Name = "bigLabel4";
            bigLabel4.Size = new Size(261, 33);
            bigLabel4.TabIndex = 41;
            bigLabel4.Text = "License Application ID";
            // 
            // bigLabel3
            // 
            bigLabel3.AutoSize = true;
            bigLabel3.BackColor = Color.Transparent;
            bigLabel3.Font = new Font("Arial Narrow", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bigLabel3.ForeColor = Color.Black;
            bigLabel3.Location = new Point(9, 16);
            bigLabel3.Name = "bigLabel3";
            bigLabel3.Size = new Size(306, 40);
            bigLabel3.TabIndex = 40;
            bigLabel3.Text = "Application Information";
            // 
            // btnSave
            // 
            btnSave.AutoSize = false;
            btnSave.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSave.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSave.Depth = 0;
            btnSave.HighEmphasis = true;
            btnSave.Icon = null;
            btnSave.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnSave.Location = new Point(673, 638);
            btnSave.Margin = new Padding(4, 6, 4, 6);
            btnSave.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnSave.Name = "btnSave";
            btnSave.NoAccentTextColor = Color.Empty;
            btnSave.Size = new Size(96, 53);
            btnSave.TabIndex = 39;
            btnSave.Text = "Save";
            btnSave.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSave.UseAccentColor = false;
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // AddNewLocalDrivingLicenseApplicationForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(822, 850);
            Controls.Add(bigLabel2);
            Controls.Add(foreverClose1);
            Controls.Add(tabControl1);
            Name = "AddNewLocalDrivingLicenseApplicationForm";
            Text = "NewLocalDrivingLicenseForm";
            tabControl1.ResumeLayout(false);
            tabPPersonInfo.ResumeLayout(false);
            tabPPersonInfo.PerformLayout();
            tabPAppInfo.ResumeLayout(false);
            tabPAppInfo.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.BigLabel bigLabel2;
        private ReaLTaiizor.Controls.ForeverClose foreverClose1;
        private ReaLTaiizor.Controls.MaterialTabControl tabControl1;
        private TabPage tabPPersonInfo;
        private CtrlFindPerson ctrlFindPerson1;
        private ReaLTaiizor.Controls.MaterialButton btnNext;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private TabPage tabPAppInfo;
        private ReaLTaiizor.Controls.BigLabel bigLabel3;
        private ReaLTaiizor.Controls.MaterialButton btnSave;
        private ReaLTaiizor.Controls.BigLabel bigLabel4;
        private ReaLTaiizor.Controls.MaterialComboBox cmboBLicenseCategories;
        private ReaLTaiizor.Controls.BigLabel lblCreatedByUsername;
        private ReaLTaiizor.Controls.BigLabel lblApplicationFees;
        private ReaLTaiizor.Controls.BigLabel lblApplicationDate;
        private ReaLTaiizor.Controls.BigLabel lblLicenseApplicationID;
        private ReaLTaiizor.Controls.BigLabel bigLabel9;
        private ReaLTaiizor.Controls.BigLabel bigLabel8;
        private ReaLTaiizor.Controls.BigLabel bigLabel7;
        private ReaLTaiizor.Controls.BigLabel bigLabel6;
    }
}