namespace DVLD.UI
{
    partial class UserInformationForm
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
            ctrlPersonInformation1 = new CtrlPersonInformation();
            lblMainLabel = new ReaLTaiizor.Controls.BigLabel();
            foreverClose1 = new ReaLTaiizor.Controls.ForeverClose();
            ctrlUserLoginInformation1 = new CtrlUserLoginInformation();
            SuspendLayout();
            // 
            // ctrlPersonInformation1
            // 
            ctrlPersonInformation1.Location = new Point(16, 70);
            ctrlPersonInformation1.Name = "ctrlPersonInformation1";
            ctrlPersonInformation1.Size = new Size(803, 488);
            ctrlPersonInformation1.TabIndex = 0;
            // 
            // lblMainLabel
            // 
            lblMainLabel.AutoSize = true;
            lblMainLabel.BackColor = Color.Transparent;
            lblMainLabel.Font = new Font("Arial Narrow", 25.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMainLabel.ForeColor = Color.Black;
            lblMainLabel.Location = new Point(12, 18);
            lblMainLabel.Name = "lblMainLabel";
            lblMainLabel.Size = new Size(277, 49);
            lblMainLabel.TabIndex = 18;
            lblMainLabel.Text = "User Information";
            // 
            // foreverClose1
            // 
            foreverClose1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            foreverClose1.BackColor = Color.White;
            foreverClose1.BaseColor = Color.FromArgb(45, 47, 49);
            foreverClose1.DefaultLocation = true;
            foreverClose1.DownColor = Color.FromArgb(30, 0, 0, 0);
            foreverClose1.Font = new Font("Marlett", 10F);
            foreverClose1.Location = new Point(804, 16);
            foreverClose1.Name = "foreverClose1";
            foreverClose1.OverColor = Color.FromArgb(30, 255, 255, 255);
            foreverClose1.Size = new Size(18, 18);
            foreverClose1.TabIndex = 17;
            foreverClose1.Text = "foreverClose1";
            foreverClose1.TextColor = Color.FromArgb(243, 243, 243);
            // 
            // ctrlUserLoginInformation1
            // 
            ctrlUserLoginInformation1.Location = new Point(16, 591);
            ctrlUserLoginInformation1.Name = "ctrlUserLoginInformation1";
            ctrlUserLoginInformation1.Size = new Size(803, 111);
            ctrlUserLoginInformation1.TabIndex = 19;
            // 
            // UserInformationForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(834, 714);
            Controls.Add(ctrlUserLoginInformation1);
            Controls.Add(lblMainLabel);
            Controls.Add(foreverClose1);
            Controls.Add(ctrlPersonInformation1);
            Name = "UserInformationForm";
            Text = "UserInformationForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CtrlPersonInformation ctrlPersonInformation1;
        private ReaLTaiizor.Controls.BigLabel lblMainLabel;
        private ReaLTaiizor.Controls.ForeverClose foreverClose1;
        private CtrlUserLoginInformation ctrlUserInformation1;
        private CtrlUserLoginInformation ctrlUserLoginInformation1;
    }
}