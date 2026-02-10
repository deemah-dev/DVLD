namespace DVLD.UI
{
    partial class LoginForm
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
            foreverClose1 = new ReaLTaiizor.Controls.ForeverClose();
            bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            LoginPanel = new Panel();
            txtBPassword = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            txtBUsername = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            btnLogin = new ReaLTaiizor.Controls.MaterialButton();
            LoginPanel.SuspendLayout();
            SuspendLayout();
            // 
            // foreverClose1
            // 
            foreverClose1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            foreverClose1.BackColor = Color.White;
            foreverClose1.BaseColor = Color.FromArgb(45, 47, 49);
            foreverClose1.DefaultLocation = true;
            foreverClose1.DownColor = Color.FromArgb(30, 0, 0, 0);
            foreverClose1.Font = new Font("Marlett", 10F);
            foreverClose1.Location = new Point(583, 17);
            foreverClose1.Name = "foreverClose1";
            foreverClose1.OverColor = Color.FromArgb(30, 255, 255, 255);
            foreverClose1.Size = new Size(18, 18);
            foreverClose1.TabIndex = 28;
            foreverClose1.TextColor = Color.FromArgb(243, 243, 243);
            // 
            // bigLabel1
            // 
            bigLabel1.AutoSize = true;
            bigLabel1.BackColor = Color.Transparent;
            bigLabel1.Font = new Font("Arial Narrow", 25.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bigLabel1.ForeColor = Color.Black;
            bigLabel1.Location = new Point(12, 10);
            bigLabel1.Name = "bigLabel1";
            bigLabel1.Size = new Size(372, 49);
            bigLabel1.TabIndex = 27;
            bigLabel1.Text = "Login To Your Account";
            // 
            // LoginPanel
            // 
            LoginPanel.Controls.Add(txtBPassword);
            LoginPanel.Controls.Add(txtBUsername);
            LoginPanel.Controls.Add(btnLogin);
            LoginPanel.Location = new Point(12, 74);
            LoginPanel.Name = "LoginPanel";
            LoginPanel.Size = new Size(589, 398);
            LoginPanel.TabIndex = 26;
            // 
            // txtBPassword
            // 
            txtBPassword.AnimateReadOnly = false;
            txtBPassword.AutoCompleteMode = AutoCompleteMode.None;
            txtBPassword.AutoCompleteSource = AutoCompleteSource.None;
            txtBPassword.BackgroundImageLayout = ImageLayout.None;
            txtBPassword.CharacterCasing = CharacterCasing.Normal;
            txtBPassword.Depth = 0;
            txtBPassword.ErrorMessage = "This Field Is Requierd";
            txtBPassword.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtBPassword.HelperText = "Enter Your Password";
            txtBPassword.HideSelection = true;
            txtBPassword.Hint = "Password";
            txtBPassword.LeadingIcon = null;
            txtBPassword.LeaveOnEnterKey = true;
            txtBPassword.Location = new Point(138, 150);
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
            txtBPassword.TabIndex = 10;
            txtBPassword.TabStop = false;
            txtBPassword.TextAlign = HorizontalAlignment.Left;
            txtBPassword.TrailingIcon = null;
            txtBPassword.UseSystemPasswordChar = true;
            // 
            // txtBUsername
            // 
            txtBUsername.AnimateReadOnly = false;
            txtBUsername.AutoCompleteMode = AutoCompleteMode.None;
            txtBUsername.AutoCompleteSource = AutoCompleteSource.None;
            txtBUsername.BackgroundImageLayout = ImageLayout.None;
            txtBUsername.CharacterCasing = CharacterCasing.Normal;
            txtBUsername.Depth = 0;
            txtBUsername.ErrorMessage = "This Field Is Requierd";
            txtBUsername.Font = new Font("Arial Narrow", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBUsername.HelperText = "Enter Your Username";
            txtBUsername.HideSelection = true;
            txtBUsername.Hint = "Username";
            txtBUsername.LeadingIcon = null;
            txtBUsername.LeaveOnEnterKey = true;
            txtBUsername.Location = new Point(138, 83);
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
            txtBUsername.TabIndex = 9;
            txtBUsername.TabStop = false;
            txtBUsername.TextAlign = HorizontalAlignment.Left;
            txtBUsername.TrailingIcon = null;
            txtBUsername.UseSystemPasswordChar = false;
            // 
            // btnLogin
            // 
            btnLogin.AutoSize = false;
            btnLogin.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnLogin.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnLogin.Depth = 0;
            btnLogin.Font = new Font("Arial", 16.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.HighEmphasis = true;
            btnLogin.Icon = null;
            btnLogin.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnLogin.Location = new Point(196, 261);
            btnLogin.Margin = new Padding(4, 6, 4, 6);
            btnLogin.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnLogin.Name = "btnLogin";
            btnLogin.NoAccentTextColor = Color.Empty;
            btnLogin.Size = new Size(193, 53);
            btnLogin.TabIndex = 8;
            btnLogin.Text = "Login";
            btnLogin.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnLogin.UseAccentColor = false;
            btnLogin.UseVisualStyleBackColor = true;
            btnLogin.Click += btnLogin_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(613, 483);
            Controls.Add(foreverClose1);
            Controls.Add(bigLabel1);
            Controls.Add(LoginPanel);
            Name = "LoginForm";
            Text = "LoginForm";
            LoginPanel.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.ForeverClose foreverClose1;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private Panel LoginPanel;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtBPassword;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtBUsername;
        private ReaLTaiizor.Controls.MaterialButton btnLogin;
    }
}