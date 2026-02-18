namespace DVLD.UI
{
    partial class CtrlTestAppoinment
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            btnAddAppoinment = new ReaLTaiizor.Controls.HopePictureBox();
            grdVAppoinments = new ReaLTaiizor.Controls.PoisonDataGridView();
            ctrlLocalDrivingLicenseApplicationInformation1 = new CtrlLocalDrivingLicenseApplicationInformation();
            crownContextMenuStrip1 = new ReaLTaiizor.Controls.CrownContextMenuStrip();
            editDateToolStripMenuItem = new ToolStripMenuItem();
            takeTestToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)btnAddAppoinment).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grdVAppoinments).BeginInit();
            crownContextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // bigLabel1
            // 
            bigLabel1.AutoSize = true;
            bigLabel1.BackColor = Color.Transparent;
            bigLabel1.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bigLabel1.ForeColor = Color.Black;
            bigLabel1.Location = new Point(3, 571);
            bigLabel1.Name = "bigLabel1";
            bigLabel1.Size = new Size(124, 27);
            bigLabel1.TabIndex = 47;
            bigLabel1.Text = "Appointments";
            // 
            // btnAddAppoinment
            // 
            btnAddAppoinment.BackColor = Color.FromArgb(192, 196, 204);
            btnAddAppoinment.Image = Properties.Resources.add_icon_215758;
            btnAddAppoinment.Location = new Point(714, 558);
            btnAddAppoinment.Name = "btnAddAppoinment";
            btnAddAppoinment.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            btnAddAppoinment.Size = new Size(65, 40);
            btnAddAppoinment.SizeMode = PictureBoxSizeMode.StretchImage;
            btnAddAppoinment.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnAddAppoinment.TabIndex = 46;
            btnAddAppoinment.TabStop = false;
            btnAddAppoinment.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnAddAppoinment.Click += btnAddAppoinment_Click;
            // 
            // grdVAppoinments
            // 
            grdVAppoinments.AllowUserToAddRows = false;
            grdVAppoinments.AllowUserToDeleteRows = false;
            grdVAppoinments.AllowUserToOrderColumns = true;
            grdVAppoinments.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grdVAppoinments.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            grdVAppoinments.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grdVAppoinments.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            grdVAppoinments.BackgroundColor = Color.FromArgb(255, 255, 255);
            grdVAppoinments.BorderStyle = BorderStyle.None;
            grdVAppoinments.CellBorderStyle = DataGridViewCellBorderStyle.None;
            grdVAppoinments.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(0, 177, 89);
            dataGridViewCellStyle2.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 208, 104);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            grdVAppoinments.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            grdVAppoinments.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdVAppoinments.ContextMenuStrip = crownContextMenuStrip1;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle3.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(136, 136, 136);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(0, 208, 104);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            grdVAppoinments.DefaultCellStyle = dataGridViewCellStyle3;
            grdVAppoinments.EnableHeadersVisualStyles = false;
            grdVAppoinments.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            grdVAppoinments.GridColor = Color.FromArgb(255, 255, 255);
            grdVAppoinments.Location = new Point(6, 604);
            grdVAppoinments.MultiSelect = false;
            grdVAppoinments.Name = "grdVAppoinments";
            grdVAppoinments.ReadOnly = true;
            grdVAppoinments.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(0, 177, 89);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(0, 208, 104);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            grdVAppoinments.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            grdVAppoinments.RowHeadersWidth = 51;
            grdVAppoinments.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grdVAppoinments.RowsDefaultCellStyle = dataGridViewCellStyle5;
            grdVAppoinments.ScrollBars = ScrollBars.Vertical;
            grdVAppoinments.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdVAppoinments.Size = new Size(773, 135);
            grdVAppoinments.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Green;
            grdVAppoinments.TabIndex = 45;
            // 
            // ctrlLocalDrivingLicenseApplicationInformation1
            // 
            ctrlLocalDrivingLicenseApplicationInformation1.Location = new Point(6, 3);
            ctrlLocalDrivingLicenseApplicationInformation1.Name = "ctrlLocalDrivingLicenseApplicationInformation1";
            ctrlLocalDrivingLicenseApplicationInformation1.Size = new Size(775, 552);
            ctrlLocalDrivingLicenseApplicationInformation1.TabIndex = 44;
            // 
            // crownContextMenuStrip1
            // 
            crownContextMenuStrip1.BackColor = Color.White;
            crownContextMenuStrip1.Font = new Font("Arial Narrow", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            crownContextMenuStrip1.ForeColor = Color.FromArgb(220, 220, 220);
            crownContextMenuStrip1.ImageScalingSize = new Size(20, 20);
            crownContextMenuStrip1.Items.AddRange(new ToolStripItem[] { editDateToolStripMenuItem, takeTestToolStripMenuItem });
            crownContextMenuStrip1.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;
            crownContextMenuStrip1.Name = "crownContextMenuStrip1";
            crownContextMenuStrip1.ShowImageMargin = false;
            crownContextMenuStrip1.Size = new Size(119, 56);
            // 
            // editDateToolStripMenuItem
            // 
            editDateToolStripMenuItem.BackColor = Color.FromArgb(60, 63, 65);
            editDateToolStripMenuItem.ForeColor = Color.FromArgb(220, 220, 220);
            editDateToolStripMenuItem.Name = "editDateToolStripMenuItem";
            editDateToolStripMenuItem.Size = new Size(118, 26);
            editDateToolStripMenuItem.Text = "Edit Date";
            editDateToolStripMenuItem.Click += editDateToolStripMenuItem_Click;
            // 
            // takeTestToolStripMenuItem
            // 
            takeTestToolStripMenuItem.BackColor = Color.FromArgb(60, 63, 65);
            takeTestToolStripMenuItem.ForeColor = Color.FromArgb(220, 220, 220);
            takeTestToolStripMenuItem.Name = "takeTestToolStripMenuItem";
            takeTestToolStripMenuItem.Size = new Size(118, 26);
            takeTestToolStripMenuItem.Text = "Take Test";
            takeTestToolStripMenuItem.Click += takeTestToolStripMenuItem_Click;
            // 
            // CtrlTestAppoinment
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(bigLabel1);
            Controls.Add(btnAddAppoinment);
            Controls.Add(grdVAppoinments);
            Controls.Add(ctrlLocalDrivingLicenseApplicationInformation1);
            Name = "CtrlTestAppoinment";
            Size = new Size(788, 752);
            ((System.ComponentModel.ISupportInitialize)btnAddAppoinment).EndInit();
            ((System.ComponentModel.ISupportInitialize)grdVAppoinments).EndInit();
            crownContextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private ReaLTaiizor.Controls.HopePictureBox btnAddAppoinment;
        private ReaLTaiizor.Controls.PoisonDataGridView grdVAppoinments;
        private CtrlLocalDrivingLicenseApplicationInformation ctrlLocalDrivingLicenseApplicationInformation1;
        private ReaLTaiizor.Controls.CrownContextMenuStrip crownContextMenuStrip1;
        private ToolStripMenuItem editDateToolStripMenuItem;
        private ToolStripMenuItem takeTestToolStripMenuItem;
    }
}
