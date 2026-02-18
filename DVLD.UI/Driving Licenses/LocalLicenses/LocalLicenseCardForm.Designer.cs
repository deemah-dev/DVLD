namespace DVLD.UI
{
    partial class LocalLicenseCardForm
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
            ctrlLocalLicesneInformation1 = new CtrlLocalLicesneInformation();
            SuspendLayout();
            // 
            // lblMainLabel
            // 
            lblMainLabel.AutoSize = true;
            lblMainLabel.BackColor = Color.Transparent;
            lblMainLabel.Font = new Font("Arial Narrow", 25.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMainLabel.ForeColor = Color.Black;
            lblMainLabel.Location = new Point(2, 3);
            lblMainLabel.Name = "lblMainLabel";
            lblMainLabel.Size = new Size(433, 49);
            lblMainLabel.TabIndex = 160;
            lblMainLabel.Text = "Local Driving License Card";
            // 
            // foreverClose1
            // 
            foreverClose1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            foreverClose1.BackColor = Color.White;
            foreverClose1.BaseColor = Color.FromArgb(45, 47, 49);
            foreverClose1.DefaultLocation = true;
            foreverClose1.DownColor = Color.FromArgb(30, 0, 0, 0);
            foreverClose1.Font = new Font("Marlett", 10F);
            foreverClose1.Location = new Point(760, 12);
            foreverClose1.Name = "foreverClose1";
            foreverClose1.OverColor = Color.FromArgb(30, 255, 255, 255);
            foreverClose1.Size = new Size(18, 18);
            foreverClose1.TabIndex = 159;
            foreverClose1.Text = "foreverClose1";
            foreverClose1.TextColor = Color.FromArgb(243, 243, 243);
            // 
            // ctrlLocalLicesneInformation1
            // 
            ctrlLocalLicesneInformation1.Location = new Point(2, 55);
            ctrlLocalLicesneInformation1.Name = "ctrlLocalLicesneInformation1";
            ctrlLocalLicesneInformation1.Size = new Size(776, 442);
            ctrlLocalLicesneInformation1.TabIndex = 161;
            // 
            // LocalLicenseCardForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(790, 510);
            Controls.Add(ctrlLocalLicesneInformation1);
            Controls.Add(lblMainLabel);
            Controls.Add(foreverClose1);
            Name = "LocalLicenseCardForm";
            Text = "LocalLicenseCardForm";
            Load += LocalLicenseCardForm_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.BigLabel lblMainLabel;
        private ReaLTaiizor.Controls.ForeverClose foreverClose1;
        private CtrlLocalLicesneInformation ctrlLocalLicesneInformation1;
    }
}