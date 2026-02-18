namespace DVLD.UI
{
    partial class VisionTestAppointmentForm
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
            ctrlTestAppoinment1 = new CtrlTestAppoinment();
            SuspendLayout();
            // 
            // bigLabel2
            // 
            bigLabel2.AutoSize = true;
            bigLabel2.BackColor = Color.Transparent;
            bigLabel2.Font = new Font("Arial Narrow", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bigLabel2.ForeColor = Color.Black;
            bigLabel2.Location = new Point(12, 9);
            bigLabel2.Name = "bigLabel2";
            bigLabel2.Size = new Size(371, 46);
            bigLabel2.TabIndex = 26;
            bigLabel2.Text = "Vision Test Appointment";
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
            foreverClose1.TabIndex = 25;
            foreverClose1.Text = "foreverClose1";
            foreverClose1.TextColor = Color.FromArgb(243, 243, 243);
            // 
            // ctrlTestAppoinment1
            // 
            ctrlTestAppoinment1.Location = new Point(3, 77);
            ctrlTestAppoinment1.Name = "ctrlTestAppoinment1";
            ctrlTestAppoinment1.Size = new Size(794, 744);
            ctrlTestAppoinment1.TabIndex = 27;
            ctrlTestAppoinment1.TestType = BLL.TestTypes.Vision;
            // 
            // VisionTestAppointmentForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 840);
            Controls.Add(ctrlTestAppoinment1);
            Controls.Add(bigLabel2);
            Controls.Add(foreverClose1);
            Name = "VisionTestAppointmentForm";
            Text = "VisionTestAppointmentForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ReaLTaiizor.Controls.BigLabel bigLabel2;
        private ReaLTaiizor.Controls.ForeverClose foreverClose1;
        private CtrlTestAppoinment ctrlTestAppoinment1;
    }
}