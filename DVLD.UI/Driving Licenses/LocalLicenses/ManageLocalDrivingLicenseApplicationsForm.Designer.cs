namespace DVLD.UI
{
    partial class ManageLocalDrivingLicenseApplicationsForm
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
            txtBFilterValue = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            cmboBFilters = new ReaLTaiizor.Controls.MaterialComboBox();
            bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            hopePictureBox1 = new ReaLTaiizor.Controls.HopePictureBox();
            grdVApplications = new ReaLTaiizor.Controls.PoisonDataGridView();
            bigLabel2 = new ReaLTaiizor.Controls.BigLabel();
            foreverClose1 = new ReaLTaiizor.Controls.ForeverClose();
            crownContextMenuStrip1 = new ReaLTaiizor.Controls.CrownContextMenuStrip();
            showApplicationDetailsToolStripMenuItem = new ToolStripMenuItem();
            deleteApplicationToolStripMenuItem = new ToolStripMenuItem();
            cancelApplicationToolStripMenuItem = new ToolStripMenuItem();
            scheduleTestToolStripMenuItem = new ToolStripMenuItem();
            scheduleVisionTestToolStripMenuItem = new ToolStripMenuItem();
            scheduleWrittenTestToolStripMenuItem = new ToolStripMenuItem();
            scheduleStreetTestToolStripMenuItem = new ToolStripMenuItem();
            issueDrivingLicenseFirstTimeToolStripMenuItem = new ToolStripMenuItem();
            showLicenseToolStripMenuItem = new ToolStripMenuItem();
            showDriverLicenseHistoryToolStripMenuItem = new ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)hopePictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grdVApplications).BeginInit();
            crownContextMenuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // txtBFilterValue
            // 
            txtBFilterValue.AnimateReadOnly = false;
            txtBFilterValue.AutoCompleteMode = AutoCompleteMode.None;
            txtBFilterValue.AutoCompleteSource = AutoCompleteSource.None;
            txtBFilterValue.BackgroundImageLayout = ImageLayout.None;
            txtBFilterValue.CharacterCasing = CharacterCasing.Normal;
            txtBFilterValue.Depth = 0;
            txtBFilterValue.Font = new Font("Microsoft Sans Serif", 16F, FontStyle.Regular, GraphicsUnit.Pixel);
            txtBFilterValue.HideSelection = true;
            txtBFilterValue.LeadingIcon = null;
            txtBFilterValue.Location = new Point(326, 81);
            txtBFilterValue.MaxLength = 32767;
            txtBFilterValue.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            txtBFilterValue.Name = "txtBFilterValue";
            txtBFilterValue.PasswordChar = '\0';
            txtBFilterValue.PrefixSuffixText = null;
            txtBFilterValue.ReadOnly = false;
            txtBFilterValue.RightToLeft = RightToLeft.No;
            txtBFilterValue.SelectedText = "";
            txtBFilterValue.SelectionLength = 0;
            txtBFilterValue.SelectionStart = 0;
            txtBFilterValue.ShortcutsEnabled = true;
            txtBFilterValue.Size = new Size(312, 48);
            txtBFilterValue.TabIndex = 46;
            txtBFilterValue.TabStop = false;
            txtBFilterValue.TextAlign = HorizontalAlignment.Left;
            txtBFilterValue.TrailingIcon = null;
            txtBFilterValue.UseSystemPasswordChar = false;
            // 
            // cmboBFilters
            // 
            cmboBFilters.AutoResize = false;
            cmboBFilters.BackColor = Color.FromArgb(255, 255, 255);
            cmboBFilters.Depth = 0;
            cmboBFilters.DrawMode = DrawMode.OwnerDrawVariable;
            cmboBFilters.DropDownHeight = 174;
            cmboBFilters.DropDownStyle = ComboBoxStyle.DropDownList;
            cmboBFilters.DropDownWidth = 121;
            cmboBFilters.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cmboBFilters.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cmboBFilters.FormattingEnabled = true;
            cmboBFilters.IntegralHeight = false;
            cmboBFilters.ItemHeight = 43;
            cmboBFilters.Location = new Point(118, 80);
            cmboBFilters.MaxDropDownItems = 4;
            cmboBFilters.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cmboBFilters.Name = "cmboBFilters";
            cmboBFilters.Size = new Size(189, 49);
            cmboBFilters.StartIndex = 0;
            cmboBFilters.TabIndex = 45;
            // 
            // bigLabel1
            // 
            bigLabel1.AutoSize = true;
            bigLabel1.BackColor = Color.Transparent;
            bigLabel1.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bigLabel1.ForeColor = Color.Black;
            bigLabel1.Location = new Point(12, 102);
            bigLabel1.Name = "bigLabel1";
            bigLabel1.Size = new Size(80, 27);
            bigLabel1.TabIndex = 44;
            bigLabel1.Text = "Filter By";
            // 
            // hopePictureBox1
            // 
            hopePictureBox1.BackColor = Color.FromArgb(192, 196, 204);
            hopePictureBox1.Image = Properties.Resources.add_icon_215758;
            hopePictureBox1.Location = new Point(697, 5);
            hopePictureBox1.Name = "hopePictureBox1";
            hopePictureBox1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            hopePictureBox1.Size = new Size(94, 54);
            hopePictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            hopePictureBox1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            hopePictureBox1.TabIndex = 43;
            hopePictureBox1.TabStop = false;
            hopePictureBox1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
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
            grdVApplications.Location = new Point(12, 152);
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
            grdVApplications.Size = new Size(1222, 456);
            grdVApplications.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Green;
            grdVApplications.TabIndex = 42;
            // 
            // bigLabel2
            // 
            bigLabel2.AutoSize = true;
            bigLabel2.BackColor = Color.Transparent;
            bigLabel2.Font = new Font("Arial Narrow", 25.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bigLabel2.ForeColor = Color.Black;
            bigLabel2.Location = new Point(12, 10);
            bigLabel2.Name = "bigLabel2";
            bigLabel2.Size = new Size(679, 49);
            bigLabel2.TabIndex = 41;
            bigLabel2.Text = "Manage Local Driving License Applications";
            // 
            // foreverClose1
            // 
            foreverClose1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            foreverClose1.BackColor = Color.White;
            foreverClose1.BaseColor = Color.FromArgb(45, 47, 49);
            foreverClose1.DefaultLocation = true;
            foreverClose1.DownColor = Color.FromArgb(30, 0, 0, 0);
            foreverClose1.Font = new Font("Marlett", 10F);
            foreverClose1.Location = new Point(1221, 16);
            foreverClose1.Name = "foreverClose1";
            foreverClose1.OverColor = Color.FromArgb(30, 255, 255, 255);
            foreverClose1.Size = new Size(18, 18);
            foreverClose1.TabIndex = 40;
            foreverClose1.Text = "foreverClose1";
            foreverClose1.TextColor = Color.FromArgb(243, 243, 243);
            // 
            // crownContextMenuStrip1
            // 
            crownContextMenuStrip1.BackColor = Color.White;
            crownContextMenuStrip1.Font = new Font("Arial Narrow", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            crownContextMenuStrip1.ForeColor = Color.FromArgb(220, 220, 220);
            crownContextMenuStrip1.ImageScalingSize = new Size(20, 20);
            crownContextMenuStrip1.Items.AddRange(new ToolStripItem[] { showApplicationDetailsToolStripMenuItem, deleteApplicationToolStripMenuItem, cancelApplicationToolStripMenuItem, scheduleTestToolStripMenuItem, issueDrivingLicenseFirstTimeToolStripMenuItem, showLicenseToolStripMenuItem, showDriverLicenseHistoryToolStripMenuItem });
            crownContextMenuStrip1.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;
            crownContextMenuStrip1.Name = "crownContextMenuStrip1";
            crownContextMenuStrip1.ShowImageMargin = false;
            crownContextMenuStrip1.Size = new Size(269, 186);
            crownContextMenuStrip1.Opening += crownContextMenuStrip1_Opening;
            // 
            // showApplicationDetailsToolStripMenuItem
            // 
            showApplicationDetailsToolStripMenuItem.BackColor = Color.FromArgb(60, 63, 65);
            showApplicationDetailsToolStripMenuItem.ForeColor = Color.FromArgb(220, 220, 220);
            showApplicationDetailsToolStripMenuItem.Name = "showApplicationDetailsToolStripMenuItem";
            showApplicationDetailsToolStripMenuItem.Size = new Size(268, 26);
            showApplicationDetailsToolStripMenuItem.Text = "Show Application Details";
            showApplicationDetailsToolStripMenuItem.Click += showApplicationDetailsToolStripMenuItem_Click;
            // 
            // deleteApplicationToolStripMenuItem
            // 
            deleteApplicationToolStripMenuItem.BackColor = Color.FromArgb(60, 63, 65);
            deleteApplicationToolStripMenuItem.ForeColor = Color.FromArgb(220, 220, 220);
            deleteApplicationToolStripMenuItem.Name = "deleteApplicationToolStripMenuItem";
            deleteApplicationToolStripMenuItem.Size = new Size(268, 26);
            deleteApplicationToolStripMenuItem.Text = "Delete Application";
            deleteApplicationToolStripMenuItem.Click += deleteApplicationToolStripMenuItem_Click;
            // 
            // cancelApplicationToolStripMenuItem
            // 
            cancelApplicationToolStripMenuItem.BackColor = Color.FromArgb(60, 63, 65);
            cancelApplicationToolStripMenuItem.ForeColor = Color.FromArgb(220, 220, 220);
            cancelApplicationToolStripMenuItem.Name = "cancelApplicationToolStripMenuItem";
            cancelApplicationToolStripMenuItem.Size = new Size(268, 26);
            cancelApplicationToolStripMenuItem.Text = "Cancel Application";
            cancelApplicationToolStripMenuItem.Click += cancelApplicationToolStripMenuItem_Click;
            // 
            // scheduleTestToolStripMenuItem
            // 
            scheduleTestToolStripMenuItem.BackColor = Color.FromArgb(60, 63, 65);
            scheduleTestToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { scheduleVisionTestToolStripMenuItem, scheduleWrittenTestToolStripMenuItem, scheduleStreetTestToolStripMenuItem });
            scheduleTestToolStripMenuItem.ForeColor = Color.FromArgb(220, 220, 220);
            scheduleTestToolStripMenuItem.Name = "scheduleTestToolStripMenuItem";
            scheduleTestToolStripMenuItem.Size = new Size(268, 26);
            scheduleTestToolStripMenuItem.Text = "Schedule Test";
            // 
            // scheduleVisionTestToolStripMenuItem
            // 
            scheduleVisionTestToolStripMenuItem.BackColor = Color.FromArgb(60, 63, 65);
            scheduleVisionTestToolStripMenuItem.ForeColor = Color.FromArgb(220, 220, 220);
            scheduleVisionTestToolStripMenuItem.Name = "scheduleVisionTestToolStripMenuItem";
            scheduleVisionTestToolStripMenuItem.Size = new Size(232, 26);
            scheduleVisionTestToolStripMenuItem.Text = "Schedule Vision Test";
            scheduleVisionTestToolStripMenuItem.Click += scheduleVisionTestToolStripMenuItem_Click;
            // 
            // scheduleWrittenTestToolStripMenuItem
            // 
            scheduleWrittenTestToolStripMenuItem.BackColor = Color.FromArgb(60, 63, 65);
            scheduleWrittenTestToolStripMenuItem.ForeColor = Color.FromArgb(220, 220, 220);
            scheduleWrittenTestToolStripMenuItem.Name = "scheduleWrittenTestToolStripMenuItem";
            scheduleWrittenTestToolStripMenuItem.Size = new Size(232, 26);
            scheduleWrittenTestToolStripMenuItem.Text = "Schedule Written Test";
            scheduleWrittenTestToolStripMenuItem.Click += scheduleWrittenTestToolStripMenuItem_Click;
            // 
            // scheduleStreetTestToolStripMenuItem
            // 
            scheduleStreetTestToolStripMenuItem.BackColor = Color.FromArgb(60, 63, 65);
            scheduleStreetTestToolStripMenuItem.ForeColor = Color.FromArgb(220, 220, 220);
            scheduleStreetTestToolStripMenuItem.Name = "scheduleStreetTestToolStripMenuItem";
            scheduleStreetTestToolStripMenuItem.Size = new Size(232, 26);
            scheduleStreetTestToolStripMenuItem.Text = "Schedule Street Test";
            scheduleStreetTestToolStripMenuItem.Click += scheduleStreetTestToolStripMenuItem_Click;
            // 
            // issueDrivingLicenseFirstTimeToolStripMenuItem
            // 
            issueDrivingLicenseFirstTimeToolStripMenuItem.BackColor = Color.FromArgb(60, 63, 65);
            issueDrivingLicenseFirstTimeToolStripMenuItem.ForeColor = Color.FromArgb(220, 220, 220);
            issueDrivingLicenseFirstTimeToolStripMenuItem.Name = "issueDrivingLicenseFirstTimeToolStripMenuItem";
            issueDrivingLicenseFirstTimeToolStripMenuItem.Size = new Size(268, 26);
            issueDrivingLicenseFirstTimeToolStripMenuItem.Text = "Issue Driving License (First Time)";
            issueDrivingLicenseFirstTimeToolStripMenuItem.Click += issueDrivingLicenseFirstTimeToolStripMenuItem_Click;
            // 
            // showLicenseToolStripMenuItem
            // 
            showLicenseToolStripMenuItem.BackColor = Color.FromArgb(60, 63, 65);
            showLicenseToolStripMenuItem.ForeColor = Color.FromArgb(220, 220, 220);
            showLicenseToolStripMenuItem.Name = "showLicenseToolStripMenuItem";
            showLicenseToolStripMenuItem.Size = new Size(268, 26);
            showLicenseToolStripMenuItem.Text = "Show License";
            showLicenseToolStripMenuItem.Click += showLicenseToolStripMenuItem_Click;
            // 
            // showDriverLicenseHistoryToolStripMenuItem
            // 
            showDriverLicenseHistoryToolStripMenuItem.BackColor = Color.FromArgb(60, 63, 65);
            showDriverLicenseHistoryToolStripMenuItem.ForeColor = Color.FromArgb(220, 220, 220);
            showDriverLicenseHistoryToolStripMenuItem.Name = "showDriverLicenseHistoryToolStripMenuItem";
            showDriverLicenseHistoryToolStripMenuItem.Size = new Size(268, 26);
            showDriverLicenseHistoryToolStripMenuItem.Text = "Show Driver License History";
            showDriverLicenseHistoryToolStripMenuItem.Click += showDriverLicenseHistoryToolStripMenuItem_Click;
            // 
            // ManageLocalDrivingLicenseApplicationsForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1251, 619);
            Controls.Add(txtBFilterValue);
            Controls.Add(cmboBFilters);
            Controls.Add(bigLabel1);
            Controls.Add(hopePictureBox1);
            Controls.Add(grdVApplications);
            Controls.Add(bigLabel2);
            Controls.Add(foreverClose1);
            Name = "ManageLocalDrivingLicenseApplicationsForm";
            Text = "ManageLocalDrivingLicenseApplicationsForm";
            Load += ManageLocalDrivingLicenseApplicationsForm_Load;
            ((System.ComponentModel.ISupportInitialize)hopePictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)grdVApplications).EndInit();
            crownContextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtBFilterValue;
        private ReaLTaiizor.Controls.MaterialComboBox cmboBFilters;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private ReaLTaiizor.Controls.HopePictureBox hopePictureBox1;
        private ReaLTaiizor.Controls.PoisonDataGridView grdVApplications;
        private ReaLTaiizor.Controls.BigLabel bigLabel2;
        private ReaLTaiizor.Controls.ForeverClose foreverClose1;
        private ReaLTaiizor.Controls.CrownContextMenuStrip crownContextMenuStrip1;
        private ToolStripMenuItem showApplicationDetailsToolStripMenuItem;
        private ToolStripMenuItem deleteApplicationToolStripMenuItem;
        private ToolStripMenuItem cancelApplicationToolStripMenuItem;
        private ToolStripMenuItem scheduleTestToolStripMenuItem;
        private ToolStripMenuItem issueDrivingLicenseFirstTimeToolStripMenuItem;
        private ToolStripMenuItem showLicenseToolStripMenuItem;
        private ToolStripMenuItem showDriverLicenseHistoryToolStripMenuItem;
        private ToolStripMenuItem scheduleVisionTestToolStripMenuItem;
        private ToolStripMenuItem scheduleWrittenTestToolStripMenuItem;
        private ToolStripMenuItem scheduleStreetTestToolStripMenuItem;
    }
}