namespace DVLD.UI
{
    partial class StreetTestAppointmentForm
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
            ctrlTestAppoinment1 = new CtrlTestAppoinment();
            bigLabel2 = new ReaLTaiizor.Controls.BigLabel();
            foreverClose1 = new ReaLTaiizor.Controls.ForeverClose();
            SuspendLayout();
            // 
            // ctrlTestAppoinment1
            // 
            ctrlTestAppoinment1.Location = new Point(3, 75);
            ctrlTestAppoinment1.Name = "ctrlTestAppoinment1";
            ctrlTestAppoinment1.Size = new Size(794, 744);
            ctrlTestAppoinment1.TabIndex = 30;
            ctrlTestAppoinment1.TestType = BLL.TestTypes.Street;
            // 
            // bigLabel2
            // 
            bigLabel2.AutoSize = true;
            bigLabel2.BackColor = Color.Transparent;
            bigLabel2.Font = new Font("Arial Narrow", 24F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bigLabel2.ForeColor = Color.Black;
            bigLabel2.Location = new Point(12, 7);
            bigLabel2.Name = "bigLabel2";
            bigLabel2.Size = new Size(370, 46);
            bigLabel2.TabIndex = 29;
            bigLabel2.Text = "Street Test Appointment";
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
            foreverClose1.TabIndex = 28;
            foreverClose1.Text = "foreverClose1";
            foreverClose1.TextColor = Color.FromArgb(243, 243, 243);
            // 
            // StreetTestAppointmentForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 840);
            Controls.Add(ctrlTestAppoinment1);
            Controls.Add(bigLabel2);
            Controls.Add(foreverClose1);
            Name = "StreetTestAppointmentForm";
            Text = "StreetTestAppointmentForm";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CtrlTestAppoinment ctrlTestAppoinment1;
        private ReaLTaiizor.Controls.BigLabel bigLabel2;
        private ReaLTaiizor.Controls.ForeverClose foreverClose1;
    }
}