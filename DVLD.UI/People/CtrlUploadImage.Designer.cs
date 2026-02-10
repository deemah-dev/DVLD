namespace DVLD.UI
{
    partial class CtrlUploadImage
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
            hopePictureBox1 = new ReaLTaiizor.Controls.HopePictureBox();
            lblEnterToUpload = new ReaLTaiizor.Controls.BigLabel();
            lnkLblEdit = new ReaLTaiizor.Controls.LinkLabelEdit();
            lnkLblRemove = new ReaLTaiizor.Controls.LinkLabelEdit();
            openFileDialog1 = new OpenFileDialog();
            ((System.ComponentModel.ISupportInitialize)hopePictureBox1).BeginInit();
            SuspendLayout();
            // 
            // hopePictureBox1
            // 
            hopePictureBox1.BackColor = Color.FromArgb(192, 196, 204);
            hopePictureBox1.Location = new Point(7, 9);
            hopePictureBox1.Name = "hopePictureBox1";
            hopePictureBox1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            hopePictureBox1.Size = new Size(194, 132);
            hopePictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            hopePictureBox1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            hopePictureBox1.TabIndex = 65;
            hopePictureBox1.TabStop = false;
            hopePictureBox1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            hopePictureBox1.Click += hopePictureBox1_Click;
            // 
            // lblEnterToUpload
            // 
            lblEnterToUpload.AutoSize = true;
            lblEnterToUpload.BackColor = Color.FromArgb(192, 196, 204);
            lblEnterToUpload.Font = new Font("Arial Narrow", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEnterToUpload.ForeColor = Color.Gray;
            lblEnterToUpload.Location = new Point(41, 66);
            lblEnterToUpload.Name = "lblEnterToUpload";
            lblEnterToUpload.Size = new Size(115, 22);
            lblEnterToUpload.TabIndex = 68;
            lblEnterToUpload.Text = "Enter To Upload";
            lblEnterToUpload.Click += hopePictureBox1_Click;
            // 
            // lnkLblEdit
            // 
            lnkLblEdit.ActiveLinkColor = Color.FromArgb(128, 128, 255);
            lnkLblEdit.AutoSize = true;
            lnkLblEdit.BackColor = Color.Transparent;
            lnkLblEdit.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lnkLblEdit.ForeColor = Color.Black;
            lnkLblEdit.LinkBehavior = LinkBehavior.NeverUnderline;
            lnkLblEdit.LinkColor = Color.Blue;
            lnkLblEdit.Location = new Point(163, 148);
            lnkLblEdit.Name = "lnkLblEdit";
            lnkLblEdit.Size = new Size(38, 20);
            lnkLblEdit.TabIndex = 70;
            lnkLblEdit.TabStop = true;
            lnkLblEdit.Text = "Edit";
            lnkLblEdit.Visible = false;
            lnkLblEdit.VisitedLinkColor = Color.FromArgb(32, 34, 37);
            lnkLblEdit.LinkClicked += lnkLblEdit_LinkClicked;
            // 
            // lnkLblRemove
            // 
            lnkLblRemove.ActiveLinkColor = Color.Red;
            lnkLblRemove.AutoSize = true;
            lnkLblRemove.BackColor = Color.Transparent;
            lnkLblRemove.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lnkLblRemove.ForeColor = Color.Black;
            lnkLblRemove.LinkBehavior = LinkBehavior.NeverUnderline;
            lnkLblRemove.LinkColor = Color.Maroon;
            lnkLblRemove.Location = new Point(7, 148);
            lnkLblRemove.Name = "lnkLblRemove";
            lnkLblRemove.Size = new Size(70, 20);
            lnkLblRemove.TabIndex = 69;
            lnkLblRemove.TabStop = true;
            lnkLblRemove.Text = "Remove";
            lnkLblRemove.Visible = false;
            lnkLblRemove.VisitedLinkColor = Color.FromArgb(32, 34, 37);
            lnkLblRemove.LinkClicked += lnkLblRemove_LinkClicked;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // CtrlUploadImage
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lnkLblEdit);
            Controls.Add(lnkLblRemove);
            Controls.Add(lblEnterToUpload);
            Controls.Add(hopePictureBox1);
            Name = "CtrlUploadImage";
            Size = new Size(208, 178);
            ((System.ComponentModel.ISupportInitialize)hopePictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.HopePictureBox hopePictureBox1;
        private ReaLTaiizor.Controls.BigLabel lblEnterToUpload;
        private ReaLTaiizor.Controls.LinkLabelEdit lnkLblEdit;
        private ReaLTaiizor.Controls.LinkLabelEdit lnkLblRemove;
        private OpenFileDialog openFileDialog1;
    }
}
