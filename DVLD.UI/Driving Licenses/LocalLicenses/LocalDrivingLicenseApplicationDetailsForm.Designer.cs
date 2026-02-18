namespace DVLD.UI
{
    partial class LocalDrivingLicenseApplicationDetailsForm
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
            ctrlLocalDrivingLicenseApplicationInformation1 = new CtrlLocalDrivingLicenseApplicationInformation();
            SuspendLayout();
            // 
            // bigLabel2
            // 
            bigLabel2.AutoSize = true;
            bigLabel2.BackColor = Color.Transparent;
            bigLabel2.Font = new Font("Arial Narrow", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bigLabel2.ForeColor = Color.Black;
            bigLabel2.Location = new Point(9, 9);
            bigLabel2.Name = "bigLabel2";
            bigLabel2.Size = new Size(602, 46);
            bigLabel2.TabIndex = 24;
            bigLabel2.Text = "Local Driving License Application Details";
            // 
            // foreverClose1
            // 
            foreverClose1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            foreverClose1.BackColor = Color.White;
            foreverClose1.BaseColor = Color.FromArgb(45, 47, 49);
            foreverClose1.DefaultLocation = true;
            foreverClose1.DownColor = Color.FromArgb(30, 0, 0, 0);
            foreverClose1.Font = new Font("Marlett", 10F);
            foreverClose1.Location = new Point(771, 16);
            foreverClose1.Name = "foreverClose1";
            foreverClose1.OverColor = Color.FromArgb(30, 255, 255, 255);
            foreverClose1.Size = new Size(18, 18);
            foreverClose1.TabIndex = 23;
            foreverClose1.Text = "foreverClose1";
            foreverClose1.TextColor = Color.FromArgb(243, 243, 243);
            // 
            // ctrlLocalDrivingLicenseApplicationInformation1
            // 
            ctrlLocalDrivingLicenseApplicationInformation1.Location = new Point(12, 73);
            ctrlLocalDrivingLicenseApplicationInformation1.Name = "ctrlLocalDrivingLicenseApplicationInformation1";
            ctrlLocalDrivingLicenseApplicationInformation1.Size = new Size(775, 554);
            ctrlLocalDrivingLicenseApplicationInformation1.TabIndex = 25;
            // 
            // LocalDrivingLicenseApplicationDetailsForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(801, 655);
            Controls.Add(ctrlLocalDrivingLicenseApplicationInformation1);
            Controls.Add(bigLabel2);
            Controls.Add(foreverClose1);
            Name = "LocalDrivingLicenseApplicationDetailsForm";
            Text = "LocalDrivingLicenseApplicationDetailsForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ReaLTaiizor.Controls.BigLabel bigLabel2;
        private ReaLTaiizor.Controls.ForeverClose foreverClose1;
        private ReaLTaiizor.Controls.MetroLinkLabel lnkLblViewPersonInformation;
        private ReaLTaiizor.Controls.BigLabel lblCreatedByUsername;
        private ReaLTaiizor.Controls.BigLabel bigLabel11;
        private ReaLTaiizor.Controls.BigLabel lblLastStatusDate;
        private ReaLTaiizor.Controls.BigLabel lblAppDate;
        private ReaLTaiizor.Controls.BigLabel bigLabel14;
        private ReaLTaiizor.Controls.BigLabel bigLabel15;
        private ReaLTaiizor.Controls.BigLabel lblApplicantFullName;
        private ReaLTaiizor.Controls.BigLabel bigLabel3;
        private ReaLTaiizor.Controls.BigLabel lblAppType;
        private ReaLTaiizor.Controls.BigLabel lblAppFees;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private ReaLTaiizor.Controls.BigLabel lblAppStatus;
        private CtrlLocalDrivingLicenseApplicationInformation ctrlLocalDrivingLicenseApplicationInformation1;
    }
}