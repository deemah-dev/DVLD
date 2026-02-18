namespace DVLD.UI
{
    partial class IssueDriverLicenseForTheFirstTimeForm
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
            ctrlLocalDrivingLicenseApplicationInformation1 = new CtrlLocalDrivingLicenseApplicationInformation();
            txtBNotes = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            btnIssue = new ReaLTaiizor.Controls.MaterialButton();
            foreverClose1 = new ReaLTaiizor.Controls.ForeverClose();
            lblMainLabel = new ReaLTaiizor.Controls.BigLabel();
            SuspendLayout();
            // 
            // ctrlLocalDrivingLicenseApplicationInformation1
            // 
            ctrlLocalDrivingLicenseApplicationInformation1.Location = new Point(12, 68);
            ctrlLocalDrivingLicenseApplicationInformation1.Name = "ctrlLocalDrivingLicenseApplicationInformation1";
            ctrlLocalDrivingLicenseApplicationInformation1.Size = new Size(824, 551);
            ctrlLocalDrivingLicenseApplicationInformation1.TabIndex = 0;
            // 
            // txtBNotes
            // 
            txtBNotes.AnimateReadOnly = false;
            txtBNotes.AutoCompleteMode = AutoCompleteMode.None;
            txtBNotes.AutoCompleteSource = AutoCompleteSource.None;
            txtBNotes.BackgroundImageLayout = ImageLayout.None;
            txtBNotes.CharacterCasing = CharacterCasing.Normal;
            txtBNotes.Depth = 0;
            txtBNotes.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtBNotes.HideSelection = true;
            txtBNotes.Hint = "Notes";
            txtBNotes.LeadingIcon = null;
            txtBNotes.Location = new Point(12, 637);
            txtBNotes.MaxLength = 32767;
            txtBNotes.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtBNotes.Name = "txtBNotes";
            txtBNotes.PasswordChar = '\0';
            txtBNotes.PrefixSuffixText = null;
            txtBNotes.ReadOnly = false;
            txtBNotes.RightToLeft = RightToLeft.No;
            txtBNotes.SelectedText = "";
            txtBNotes.SelectionLength = 0;
            txtBNotes.SelectionStart = 0;
            txtBNotes.ShortcutsEnabled = true;
            txtBNotes.Size = new Size(385, 48);
            txtBNotes.TabIndex = 195;
            txtBNotes.TabStop = false;
            txtBNotes.TextAlign = HorizontalAlignment.Left;
            txtBNotes.TrailingIcon = null;
            txtBNotes.UseSystemPasswordChar = false;
            // 
            // btnIssue
            // 
            btnIssue.AutoSize = false;
            btnIssue.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnIssue.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnIssue.Depth = 0;
            btnIssue.HighEmphasis = true;
            btnIssue.Icon = null;
            btnIssue.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnIssue.Location = new Point(740, 637);
            btnIssue.Margin = new Padding(4, 6, 4, 6);
            btnIssue.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnIssue.Name = "btnIssue";
            btnIssue.NoAccentTextColor = Color.Empty;
            btnIssue.Size = new Size(96, 53);
            btnIssue.TabIndex = 196;
            btnIssue.Text = "Issue";
            btnIssue.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnIssue.UseAccentColor = false;
            btnIssue.UseVisualStyleBackColor = true;
            btnIssue.Click += btnIssue_Click;
            // 
            // foreverClose1
            // 
            foreverClose1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            foreverClose1.BackColor = Color.White;
            foreverClose1.BaseColor = Color.FromArgb(45, 47, 49);
            foreverClose1.DefaultLocation = true;
            foreverClose1.DownColor = Color.FromArgb(30, 0, 0, 0);
            foreverClose1.Font = new Font("Marlett", 10F);
            foreverClose1.Location = new Point(822, 16);
            foreverClose1.Name = "foreverClose1";
            foreverClose1.OverColor = Color.FromArgb(30, 255, 255, 255);
            foreverClose1.Size = new Size(18, 18);
            foreverClose1.TabIndex = 198;
            foreverClose1.Text = "foreverClose1";
            foreverClose1.TextColor = Color.FromArgb(243, 243, 243);
            // 
            // lblMainLabel
            // 
            lblMainLabel.AutoSize = true;
            lblMainLabel.BackColor = Color.Transparent;
            lblMainLabel.Font = new Font("Arial Narrow", 25.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMainLabel.ForeColor = Color.Black;
            lblMainLabel.Location = new Point(2, 9);
            lblMainLabel.Name = "lblMainLabel";
            lblMainLabel.Size = new Size(441, 49);
            lblMainLabel.TabIndex = 197;
            lblMainLabel.Text = "Issue Local Driving License";
            // 
            // IssueDriverLicenseForTheFirstTimeForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(852, 709);
            Controls.Add(foreverClose1);
            Controls.Add(lblMainLabel);
            Controls.Add(btnIssue);
            Controls.Add(txtBNotes);
            Controls.Add(ctrlLocalDrivingLicenseApplicationInformation1);
            Name = "IssueDriverLicenseForTheFirstTimeForm";
            Text = "IssueDriverLicenseForTheFirstTimeForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CtrlLocalDrivingLicenseApplicationInformation ctrlLocalDrivingLicenseApplicationInformation1;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtBNotes;
        private ReaLTaiizor.Controls.MaterialButton btnIssue;
        private ReaLTaiizor.Controls.ForeverClose foreverClose1;
        private ReaLTaiizor.Controls.BigLabel lblMainLabel;
    }
}