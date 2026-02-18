namespace DVLD.UI
{
    partial class ManageDriversForm
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
            cmboBFilters = new ReaLTaiizor.Controls.MaterialComboBox();
            txtBFilterValue = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            grdVDrivers = new ReaLTaiizor.Controls.PoisonDataGridView();
            crownContextMenuStrip1 = new ReaLTaiizor.Controls.CrownContextMenuStrip();
            showPersonDetailsToolStripMenuItem = new ToolStripMenuItem();
            issueInternationalLicenseToolStripMenuItem = new ToolStripMenuItem();
            showDriverLicenseHistoryToolStripMenuItem = new ToolStripMenuItem();
            bigLabel2 = new ReaLTaiizor.Controls.BigLabel();
            foreverClose1 = new ReaLTaiizor.Controls.ForeverClose();
            ((System.ComponentModel.ISupportInitialize)grdVDrivers).BeginInit();
            crownContextMenuStrip1.SuspendLayout();
            SuspendLayout();
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
            cmboBFilters.Location = new Point(98, 83);
            cmboBFilters.MaxDropDownItems = 4;
            cmboBFilters.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cmboBFilters.Name = "cmboBFilters";
            cmboBFilters.Size = new Size(189, 49);
            cmboBFilters.StartIndex = 0;
            cmboBFilters.TabIndex = 54;
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
            txtBFilterValue.Location = new Point(326, 84);
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
            txtBFilterValue.TabIndex = 53;
            txtBFilterValue.TabStop = false;
            txtBFilterValue.TextAlign = HorizontalAlignment.Left;
            txtBFilterValue.TrailingIcon = null;
            txtBFilterValue.UseSystemPasswordChar = false;
            // 
            // bigLabel1
            // 
            bigLabel1.AutoSize = true;
            bigLabel1.BackColor = Color.Transparent;
            bigLabel1.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bigLabel1.ForeColor = Color.Black;
            bigLabel1.Location = new Point(12, 105);
            bigLabel1.Name = "bigLabel1";
            bigLabel1.Size = new Size(80, 27);
            bigLabel1.TabIndex = 52;
            bigLabel1.Text = "Filter By";
            // 
            // grdVDrivers
            // 
            grdVDrivers.AllowUserToAddRows = false;
            grdVDrivers.AllowUserToDeleteRows = false;
            grdVDrivers.AllowUserToOrderColumns = true;
            grdVDrivers.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grdVDrivers.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            grdVDrivers.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grdVDrivers.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            grdVDrivers.BackgroundColor = Color.FromArgb(255, 255, 255);
            grdVDrivers.BorderStyle = BorderStyle.None;
            grdVDrivers.CellBorderStyle = DataGridViewCellBorderStyle.None;
            grdVDrivers.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(0, 177, 89);
            dataGridViewCellStyle2.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 208, 104);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            grdVDrivers.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            grdVDrivers.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdVDrivers.ContextMenuStrip = crownContextMenuStrip1;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle3.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(136, 136, 136);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(0, 208, 104);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            grdVDrivers.DefaultCellStyle = dataGridViewCellStyle3;
            grdVDrivers.EnableHeadersVisualStyles = false;
            grdVDrivers.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            grdVDrivers.GridColor = Color.FromArgb(255, 255, 255);
            grdVDrivers.Location = new Point(12, 155);
            grdVDrivers.MultiSelect = false;
            grdVDrivers.Name = "grdVDrivers";
            grdVDrivers.ReadOnly = true;
            grdVDrivers.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(0, 177, 89);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(0, 208, 104);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            grdVDrivers.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            grdVDrivers.RowHeadersWidth = 51;
            grdVDrivers.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grdVDrivers.RowsDefaultCellStyle = dataGridViewCellStyle5;
            grdVDrivers.ScrollBars = ScrollBars.Vertical;
            grdVDrivers.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdVDrivers.Size = new Size(880, 456);
            grdVDrivers.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Green;
            grdVDrivers.TabIndex = 50;
            // 
            // crownContextMenuStrip1
            // 
            crownContextMenuStrip1.BackColor = Color.White;
            crownContextMenuStrip1.Font = new Font("Arial Narrow", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            crownContextMenuStrip1.ForeColor = Color.FromArgb(220, 220, 220);
            crownContextMenuStrip1.ImageScalingSize = new Size(20, 20);
            crownContextMenuStrip1.Items.AddRange(new ToolStripItem[] { showPersonDetailsToolStripMenuItem, issueInternationalLicenseToolStripMenuItem, showDriverLicenseHistoryToolStripMenuItem });
            crownContextMenuStrip1.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;
            crownContextMenuStrip1.Name = "crownContextMenuStrip1";
            crownContextMenuStrip1.ShowImageMargin = false;
            crownContextMenuStrip1.Size = new Size(237, 110);
            // 
            // showPersonDetailsToolStripMenuItem
            // 
            showPersonDetailsToolStripMenuItem.BackColor = Color.FromArgb(60, 63, 65);
            showPersonDetailsToolStripMenuItem.ForeColor = Color.FromArgb(220, 220, 220);
            showPersonDetailsToolStripMenuItem.Name = "showPersonDetailsToolStripMenuItem";
            showPersonDetailsToolStripMenuItem.Size = new Size(236, 26);
            showPersonDetailsToolStripMenuItem.Text = "Show Person Details";
            showPersonDetailsToolStripMenuItem.Click += showPersonDetailsToolStripMenuItem_Click;
            // 
            // issueInternationalLicenseToolStripMenuItem
            // 
            issueInternationalLicenseToolStripMenuItem.BackColor = Color.FromArgb(60, 63, 65);
            issueInternationalLicenseToolStripMenuItem.ForeColor = Color.FromArgb(220, 220, 220);
            issueInternationalLicenseToolStripMenuItem.Name = "issueInternationalLicenseToolStripMenuItem";
            issueInternationalLicenseToolStripMenuItem.Size = new Size(236, 26);
            issueInternationalLicenseToolStripMenuItem.Text = "Issue International License";
            issueInternationalLicenseToolStripMenuItem.Click += issueInternationalLicenseToolStripMenuItem_Click;
            // 
            // showDriverLicenseHistoryToolStripMenuItem
            // 
            showDriverLicenseHistoryToolStripMenuItem.BackColor = Color.FromArgb(60, 63, 65);
            showDriverLicenseHistoryToolStripMenuItem.ForeColor = Color.FromArgb(220, 220, 220);
            showDriverLicenseHistoryToolStripMenuItem.Name = "showDriverLicenseHistoryToolStripMenuItem";
            showDriverLicenseHistoryToolStripMenuItem.Size = new Size(236, 26);
            showDriverLicenseHistoryToolStripMenuItem.Text = "Show Driver License History";
            showDriverLicenseHistoryToolStripMenuItem.Click += showDriverLicenseHistoryToolStripMenuItem_Click;
            // 
            // bigLabel2
            // 
            bigLabel2.AutoSize = true;
            bigLabel2.BackColor = Color.Transparent;
            bigLabel2.Font = new Font("Arial Narrow", 25.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bigLabel2.ForeColor = Color.Black;
            bigLabel2.Location = new Point(12, 13);
            bigLabel2.Name = "bigLabel2";
            bigLabel2.Size = new Size(264, 49);
            bigLabel2.TabIndex = 49;
            bigLabel2.Text = "Manage Drivers";
            // 
            // foreverClose1
            // 
            foreverClose1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            foreverClose1.BackColor = Color.White;
            foreverClose1.BaseColor = Color.FromArgb(45, 47, 49);
            foreverClose1.DefaultLocation = true;
            foreverClose1.DownColor = Color.FromArgb(30, 0, 0, 0);
            foreverClose1.Font = new Font("Marlett", 10F);
            foreverClose1.Location = new Point(876, 16);
            foreverClose1.Name = "foreverClose1";
            foreverClose1.OverColor = Color.FromArgb(30, 255, 255, 255);
            foreverClose1.Size = new Size(18, 18);
            foreverClose1.TabIndex = 48;
            foreverClose1.Text = "foreverClose1";
            foreverClose1.TextColor = Color.FromArgb(243, 243, 243);
            // 
            // ManageDriversForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(906, 619);
            Controls.Add(cmboBFilters);
            Controls.Add(txtBFilterValue);
            Controls.Add(bigLabel1);
            Controls.Add(grdVDrivers);
            Controls.Add(bigLabel2);
            Controls.Add(foreverClose1);
            Name = "ManageDriversForm";
            Text = "ManageDriversForm";
            Load += ManageDriversForm_Load;
            ((System.ComponentModel.ISupportInitialize)grdVDrivers).EndInit();
            crownContextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialComboBox cmboBFilters;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtBFilterValue;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private ReaLTaiizor.Controls.PoisonDataGridView grdVDrivers;
        private ReaLTaiizor.Controls.BigLabel bigLabel2;
        private ReaLTaiizor.Controls.ForeverClose foreverClose1;
        private ReaLTaiizor.Controls.CrownContextMenuStrip crownContextMenuStrip1;
        private ToolStripMenuItem showPersonDetailsToolStripMenuItem;
        private ToolStripMenuItem issueInternationalLicenseToolStripMenuItem;
        private ToolStripMenuItem showDriverLicenseHistoryToolStripMenuItem;
    }
}