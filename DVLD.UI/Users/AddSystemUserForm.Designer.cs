namespace DVLD.UI
{
    partial class AddSystemUserForm
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
            components = new System.ComponentModel.Container();
            bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            foreverClose1 = new ReaLTaiizor.Controls.ForeverClose();
            tabControl1 = new ReaLTaiizor.Controls.MaterialTabControl();
            tabPPersonInfo = new TabPage();
            ctrlFindPerson1 = new CtrlFindPerson();
            btnNext = new ReaLTaiizor.Controls.MaterialButton();
            tabPUserInfo = new TabPage();
            bigLabel3 = new ReaLTaiizor.Controls.BigLabel();
            btnSave = new ReaLTaiizor.Controls.MaterialButton();
            rbInactive = new ReaLTaiizor.Controls.MaterialRadioButton();
            rbActive = new ReaLTaiizor.Controls.MaterialRadioButton();
            lblUserActivetion = new ReaLTaiizor.Controls.BigLabel();
            txtBPassword = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtBConfirmPassword = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtBUsername = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            bigLabel2 = new ReaLTaiizor.Controls.BigLabel();
            errorProvider1 = new ErrorProvider(components);
            tabControl1.SuspendLayout();
            tabPPersonInfo.SuspendLayout();
            tabPUserInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // bigLabel1
            // 
            bigLabel1.AutoSize = true;
            bigLabel1.BackColor = Color.Transparent;
            bigLabel1.Font = new Font("Arial Narrow", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bigLabel1.ForeColor = Color.Black;
            bigLabel1.Location = new Point(6, 14);
            bigLabel1.Name = "bigLabel1";
            bigLabel1.Size = new Size(257, 40);
            bigLabel1.TabIndex = 21;
            bigLabel1.Text = "Person Information";
            // 
            // foreverClose1
            // 
            foreverClose1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            foreverClose1.BackColor = Color.White;
            foreverClose1.BaseColor = Color.FromArgb(45, 47, 49);
            foreverClose1.DefaultLocation = true;
            foreverClose1.DownColor = Color.FromArgb(30, 0, 0, 0);
            foreverClose1.Font = new Font("Marlett", 10F);
            foreverClose1.Location = new Point(793, 16);
            foreverClose1.Name = "foreverClose1";
            foreverClose1.OverColor = Color.FromArgb(30, 255, 255, 255);
            foreverClose1.Size = new Size(18, 18);
            foreverClose1.TabIndex = 20;
            foreverClose1.Text = "foreverClose1";
            foreverClose1.TextColor = Color.FromArgb(243, 243, 243);
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPPersonInfo);
            tabControl1.Controls.Add(tabPUserInfo);
            tabControl1.Depth = 0;
            tabControl1.HotTrack = true;
            tabControl1.ItemSize = new Size(164, 30);
            tabControl1.Location = new Point(3, 81);
            tabControl1.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            tabControl1.Multiline = true;
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(816, 756);
            tabControl1.TabIndex = 22;
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
            // tabPUserInfo
            // 
            tabPUserInfo.Controls.Add(bigLabel3);
            tabPUserInfo.Controls.Add(btnSave);
            tabPUserInfo.Controls.Add(rbInactive);
            tabPUserInfo.Controls.Add(rbActive);
            tabPUserInfo.Controls.Add(lblUserActivetion);
            tabPUserInfo.Controls.Add(txtBPassword);
            tabPUserInfo.Controls.Add(txtBConfirmPassword);
            tabPUserInfo.Controls.Add(txtBUsername);
            tabPUserInfo.Location = new Point(4, 34);
            tabPUserInfo.Name = "tabPUserInfo";
            tabPUserInfo.Padding = new Padding(3);
            tabPUserInfo.Size = new Size(808, 718);
            tabPUserInfo.TabIndex = 1;
            tabPUserInfo.Text = "User Information";
            tabPUserInfo.UseVisualStyleBackColor = true;
            // 
            // bigLabel3
            // 
            bigLabel3.AutoSize = true;
            bigLabel3.BackColor = Color.Transparent;
            bigLabel3.Font = new Font("Arial Narrow", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bigLabel3.ForeColor = Color.Black;
            bigLabel3.Location = new Point(6, 13);
            bigLabel3.Name = "bigLabel3";
            bigLabel3.Size = new Size(226, 40);
            bigLabel3.TabIndex = 40;
            bigLabel3.Text = "User Information";
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
            // rbInactive
            // 
            rbInactive.AutoSize = true;
            rbInactive.Depth = 0;
            rbInactive.Font = new Font("Arial Narrow", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbInactive.Location = new Point(482, 406);
            rbInactive.Margin = new Padding(0);
            rbInactive.MouseLocation = new Point(-1, -1);
            rbInactive.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            rbInactive.Name = "rbInactive";
            rbInactive.Ripple = true;
            rbInactive.Size = new Size(90, 37);
            rbInactive.TabIndex = 38;
            rbInactive.TabStop = true;
            rbInactive.Text = "Inactive";
            rbInactive.UseAccentColor = false;
            rbInactive.UseVisualStyleBackColor = true;
            // 
            // rbActive
            // 
            rbActive.AutoSize = true;
            rbActive.Checked = true;
            rbActive.Depth = 0;
            rbActive.Font = new Font("Arial Narrow", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbActive.Location = new Point(372, 406);
            rbActive.Margin = new Padding(0);
            rbActive.MouseLocation = new Point(-1, -1);
            rbActive.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            rbActive.Name = "rbActive";
            rbActive.Ripple = true;
            rbActive.Size = new Size(78, 37);
            rbActive.TabIndex = 37;
            rbActive.TabStop = true;
            rbActive.Text = "Active";
            rbActive.UseAccentColor = false;
            rbActive.UseVisualStyleBackColor = true;
            // 
            // lblUserActivetion
            // 
            lblUserActivetion.AutoSize = true;
            lblUserActivetion.BackColor = Color.Transparent;
            lblUserActivetion.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUserActivetion.ForeColor = Color.Black;
            lblUserActivetion.Location = new Point(218, 410);
            lblUserActivetion.Name = "lblUserActivetion";
            lblUserActivetion.Size = new Size(135, 27);
            lblUserActivetion.TabIndex = 36;
            lblUserActivetion.Text = "User Activetion";
            // 
            // txtBPassword
            // 
            txtBPassword.AnimateReadOnly = false;
            txtBPassword.AutoCompleteMode = AutoCompleteMode.None;
            txtBPassword.AutoCompleteSource = AutoCompleteSource.None;
            txtBPassword.BackgroundImageLayout = ImageLayout.None;
            txtBPassword.CharacterCasing = CharacterCasing.Normal;
            txtBPassword.Depth = 0;
            txtBPassword.ErrorMessage = "The password must contain at least 8 characters,\\nand include at least one uppercase letter,\\none lowercase letter, and one number.";
            txtBPassword.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtBPassword.HideSelection = true;
            txtBPassword.Hint = "Password";
            txtBPassword.LeadingIcon = null;
            txtBPassword.LeaveOnEnterKey = true;
            txtBPassword.Location = new Point(217, 238);
            txtBPassword.MaxLength = 32767;
            txtBPassword.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtBPassword.Name = "txtBPassword";
            txtBPassword.PasswordChar = '●';
            txtBPassword.PrefixSuffixText = null;
            txtBPassword.ReadOnly = false;
            txtBPassword.RightToLeft = RightToLeft.No;
            txtBPassword.SelectedText = "";
            txtBPassword.SelectionLength = 0;
            txtBPassword.SelectionStart = 0;
            txtBPassword.ShortcutsEnabled = true;
            txtBPassword.Size = new Size(312, 48);
            txtBPassword.TabIndex = 35;
            txtBPassword.TabStop = false;
            txtBPassword.TextAlign = HorizontalAlignment.Left;
            txtBPassword.TrailingIcon = null;
            txtBPassword.UseSystemPasswordChar = true;
            txtBPassword.Validating += txtBPassword_Validating;
            // 
            // txtBConfirmPassword
            // 
            txtBConfirmPassword.AnimateReadOnly = false;
            txtBConfirmPassword.AutoCompleteMode = AutoCompleteMode.None;
            txtBConfirmPassword.AutoCompleteSource = AutoCompleteSource.None;
            txtBConfirmPassword.BackgroundImageLayout = ImageLayout.None;
            txtBConfirmPassword.CharacterCasing = CharacterCasing.Normal;
            txtBConfirmPassword.Depth = 0;
            txtBConfirmPassword.ErrorMessage = "The confirmation password does not match the new password.";
            txtBConfirmPassword.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtBConfirmPassword.HideSelection = true;
            txtBConfirmPassword.Hint = "Confirm Password";
            txtBConfirmPassword.LeadingIcon = null;
            txtBConfirmPassword.LeaveOnEnterKey = true;
            txtBConfirmPassword.Location = new Point(218, 318);
            txtBConfirmPassword.MaxLength = 32767;
            txtBConfirmPassword.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtBConfirmPassword.Name = "txtBConfirmPassword";
            txtBConfirmPassword.PasswordChar = '●';
            txtBConfirmPassword.PrefixSuffixText = null;
            txtBConfirmPassword.ReadOnly = false;
            txtBConfirmPassword.RightToLeft = RightToLeft.No;
            txtBConfirmPassword.SelectedText = "";
            txtBConfirmPassword.SelectionLength = 0;
            txtBConfirmPassword.SelectionStart = 0;
            txtBConfirmPassword.ShortcutsEnabled = true;
            txtBConfirmPassword.Size = new Size(312, 48);
            txtBConfirmPassword.TabIndex = 34;
            txtBConfirmPassword.TabStop = false;
            txtBConfirmPassword.TextAlign = HorizontalAlignment.Left;
            txtBConfirmPassword.TrailingIcon = null;
            txtBConfirmPassword.UseSystemPasswordChar = true;
            txtBConfirmPassword.Validating += txtBConfirmPassword_Validating;
            // 
            // txtBUsername
            // 
            txtBUsername.AnimateReadOnly = false;
            txtBUsername.AutoCompleteMode = AutoCompleteMode.None;
            txtBUsername.AutoCompleteSource = AutoCompleteSource.None;
            txtBUsername.BackgroundImageLayout = ImageLayout.None;
            txtBUsername.CharacterCasing = CharacterCasing.Normal;
            txtBUsername.Depth = 0;
            txtBUsername.ErrorMessage = "This Username Already Exists In The System";
            txtBUsername.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtBUsername.HideSelection = true;
            txtBUsername.Hint = "Username";
            txtBUsername.LeadingIcon = null;
            txtBUsername.LeaveOnEnterKey = true;
            txtBUsername.Location = new Point(217, 158);
            txtBUsername.MaxLength = 32767;
            txtBUsername.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtBUsername.Name = "txtBUsername";
            txtBUsername.PasswordChar = '\0';
            txtBUsername.PrefixSuffixText = null;
            txtBUsername.ReadOnly = false;
            txtBUsername.RightToLeft = RightToLeft.No;
            txtBUsername.SelectedText = "";
            txtBUsername.SelectionLength = 0;
            txtBUsername.SelectionStart = 0;
            txtBUsername.ShortcutsEnabled = true;
            txtBUsername.Size = new Size(312, 48);
            txtBUsername.TabIndex = 33;
            txtBUsername.TabStop = false;
            txtBUsername.TextAlign = HorizontalAlignment.Left;
            txtBUsername.TrailingIcon = null;
            txtBUsername.UseSystemPasswordChar = false;
            txtBUsername.Validating += txtBUsername_Validating;
            // 
            // bigLabel2
            // 
            bigLabel2.AutoSize = true;
            bigLabel2.BackColor = Color.Transparent;
            bigLabel2.Font = new Font("Arial Narrow", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bigLabel2.ForeColor = Color.Black;
            bigLabel2.Location = new Point(4, 9);
            bigLabel2.Name = "bigLabel2";
            bigLabel2.Size = new Size(231, 46);
            bigLabel2.TabIndex = 22;
            bigLabel2.Text = "Add New User";
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // AddSystemUserForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(823, 843);
            Controls.Add(bigLabel2);
            Controls.Add(foreverClose1);
            Controls.Add(tabControl1);
            Name = "AddSystemUserForm";
            Text = "AddSystemUserForm";
            tabControl1.ResumeLayout(false);
            tabPPersonInfo.ResumeLayout(false);
            tabPPersonInfo.PerformLayout();
            tabPUserInfo.ResumeLayout(false);
            tabPUserInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private ReaLTaiizor.Controls.ForeverClose foreverClose1;
        private ReaLTaiizor.Controls.MaterialTabControl tabControl1;
        private TabPage tabPPersonInfo;
        private TabPage tabPUserInfo;
        private ReaLTaiizor.Controls.BigLabel bigLabel2;
        private ReaLTaiizor.Controls.MaterialButton btnNext;
        private CtrlFindPerson ctrlFindPerson1;
        private ReaLTaiizor.Controls.MaterialRadioButton rbInactive;
        private ReaLTaiizor.Controls.MaterialRadioButton rbActive;
        private ReaLTaiizor.Controls.BigLabel lblUserActivetion;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtBPassword;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtBConfirmPassword;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtBUsername;
        private ReaLTaiizor.Controls.BigLabel bigLabel3;
        private ReaLTaiizor.Controls.MaterialButton btnSave;
        private ErrorProvider errorProvider1;
    }
}