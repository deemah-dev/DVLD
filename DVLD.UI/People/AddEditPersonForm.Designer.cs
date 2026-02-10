namespace DVLD.UI
{
    partial class AddEditPersonForm
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
            foreverClose1 = new ReaLTaiizor.Controls.ForeverClose();
            txtBNationalNo = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtBFirstName = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtBSecondName = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtBThirdName = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtBLastName = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtBPhone = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtBEmail = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            bigLabel2 = new ReaLTaiizor.Controls.BigLabel();
            bigLabel3 = new ReaLTaiizor.Controls.BigLabel();
            cmboBNationalityNames = new ReaLTaiizor.Controls.MaterialComboBox();
            rbtnMale = new ReaLTaiizor.Controls.MaterialRadioButton();
            rbtnFemale = new ReaLTaiizor.Controls.MaterialRadioButton();
            txtBAddress = new ReaLTaiizor.Controls.MaterialMultiLineTextBoxEdit();
            btnSave = new ReaLTaiizor.Controls.MaterialButton();
            ctrlUploadImage1 = new CtrlUploadImage();
            DtpkrBirthDate = new ReaLTaiizor.Controls.PoisonDateTime();
            SuspendLayout();
            // 
            // lblMainLabel
            // 
            lblMainLabel.AutoSize = true;
            lblMainLabel.BackColor = Color.Transparent;
            lblMainLabel.Font = new Font("Arial Narrow", 25.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMainLabel.ForeColor = Color.Black;
            lblMainLabel.Location = new Point(12, 18);
            lblMainLabel.Name = "lblMainLabel";
            lblMainLabel.Size = new Size(280, 49);
            lblMainLabel.TabIndex = 16;
            lblMainLabel.Text = "Add New Person";
            // 
            // foreverClose1
            // 
            foreverClose1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            foreverClose1.BackColor = Color.White;
            foreverClose1.BaseColor = Color.FromArgb(45, 47, 49);
            foreverClose1.DefaultLocation = true;
            foreverClose1.DownColor = Color.FromArgb(30, 0, 0, 0);
            foreverClose1.Font = new Font("Marlett", 10F);
            foreverClose1.Location = new Point(770, 16);
            foreverClose1.Name = "foreverClose1";
            foreverClose1.OverColor = Color.FromArgb(30, 255, 255, 255);
            foreverClose1.Size = new Size(18, 18);
            foreverClose1.TabIndex = 15;
            foreverClose1.Text = "foreverClose1";
            foreverClose1.TextColor = Color.FromArgb(243, 243, 243);
            // 
            // txtBNationalNo
            // 
            txtBNationalNo.AnimateReadOnly = false;
            txtBNationalNo.AutoCompleteMode = AutoCompleteMode.None;
            txtBNationalNo.AutoCompleteSource = AutoCompleteSource.None;
            txtBNationalNo.BackgroundImageLayout = ImageLayout.None;
            txtBNationalNo.CharacterCasing = CharacterCasing.Normal;
            txtBNationalNo.Cursor = Cursors.IBeam;
            txtBNationalNo.Depth = 0;
            txtBNationalNo.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtBNationalNo.HideSelection = true;
            txtBNationalNo.Hint = "National No";
            txtBNationalNo.LeadingIcon = null;
            txtBNationalNo.LeaveOnEnterKey = true;
            txtBNationalNo.Location = new Point(12, 92);
            txtBNationalNo.MaxLength = 32767;
            txtBNationalNo.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtBNationalNo.Name = "txtBNationalNo";
            txtBNationalNo.PasswordChar = '\0';
            txtBNationalNo.PrefixSuffixText = null;
            txtBNationalNo.ReadOnly = false;
            txtBNationalNo.RightToLeft = RightToLeft.No;
            txtBNationalNo.SelectedText = "";
            txtBNationalNo.SelectionLength = 0;
            txtBNationalNo.SelectionStart = 0;
            txtBNationalNo.ShortcutsEnabled = true;
            txtBNationalNo.Size = new Size(370, 48);
            txtBNationalNo.TabIndex = 17;
            txtBNationalNo.TabStop = false;
            txtBNationalNo.TextAlign = HorizontalAlignment.Left;
            txtBNationalNo.TrailingIcon = null;
            txtBNationalNo.UseSystemPasswordChar = false;
            txtBNationalNo.Validating += TextBox_EmptyValidating;
            // 
            // txtBFirstName
            // 
            txtBFirstName.AnimateReadOnly = false;
            txtBFirstName.AutoCompleteMode = AutoCompleteMode.None;
            txtBFirstName.AutoCompleteSource = AutoCompleteSource.None;
            txtBFirstName.BackgroundImageLayout = ImageLayout.None;
            txtBFirstName.CharacterCasing = CharacterCasing.Normal;
            txtBFirstName.Cursor = Cursors.IBeam;
            txtBFirstName.Depth = 0;
            txtBFirstName.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtBFirstName.HideSelection = true;
            txtBFirstName.Hint = "First Name";
            txtBFirstName.LeadingIcon = null;
            txtBFirstName.LeaveOnEnterKey = true;
            txtBFirstName.Location = new Point(12, 169);
            txtBFirstName.MaxLength = 32767;
            txtBFirstName.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtBFirstName.Name = "txtBFirstName";
            txtBFirstName.PasswordChar = '\0';
            txtBFirstName.PrefixSuffixText = null;
            txtBFirstName.ReadOnly = false;
            txtBFirstName.RightToLeft = RightToLeft.No;
            txtBFirstName.SelectedText = "";
            txtBFirstName.SelectionLength = 0;
            txtBFirstName.SelectionStart = 0;
            txtBFirstName.ShortcutsEnabled = true;
            txtBFirstName.Size = new Size(168, 48);
            txtBFirstName.TabIndex = 18;
            txtBFirstName.TabStop = false;
            txtBFirstName.TextAlign = HorizontalAlignment.Left;
            txtBFirstName.TrailingIcon = null;
            txtBFirstName.UseSystemPasswordChar = false;
            txtBFirstName.Validating += TextBox_CharsValidating;
            // 
            // txtBSecondName
            // 
            txtBSecondName.AnimateReadOnly = false;
            txtBSecondName.AutoCompleteMode = AutoCompleteMode.None;
            txtBSecondName.AutoCompleteSource = AutoCompleteSource.None;
            txtBSecondName.BackgroundImageLayout = ImageLayout.None;
            txtBSecondName.CharacterCasing = CharacterCasing.Normal;
            txtBSecondName.Cursor = Cursors.IBeam;
            txtBSecondName.Depth = 0;
            txtBSecondName.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtBSecondName.HideSelection = true;
            txtBSecondName.Hint = "Second Name";
            txtBSecondName.LeadingIcon = null;
            txtBSecondName.LeaveOnEnterKey = true;
            txtBSecondName.Location = new Point(214, 169);
            txtBSecondName.MaxLength = 32767;
            txtBSecondName.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtBSecondName.Name = "txtBSecondName";
            txtBSecondName.PasswordChar = '\0';
            txtBSecondName.PrefixSuffixText = null;
            txtBSecondName.ReadOnly = false;
            txtBSecondName.RightToLeft = RightToLeft.No;
            txtBSecondName.SelectedText = "";
            txtBSecondName.SelectionLength = 0;
            txtBSecondName.SelectionStart = 0;
            txtBSecondName.ShortcutsEnabled = true;
            txtBSecondName.Size = new Size(168, 48);
            txtBSecondName.TabIndex = 19;
            txtBSecondName.TabStop = false;
            txtBSecondName.TextAlign = HorizontalAlignment.Left;
            txtBSecondName.TrailingIcon = null;
            txtBSecondName.UseSystemPasswordChar = false;
            txtBSecondName.Validating += TextBox_CharsValidating;
            // 
            // txtBThirdName
            // 
            txtBThirdName.AnimateReadOnly = false;
            txtBThirdName.AutoCompleteMode = AutoCompleteMode.None;
            txtBThirdName.AutoCompleteSource = AutoCompleteSource.None;
            txtBThirdName.BackgroundImageLayout = ImageLayout.None;
            txtBThirdName.CharacterCasing = CharacterCasing.Normal;
            txtBThirdName.Cursor = Cursors.IBeam;
            txtBThirdName.Depth = 0;
            txtBThirdName.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtBThirdName.HideSelection = true;
            txtBThirdName.Hint = "Third Name";
            txtBThirdName.LeadingIcon = null;
            txtBThirdName.LeaveOnEnterKey = true;
            txtBThirdName.Location = new Point(12, 237);
            txtBThirdName.MaxLength = 32767;
            txtBThirdName.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtBThirdName.Name = "txtBThirdName";
            txtBThirdName.PasswordChar = '\0';
            txtBThirdName.PrefixSuffixText = null;
            txtBThirdName.ReadOnly = false;
            txtBThirdName.RightToLeft = RightToLeft.No;
            txtBThirdName.SelectedText = "";
            txtBThirdName.SelectionLength = 0;
            txtBThirdName.SelectionStart = 0;
            txtBThirdName.ShortcutsEnabled = true;
            txtBThirdName.Size = new Size(168, 48);
            txtBThirdName.TabIndex = 20;
            txtBThirdName.TabStop = false;
            txtBThirdName.TextAlign = HorizontalAlignment.Left;
            txtBThirdName.TrailingIcon = null;
            txtBThirdName.UseSystemPasswordChar = false;
            txtBThirdName.Validating += TextBox_CharsValidating;
            // 
            // txtBLastName
            // 
            txtBLastName.AnimateReadOnly = false;
            txtBLastName.AutoCompleteMode = AutoCompleteMode.None;
            txtBLastName.AutoCompleteSource = AutoCompleteSource.None;
            txtBLastName.BackgroundImageLayout = ImageLayout.None;
            txtBLastName.CharacterCasing = CharacterCasing.Normal;
            txtBLastName.Cursor = Cursors.IBeam;
            txtBLastName.Depth = 0;
            txtBLastName.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtBLastName.HideSelection = true;
            txtBLastName.Hint = "Last Name";
            txtBLastName.LeadingIcon = null;
            txtBLastName.LeaveOnEnterKey = true;
            txtBLastName.Location = new Point(214, 237);
            txtBLastName.MaxLength = 32767;
            txtBLastName.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtBLastName.Name = "txtBLastName";
            txtBLastName.PasswordChar = '\0';
            txtBLastName.PrefixSuffixText = null;
            txtBLastName.ReadOnly = false;
            txtBLastName.RightToLeft = RightToLeft.No;
            txtBLastName.SelectedText = "";
            txtBLastName.SelectionLength = 0;
            txtBLastName.SelectionStart = 0;
            txtBLastName.ShortcutsEnabled = true;
            txtBLastName.Size = new Size(168, 48);
            txtBLastName.TabIndex = 21;
            txtBLastName.TabStop = false;
            txtBLastName.TextAlign = HorizontalAlignment.Left;
            txtBLastName.TrailingIcon = null;
            txtBLastName.UseSystemPasswordChar = false;
            txtBLastName.Validating += TextBox_CharsValidating;
            // 
            // txtBPhone
            // 
            txtBPhone.AnimateReadOnly = false;
            txtBPhone.AutoCompleteMode = AutoCompleteMode.None;
            txtBPhone.AutoCompleteSource = AutoCompleteSource.None;
            txtBPhone.BackgroundImageLayout = ImageLayout.None;
            txtBPhone.CharacterCasing = CharacterCasing.Normal;
            txtBPhone.Cursor = Cursors.IBeam;
            txtBPhone.Depth = 0;
            txtBPhone.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtBPhone.HideSelection = true;
            txtBPhone.Hint = "Phone";
            txtBPhone.LeadingIcon = null;
            txtBPhone.LeaveOnEnterKey = true;
            txtBPhone.Location = new Point(416, 366);
            txtBPhone.MaxLength = 32767;
            txtBPhone.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtBPhone.Name = "txtBPhone";
            txtBPhone.PasswordChar = '\0';
            txtBPhone.PrefixSuffixText = null;
            txtBPhone.ReadOnly = false;
            txtBPhone.RightToLeft = RightToLeft.No;
            txtBPhone.SelectedText = "";
            txtBPhone.SelectionLength = 0;
            txtBPhone.SelectionStart = 0;
            txtBPhone.ShortcutsEnabled = true;
            txtBPhone.Size = new Size(370, 48);
            txtBPhone.TabIndex = 22;
            txtBPhone.TabStop = false;
            txtBPhone.TextAlign = HorizontalAlignment.Left;
            txtBPhone.TrailingIcon = null;
            txtBPhone.UseSystemPasswordChar = false;
            txtBPhone.Validating += TextBox_NumberValidating;
            // 
            // txtBEmail
            // 
            txtBEmail.AnimateReadOnly = false;
            txtBEmail.AutoCompleteMode = AutoCompleteMode.None;
            txtBEmail.AutoCompleteSource = AutoCompleteSource.None;
            txtBEmail.BackgroundImageLayout = ImageLayout.None;
            txtBEmail.CharacterCasing = CharacterCasing.Normal;
            txtBEmail.Cursor = Cursors.IBeam;
            txtBEmail.Depth = 0;
            txtBEmail.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtBEmail.HideSelection = true;
            txtBEmail.Hint = "Email";
            txtBEmail.LeadingIcon = null;
            txtBEmail.LeaveOnEnterKey = true;
            txtBEmail.Location = new Point(12, 366);
            txtBEmail.MaxLength = 32767;
            txtBEmail.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtBEmail.Name = "txtBEmail";
            txtBEmail.PasswordChar = '\0';
            txtBEmail.PrefixSuffixText = null;
            txtBEmail.ReadOnly = false;
            txtBEmail.RightToLeft = RightToLeft.No;
            txtBEmail.SelectedText = "";
            txtBEmail.SelectionLength = 0;
            txtBEmail.SelectionStart = 0;
            txtBEmail.ShortcutsEnabled = true;
            txtBEmail.Size = new Size(370, 48);
            txtBEmail.TabIndex = 23;
            txtBEmail.TabStop = false;
            txtBEmail.TextAlign = HorizontalAlignment.Left;
            txtBEmail.TrailingIcon = null;
            txtBEmail.UseSystemPasswordChar = false;
            txtBEmail.Validating += TextBox_EmailValidating;
            // 
            // bigLabel2
            // 
            bigLabel2.AutoSize = true;
            bigLabel2.BackColor = Color.Transparent;
            bigLabel2.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bigLabel2.ForeColor = Color.Black;
            bigLabel2.Location = new Point(416, 309);
            bigLabel2.Name = "bigLabel2";
            bigLabel2.Size = new Size(64, 24);
            bigLabel2.TabIndex = 24;
            bigLabel2.Text = "Gender";
            // 
            // bigLabel3
            // 
            bigLabel3.AutoSize = true;
            bigLabel3.BackColor = Color.Transparent;
            bigLabel3.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bigLabel3.ForeColor = Color.Black;
            bigLabel3.Location = new Point(12, 313);
            bigLabel3.Name = "bigLabel3";
            bigLabel3.Size = new Size(83, 24);
            bigLabel3.TabIndex = 25;
            bigLabel3.Text = "Birth Date";
            // 
            // cmboBNationalityNames
            // 
            cmboBNationalityNames.AutoResize = false;
            cmboBNationalityNames.BackColor = Color.FromArgb(255, 255, 255);
            cmboBNationalityNames.Depth = 0;
            cmboBNationalityNames.DrawMode = DrawMode.OwnerDrawVariable;
            cmboBNationalityNames.DropDownHeight = 174;
            cmboBNationalityNames.DropDownStyle = ComboBoxStyle.DropDownList;
            cmboBNationalityNames.DropDownWidth = 121;
            cmboBNationalityNames.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cmboBNationalityNames.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cmboBNationalityNames.FormattingEnabled = true;
            cmboBNationalityNames.Hint = "Nationality";
            cmboBNationalityNames.IntegralHeight = false;
            cmboBNationalityNames.ItemHeight = 43;
            cmboBNationalityNames.Location = new Point(12, 437);
            cmboBNationalityNames.MaxDropDownItems = 4;
            cmboBNationalityNames.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cmboBNationalityNames.Name = "cmboBNationalityNames";
            cmboBNationalityNames.Size = new Size(776, 49);
            cmboBNationalityNames.StartIndex = 0;
            cmboBNationalityNames.TabIndex = 26;
            // 
            // rbtnMale
            // 
            rbtnMale.AutoSize = true;
            rbtnMale.Checked = true;
            rbtnMale.Depth = 0;
            rbtnMale.Location = new Point(501, 304);
            rbtnMale.Margin = new Padding(0);
            rbtnMale.MouseLocation = new Point(-1, -1);
            rbtnMale.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            rbtnMale.Name = "rbtnMale";
            rbtnMale.Ripple = true;
            rbtnMale.Size = new Size(70, 37);
            rbtnMale.TabIndex = 29;
            rbtnMale.TabStop = true;
            rbtnMale.Text = "Male";
            rbtnMale.UseAccentColor = false;
            rbtnMale.UseVisualStyleBackColor = true;
            // 
            // rbtnFemale
            // 
            rbtnFemale.AutoSize = true;
            rbtnFemale.Depth = 0;
            rbtnFemale.Location = new Point(595, 304);
            rbtnFemale.Margin = new Padding(0);
            rbtnFemale.MouseLocation = new Point(-1, -1);
            rbtnFemale.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            rbtnFemale.Name = "rbtnFemale";
            rbtnFemale.Ripple = true;
            rbtnFemale.Size = new Size(87, 37);
            rbtnFemale.TabIndex = 30;
            rbtnFemale.TabStop = true;
            rbtnFemale.Text = "Female";
            rbtnFemale.UseAccentColor = false;
            rbtnFemale.UseVisualStyleBackColor = true;
            // 
            // txtBAddress
            // 
            txtBAddress.AnimateReadOnly = false;
            txtBAddress.BackgroundImageLayout = ImageLayout.None;
            txtBAddress.CharacterCasing = CharacterCasing.Normal;
            txtBAddress.Depth = 0;
            txtBAddress.HideSelection = true;
            txtBAddress.Hint = "Address";
            txtBAddress.LeaveOnEnterKey = true;
            txtBAddress.Location = new Point(12, 506);
            txtBAddress.MaxLength = 32767;
            txtBAddress.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtBAddress.Name = "txtBAddress";
            txtBAddress.PasswordChar = '\0';
            txtBAddress.ReadOnly = false;
            txtBAddress.ScrollBars = ScrollBars.None;
            txtBAddress.SelectedText = "";
            txtBAddress.SelectionLength = 0;
            txtBAddress.SelectionStart = 0;
            txtBAddress.ShortcutsEnabled = true;
            txtBAddress.Size = new Size(774, 90);
            txtBAddress.TabIndex = 31;
            txtBAddress.TabStop = false;
            txtBAddress.TextAlign = HorizontalAlignment.Left;
            txtBAddress.UseSystemPasswordChar = false;
            txtBAddress.Validating += TextBox_EmptyValidating;
            // 
            // btnSave
            // 
            btnSave.AutoSize = false;
            btnSave.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnSave.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnSave.Depth = 0;
            btnSave.HighEmphasis = true;
            btnSave.Icon = Properties.Resources.AddPersonIcon;
            btnSave.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnSave.Location = new Point(690, 608);
            btnSave.Margin = new Padding(4, 6, 4, 6);
            btnSave.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnSave.Name = "btnSave";
            btnSave.NoAccentTextColor = Color.Empty;
            btnSave.Size = new Size(96, 53);
            btnSave.TabIndex = 32;
            btnSave.Text = "Save";
            btnSave.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSave.UseAccentColor = false;
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // ctrlUploadImage1
            // 
            ctrlUploadImage1.Location = new Point(482, 81);
            ctrlUploadImage1.Name = "ctrlUploadImage1";
            ctrlUploadImage1.Size = new Size(208, 190);
            ctrlUploadImage1.TabIndex = 33;
            // 
            // DtpkrBirthDate
            // 
            DtpkrBirthDate.FontSize = ReaLTaiizor.Extension.Poison.PoisonDateTimeSize.Medium;
            DtpkrBirthDate.Location = new Point(117, 309);
            DtpkrBirthDate.MinimumSize = new Size(0, 30);
            DtpkrBirthDate.Name = "DtpkrBirthDate";
            DtpkrBirthDate.Size = new Size(265, 30);
            DtpkrBirthDate.TabIndex = 35;
            // 
            // AddEditPersonForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 677);
            Controls.Add(DtpkrBirthDate);
            Controls.Add(ctrlUploadImage1);
            Controls.Add(btnSave);
            Controls.Add(txtBAddress);
            Controls.Add(rbtnFemale);
            Controls.Add(rbtnMale);
            Controls.Add(cmboBNationalityNames);
            Controls.Add(bigLabel3);
            Controls.Add(bigLabel2);
            Controls.Add(txtBEmail);
            Controls.Add(txtBPhone);
            Controls.Add(txtBLastName);
            Controls.Add(txtBThirdName);
            Controls.Add(txtBSecondName);
            Controls.Add(txtBFirstName);
            Controls.Add(txtBNationalNo);
            Controls.Add(lblMainLabel);
            Controls.Add(foreverClose1);
            Name = "AddEditPersonForm";
            Text = "AddNewPersonForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.BigLabel lblMainLabel;
        private ReaLTaiizor.Controls.ForeverClose foreverClose1;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtBNationalNo;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtBFirstName;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtBSecondName;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtBThirdName;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtBLastName;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtBPhone;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtBEmail;
        private ReaLTaiizor.Controls.BigLabel bigLabel2;
        private ReaLTaiizor.Controls.BigLabel bigLabel3;
        private ReaLTaiizor.Controls.MaterialComboBox cmboBNationalityNames;
        private ReaLTaiizor.Controls.MaterialRadioButton rbtnMale;
        private ReaLTaiizor.Controls.MaterialRadioButton rbtnFemale;
        private ReaLTaiizor.Controls.MaterialMultiLineTextBoxEdit txtBAddress;
        private ReaLTaiizor.Controls.MaterialButton btnSave;
        private CtrlUploadImage ctrlUploadImage1;
        private ReaLTaiizor.Controls.PoisonDateTime DtpkrBirthDate;
    }
}