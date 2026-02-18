namespace DVLD.UI
{
    partial class ManageApplicationsTypesForm
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            grdVApplications = new ReaLTaiizor.Controls.PoisonDataGridView();
            bigLabel2 = new ReaLTaiizor.Controls.BigLabel();
            foreverClose1 = new ReaLTaiizor.Controls.ForeverClose();
            crownContextMenuStrip1 = new ReaLTaiizor.Controls.CrownContextMenuStrip();
            editToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)grdVApplications).BeginInit();
            crownContextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // grdVApplications
            // 
            grdVApplications.AllowUserToAddRows = false;
            grdVApplications.AllowUserToDeleteRows = false;
            grdVApplications.AllowUserToOrderColumns = true;
            grdVApplications.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grdVApplications.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            grdVApplications.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grdVApplications.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            grdVApplications.BackgroundColor = Color.FromArgb(255, 255, 255);
            grdVApplications.BorderStyle = BorderStyle.None;
            grdVApplications.CellBorderStyle = DataGridViewCellBorderStyle.None;
            grdVApplications.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(0, 177, 89);
            dataGridViewCellStyle2.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 208, 104);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            grdVApplications.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            grdVApplications.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdVApplications.ContextMenuStrip = crownContextMenuStrip1;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle3.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(136, 136, 136);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(0, 208, 104);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            grdVApplications.DefaultCellStyle = dataGridViewCellStyle3;
            grdVApplications.EnableHeadersVisualStyles = false;
            grdVApplications.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            grdVApplications.GridColor = Color.FromArgb(255, 255, 255);
            grdVApplications.Location = new Point(12, 76);
            grdVApplications.MultiSelect = false;
            grdVApplications.Name = "grdVApplications";
            grdVApplications.ReadOnly = true;
            grdVApplications.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(0, 177, 89);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(0, 208, 104);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            grdVApplications.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            grdVApplications.RowHeadersWidth = 51;
            grdVApplications.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grdVApplications.RowsDefaultCellStyle = dataGridViewCellStyle5;
            grdVApplications.ScrollBars = ScrollBars.Vertical;
            grdVApplications.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdVApplications.Size = new Size(776, 318);
            grdVApplications.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Green;
            grdVApplications.TabIndex = 50;
            // 
            // bigLabel2
            // 
            bigLabel2.AutoSize = true;
            bigLabel2.BackColor = Color.Transparent;
            bigLabel2.Font = new Font("Arial Narrow", 25.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bigLabel2.ForeColor = Color.Black;
            bigLabel2.Location = new Point(12, 9);
            bigLabel2.Name = "bigLabel2";
            bigLabel2.Size = new Size(445, 49);
            bigLabel2.TabIndex = 49;
            bigLabel2.Text = "Manage Applications Types";
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
            foreverClose1.TabIndex = 48;
            foreverClose1.Text = "foreverClose1";
            foreverClose1.TextColor = Color.FromArgb(243, 243, 243);
            // 
            // crownContextMenuStrip1
            // 
            crownContextMenuStrip1.BackColor = Color.White;
            crownContextMenuStrip1.Font = new Font("Arial Narrow", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            crownContextMenuStrip1.ForeColor = Color.FromArgb(220, 220, 220);
            crownContextMenuStrip1.ImageScalingSize = new Size(20, 20);
            crownContextMenuStrip1.Items.AddRange(new ToolStripItem[] { editToolStripMenuItem });
            crownContextMenuStrip1.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;
            crownContextMenuStrip1.Name = "crownContextMenuStrip1";
            crownContextMenuStrip1.ShowImageMargin = false;
            crownContextMenuStrip1.Size = new Size(80, 30);
            // 
            // editToolStripMenuItem
            // 
            editToolStripMenuItem.BackColor = Color.FromArgb(60, 63, 65);
            editToolStripMenuItem.ForeColor = Color.FromArgb(220, 220, 220);
            editToolStripMenuItem.Name = "editToolStripMenuItem";
            editToolStripMenuItem.Size = new Size(79, 26);
            editToolStripMenuItem.Text = "Edit";
            editToolStripMenuItem.Click += editToolStripMenuItem_Click;
            // 
            // ManageApplicationsTypesForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(801, 422);
            Controls.Add(grdVApplications);
            Controls.Add(bigLabel2);
            Controls.Add(foreverClose1);
            Name = "ManageApplicationsTypesForm";
            Text = "ManageApplicationsTypesForm";
            Load += ManageApplicationsTypesForm_Load;
            ((System.ComponentModel.ISupportInitialize)grdVApplications).EndInit();
            crownContextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.PoisonDataGridView grdVApplications;
        private ReaLTaiizor.Controls.BigLabel bigLabel2;
        private ReaLTaiizor.Controls.ForeverClose foreverClose1;
        private ReaLTaiizor.Controls.CrownContextMenuStrip crownContextMenuStrip1;
        private ToolStripMenuItem editToolStripMenuItem;
    }
}