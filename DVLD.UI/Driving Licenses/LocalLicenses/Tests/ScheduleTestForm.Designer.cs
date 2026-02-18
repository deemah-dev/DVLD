namespace DVLD.UI
{
    partial class ScheduleTestForm
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
            ctrlScheduleTest1 = new CtrlScheduleTest();
            foreverClose1 = new ReaLTaiizor.Controls.ForeverClose();
            SuspendLayout();
            // 
            // ctrlScheduleTest1
            // 
            ctrlScheduleTest1.Location = new Point(6, 4);
            ctrlScheduleTest1.Name = "ctrlScheduleTest1";
            ctrlScheduleTest1.Size = new Size(567, 717);
            ctrlScheduleTest1.TabIndex = 0;
            ctrlScheduleTest1.Load += ctrlScheduleTest1_Load;
            // 
            // foreverClose1
            // 
            foreverClose1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            foreverClose1.BackColor = Color.White;
            foreverClose1.BaseColor = Color.FromArgb(45, 47, 49);
            foreverClose1.DefaultLocation = true;
            foreverClose1.DownColor = Color.FromArgb(30, 0, 0, 0);
            foreverClose1.Font = new Font("Marlett", 10F);
            foreverClose1.Location = new Point(551, 16);
            foreverClose1.Name = "foreverClose1";
            foreverClose1.OverColor = Color.FromArgb(30, 255, 255, 255);
            foreverClose1.Size = new Size(18, 18);
            foreverClose1.TabIndex = 26;
            foreverClose1.Text = "foreverClose1";
            foreverClose1.TextColor = Color.FromArgb(243, 243, 243);
            // 
            // ScheduleTestForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(581, 728);
            Controls.Add(foreverClose1);
            Controls.Add(ctrlScheduleTest1);
            Name = "ScheduleTestForm";
            Text = "ScheduleTestForm";
            ResumeLayout(false);
        }

        #endregion

        private CtrlScheduleTest ctrlScheduleTest1;
        private ReaLTaiizor.Controls.ForeverClose foreverClose1;
    }
}