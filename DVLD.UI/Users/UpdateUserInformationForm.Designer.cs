namespace DVLD.UI
{
    partial class UpdateUserInformationForm
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
            lblMainLabel = new ReaLTaiizor.Controls.BigLabel();
            foreverClose1 = new ReaLTaiizor.Controls.ForeverClose();
            lblChangePassword = new ReaLTaiizor.Controls.BigLabel();
            lblChangeActivetion = new ReaLTaiizor.Controls.BigLabel();
            txtBCurrentPassword = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtBConfirmNewPassword = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtBNewPassword = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            lblUserActivetion = new ReaLTaiizor.Controls.BigLabel();
            rbActive = new ReaLTaiizor.Controls.MaterialRadioButton();
            rbInactive = new ReaLTaiizor.Controls.MaterialRadioButton();
            btnSave = new ReaLTaiizor.Controls.MaterialButton();
            errorProvider1 = new ErrorProvider(components);
            ((System.ComponentModel.ISupportInitialize)errorProvider1).BeginInit();
            SuspendLayout();
            // 
            // lblMainLabel
            // 
            lblMainLabel.AutoSize = true;
            lblMainLabel.BackColor = Color.Transparent;
            lblMainLabel.Font = new Font("Arial Narrow", 25.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMainLabel.ForeColor = Color.Black;
            lblMainLabel.Location = new Point(12, 16);
            lblMainLabel.Name = "lblMainLabel";
            lblMainLabel.Size = new Size(398, 49);
            lblMainLabel.TabIndex = 22;
            lblMainLabel.Text = "Update User Information";
            // 
            // foreverClose1
            // 
            foreverClose1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            foreverClose1.BackColor = Color.White;
            foreverClose1.BaseColor = Color.FromArgb(45, 47, 49);
            foreverClose1.DefaultLocation = true;
            foreverClose1.DownColor = Color.FromArgb(30, 0, 0, 0);
            foreverClose1.Font = new Font("Marlett", 10F);
            foreverClose1.Location = new Point(481, 16);
            foreverClose1.Name = "foreverClose1";
            foreverClose1.OverColor = Color.FromArgb(30, 255, 255, 255);
            foreverClose1.Size = new Size(18, 18);
            foreverClose1.TabIndex = 21;
            foreverClose1.Text = "foreverClose1";
            foreverClose1.TextColor = Color.FromArgb(243, 243, 243);
            // 
            // lblChangePassword
            // 
            lblChangePassword.AutoSize = true;
            lblChangePassword.BackColor = Color.Transparent;
            lblChangePassword.Font = new Font("Arial Narrow", 16.2F);
            lblChangePassword.ForeColor = Color.Black;
            lblChangePassword.Location = new Point(12, 116);
            lblChangePassword.Name = "lblChangePassword";
            lblChangePassword.Size = new Size(201, 33);
            lblChangePassword.TabIndex = 23;
            lblChangePassword.Text = "Change Password";
            // 
            // lblChangeActivetion
            // 
            lblChangeActivetion.AutoSize = true;
            lblChangeActivetion.BackColor = Color.Transparent;
            lblChangeActivetion.Font = new Font("Arial Narrow", 16.2F);
            lblChangeActivetion.ForeColor = Color.Black;
            lblChangeActivetion.Location = new Point(12, 428);
            lblChangeActivetion.Name = "lblChangeActivetion";
            lblChangeActivetion.Size = new Size(197, 33);
            lblChangeActivetion.TabIndex = 24;
            lblChangeActivetion.Text = "Change Activetion";
            // 
            // txtBCurrentPassword
            // 
            txtBCurrentPassword.AnimateReadOnly = false;
            txtBCurrentPassword.AutoCompleteMode = AutoCompleteMode.None;
            txtBCurrentPassword.AutoCompleteSource = AutoCompleteSource.None;
            txtBCurrentPassword.BackgroundImageLayout = ImageLayout.None;
            txtBCurrentPassword.CharacterCasing = CharacterCasing.Normal;
            txtBCurrentPassword.Depth = 0;
            txtBCurrentPassword.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtBCurrentPassword.HideSelection = true;
            txtBCurrentPassword.Hint = "Current Password";
            txtBCurrentPassword.LeadingIcon = null;
            txtBCurrentPassword.LeaveOnEnterKey = true;
            txtBCurrentPassword.Location = new Point(98, 172);
            txtBCurrentPassword.MaxLength = 32767;
            txtBCurrentPassword.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtBCurrentPassword.Name = "txtBCurrentPassword";
            txtBCurrentPassword.PasswordChar = '●';
            txtBCurrentPassword.PrefixSuffixText = null;
            txtBCurrentPassword.ReadOnly = false;
            txtBCurrentPassword.RightToLeft = RightToLeft.No;
            txtBCurrentPassword.SelectedText = "";
            txtBCurrentPassword.SelectionLength = 0;
            txtBCurrentPassword.SelectionStart = 0;
            txtBCurrentPassword.ShortcutsEnabled = true;
            txtBCurrentPassword.Size = new Size(312, 48);
            txtBCurrentPassword.TabIndex = 25;
            txtBCurrentPassword.TabStop = false;
            txtBCurrentPassword.TextAlign = HorizontalAlignment.Left;
            txtBCurrentPassword.TrailingIcon = null;
            txtBCurrentPassword.UseSystemPasswordChar = true;
            txtBCurrentPassword.Validating += txtBCurrentPassword_Validating;
            // 
            // txtBConfirmNewPassword
            // 
            txtBConfirmNewPassword.AnimateReadOnly = false;
            txtBConfirmNewPassword.AutoCompleteMode = AutoCompleteMode.None;
            txtBConfirmNewPassword.AutoCompleteSource = AutoCompleteSource.None;
            txtBConfirmNewPassword.BackgroundImageLayout = ImageLayout.None;
            txtBConfirmNewPassword.CharacterCasing = CharacterCasing.Normal;
            txtBConfirmNewPassword.Depth = 0;
            txtBConfirmNewPassword.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtBConfirmNewPassword.HideSelection = true;
            txtBConfirmNewPassword.Hint = "Confirm New Password";
            txtBConfirmNewPassword.LeadingIcon = null;
            txtBConfirmNewPassword.LeaveOnEnterKey = true;
            txtBConfirmNewPassword.Location = new Point(99, 332);
            txtBConfirmNewPassword.MaxLength = 32767;
            txtBConfirmNewPassword.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtBConfirmNewPassword.Name = "txtBConfirmNewPassword";
            txtBConfirmNewPassword.PasswordChar = '●';
            txtBConfirmNewPassword.PrefixSuffixText = null;
            txtBConfirmNewPassword.ReadOnly = false;
            txtBConfirmNewPassword.RightToLeft = RightToLeft.No;
            txtBConfirmNewPassword.SelectedText = "";
            txtBConfirmNewPassword.SelectionLength = 0;
            txtBConfirmNewPassword.SelectionStart = 0;
            txtBConfirmNewPassword.ShortcutsEnabled = true;
            txtBConfirmNewPassword.Size = new Size(312, 48);
            txtBConfirmNewPassword.TabIndex = 27;
            txtBConfirmNewPassword.TabStop = false;
            txtBConfirmNewPassword.TextAlign = HorizontalAlignment.Left;
            txtBConfirmNewPassword.TrailingIcon = null;
            txtBConfirmNewPassword.UseSystemPasswordChar = true;
            txtBConfirmNewPassword.Validating += txtBConfirmNewPassword_Validating;
            // 
            // txtBNewPassword
            // 
            txtBNewPassword.AnimateReadOnly = false;
            txtBNewPassword.AutoCompleteMode = AutoCompleteMode.None;
            txtBNewPassword.AutoCompleteSource = AutoCompleteSource.None;
            txtBNewPassword.BackgroundImageLayout = ImageLayout.None;
            txtBNewPassword.CharacterCasing = CharacterCasing.Normal;
            txtBNewPassword.Depth = 0;
            txtBNewPassword.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtBNewPassword.HideSelection = true;
            txtBNewPassword.Hint = "New Password";
            txtBNewPassword.LeadingIcon = null;
            txtBNewPassword.LeaveOnEnterKey = true;
            txtBNewPassword.Location = new Point(98, 252);
            txtBNewPassword.MaxLength = 32767;
            txtBNewPassword.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtBNewPassword.Name = "txtBNewPassword";
            txtBNewPassword.PasswordChar = '●';
            txtBNewPassword.PrefixSuffixText = null;
            txtBNewPassword.ReadOnly = false;
            txtBNewPassword.RightToLeft = RightToLeft.No;
            txtBNewPassword.SelectedText = "";
            txtBNewPassword.SelectionLength = 0;
            txtBNewPassword.SelectionStart = 0;
            txtBNewPassword.ShortcutsEnabled = true;
            txtBNewPassword.Size = new Size(312, 48);
            txtBNewPassword.TabIndex = 26;
            txtBNewPassword.TabStop = false;
            txtBNewPassword.TextAlign = HorizontalAlignment.Left;
            txtBNewPassword.TrailingIcon = null;
            txtBNewPassword.UseSystemPasswordChar = true;
            txtBNewPassword.Validating += txtBNewPassword_Validating;
            // 
            // lblUserActivetion
            // 
            lblUserActivetion.AutoSize = true;
            lblUserActivetion.BackColor = Color.Transparent;
            lblUserActivetion.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblUserActivetion.ForeColor = Color.Black;
            lblUserActivetion.Location = new Point(52, 488);
            lblUserActivetion.Name = "lblUserActivetion";
            lblUserActivetion.Size = new Size(135, 27);
            lblUserActivetion.TabIndex = 28;
            lblUserActivetion.Text = "User Activetion";
            // 
            // rbActive
            // 
            rbActive.AutoSize = true;
            rbActive.Depth = 0;
            rbActive.Font = new Font("Arial Narrow", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbActive.Location = new Point(206, 484);
            rbActive.Margin = new Padding(0);
            rbActive.MouseLocation = new Point(-1, -1);
            rbActive.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            rbActive.Name = "rbActive";
            rbActive.Ripple = true;
            rbActive.Size = new Size(78, 37);
            rbActive.TabIndex = 29;
            rbActive.TabStop = true;
            rbActive.Text = "Active";
            rbActive.UseAccentColor = false;
            rbActive.UseVisualStyleBackColor = true;
            // 
            // rbInactive
            // 
            rbInactive.AutoSize = true;
            rbInactive.Depth = 0;
            rbInactive.Font = new Font("Arial Narrow", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            rbInactive.Location = new Point(316, 484);
            rbInactive.Margin = new Padding(0);
            rbInactive.MouseLocation = new Point(-1, -1);
            rbInactive.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            rbInactive.Name = "rbInactive";
            rbInactive.Ripple = true;
            rbInactive.Size = new Size(90, 37);
            rbInactive.TabIndex = 30;
            rbInactive.TabStop = true;
            rbInactive.Text = "Inactive";
            rbInactive.UseAccentColor = false;
            rbInactive.UseVisualStyleBackColor = true;
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
            btnSave.Location = new Point(392, 546);
            btnSave.Margin = new Padding(4, 6, 4, 6);
            btnSave.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnSave.Name = "btnSave";
            btnSave.NoAccentTextColor = Color.Empty;
            btnSave.Size = new Size(96, 53);
            btnSave.TabIndex = 33;
            btnSave.Text = "Save";
            btnSave.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnSave.UseAccentColor = false;
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // errorProvider1
            // 
            errorProvider1.ContainerControl = this;
            // 
            // UpdateUserInformationForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(511, 614);
            Controls.Add(btnSave);
            Controls.Add(rbInactive);
            Controls.Add(rbActive);
            Controls.Add(lblUserActivetion);
            Controls.Add(txtBNewPassword);
            Controls.Add(txtBConfirmNewPassword);
            Controls.Add(txtBCurrentPassword);
            Controls.Add(lblChangeActivetion);
            Controls.Add(lblChangePassword);
            Controls.Add(lblMainLabel);
            Controls.Add(foreverClose1);
            Name = "UpdateUserInformationForm";
            Text = "ChangeCurrentUserPasswordForm";
            ((System.ComponentModel.ISupportInitialize)errorProvider1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.BigLabel lblMainLabel;
        private ReaLTaiizor.Controls.ForeverClose foreverClose1;
        private ReaLTaiizor.Controls.BigLabel lblChangePassword;
        private ReaLTaiizor.Controls.BigLabel lblChangeActivetion;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtBCurrentPassword;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtBConfirmNewPassword;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtBNewPassword;
        private ReaLTaiizor.Controls.BigLabel lblUserActivetion;
        private ReaLTaiizor.Controls.MaterialRadioButton rbActive;
        private ReaLTaiizor.Controls.MaterialRadioButton rbInactive;
        private ReaLTaiizor.Controls.MaterialButton btnSave;
        private ErrorProvider errorProvider1;
    }
}