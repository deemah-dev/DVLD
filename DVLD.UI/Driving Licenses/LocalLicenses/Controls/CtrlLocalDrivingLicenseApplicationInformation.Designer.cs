namespace DVLD.UI
{
    partial class CtrlLocalDrivingLicenseApplicationInformation
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            bigLabel16 = new ReaLTaiizor.Controls.BigLabel();
            lblLicenseCategory = new ReaLTaiizor.Controls.BigLabel();
            bigLabel7 = new ReaLTaiizor.Controls.BigLabel();
            lblPassedTests = new ReaLTaiizor.Controls.BigLabel();
            lblLocalAppID = new ReaLTaiizor.Controls.BigLabel();
            bigLabel9 = new ReaLTaiizor.Controls.BigLabel();
            bigLabel8 = new ReaLTaiizor.Controls.BigLabel();
            ctrlApplicationInformation1 = new ctrlApplicationInformation();
            SuspendLayout();
            // 
            // bigLabel16
            // 
            bigLabel16.AutoSize = true;
            bigLabel16.BackColor = Color.Transparent;
            bigLabel16.Font = new Font("Arial Narrow", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bigLabel16.ForeColor = Color.Black;
            bigLabel16.Location = new Point(3, 11);
            bigLabel16.Name = "bigLabel16";
            bigLabel16.Size = new Size(410, 40);
            bigLabel16.TabIndex = 95;
            bigLabel16.Text = "L.D.L.Application Information";
            // 
            // lblLicenseCategory
            // 
            lblLicenseCategory.AutoSize = true;
            lblLicenseCategory.BackColor = Color.Transparent;
            lblLicenseCategory.Font = new Font("Arial Narrow", 13.8F);
            lblLicenseCategory.ForeColor = Color.Black;
            lblLicenseCategory.Location = new Point(452, 73);
            lblLicenseCategory.Name = "lblLicenseCategory";
            lblLicenseCategory.Size = new Size(42, 27);
            lblLicenseCategory.TabIndex = 94;
            lblLicenseCategory.Text = "???";
            // 
            // bigLabel7
            // 
            bigLabel7.AutoSize = true;
            bigLabel7.BackColor = Color.Transparent;
            bigLabel7.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bigLabel7.ForeColor = Color.Black;
            bigLabel7.Location = new Point(278, 73);
            bigLabel7.Name = "bigLabel7";
            bigLabel7.Size = new Size(168, 27);
            bigLabel7.TabIndex = 93;
            bigLabel7.Text = "License Category";
            // 
            // lblPassedTests
            // 
            lblPassedTests.AutoSize = true;
            lblPassedTests.BackColor = Color.Transparent;
            lblPassedTests.Font = new Font("Arial Narrow", 13.8F);
            lblPassedTests.ForeColor = Color.Black;
            lblPassedTests.Location = new Point(169, 124);
            lblPassedTests.Name = "lblPassedTests";
            lblPassedTests.Size = new Size(42, 27);
            lblPassedTests.TabIndex = 92;
            lblPassedTests.Text = "???";
            // 
            // lblLocalAppID
            // 
            lblLocalAppID.AutoSize = true;
            lblLocalAppID.BackColor = Color.Transparent;
            lblLocalAppID.Font = new Font("Arial Narrow", 13.8F);
            lblLocalAppID.ForeColor = Color.Black;
            lblLocalAppID.Location = new Point(169, 73);
            lblLocalAppID.Name = "lblLocalAppID";
            lblLocalAppID.Size = new Size(42, 27);
            lblLocalAppID.TabIndex = 91;
            lblLocalAppID.Text = "???";
            // 
            // bigLabel9
            // 
            bigLabel9.AutoSize = true;
            bigLabel9.BackColor = Color.Transparent;
            bigLabel9.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bigLabel9.ForeColor = Color.Black;
            bigLabel9.Location = new Point(33, 124);
            bigLabel9.Name = "bigLabel9";
            bigLabel9.Size = new Size(130, 27);
            bigLabel9.TabIndex = 90;
            bigLabel9.Text = "Passed Tests";
            // 
            // bigLabel8
            // 
            bigLabel8.AutoSize = true;
            bigLabel8.BackColor = Color.Transparent;
            bigLabel8.Font = new Font("Arial Narrow", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            bigLabel8.ForeColor = Color.Black;
            bigLabel8.Location = new Point(33, 73);
            bigLabel8.Name = "bigLabel8";
            bigLabel8.Size = new Size(79, 27);
            bigLabel8.TabIndex = 89;
            bigLabel8.Text = "App. ID";
            // 
            // ctrlApplicationInformation1
            // 
            ctrlApplicationInformation1.Location = new Point(5, 190);
            ctrlApplicationInformation1.Name = "ctrlApplicationInformation1";
            ctrlApplicationInformation1.Size = new Size(778, 371);
            ctrlApplicationInformation1.TabIndex = 88;
            // 
            // CtrlLocalDrivingLicenseApplicationInformation
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(bigLabel16);
            Controls.Add(lblLicenseCategory);
            Controls.Add(bigLabel7);
            Controls.Add(lblPassedTests);
            Controls.Add(lblLocalAppID);
            Controls.Add(bigLabel9);
            Controls.Add(bigLabel8);
            Controls.Add(ctrlApplicationInformation1);
            Name = "CtrlLocalDrivingLicenseApplicationInformation";
            Size = new Size(788, 569);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.BigLabel bigLabel16;
        private ReaLTaiizor.Controls.BigLabel lblLicenseCategory;
        private ReaLTaiizor.Controls.BigLabel bigLabel7;
        private ReaLTaiizor.Controls.BigLabel lblPassedTests;
        private ReaLTaiizor.Controls.BigLabel lblLocalAppID;
        private ReaLTaiizor.Controls.BigLabel bigLabel9;
        private ReaLTaiizor.Controls.BigLabel bigLabel8;
        private ctrlApplicationInformation ctrlApplicationInformation1;
    }
}
