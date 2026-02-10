namespace DVLD.UI
{
    partial class ManagePeopleForm
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
            bigLabel2 = new ReaLTaiizor.Controls.BigLabel();
            foreverClose1 = new ReaLTaiizor.Controls.ForeverClose();
            grdVPeopleInformation = new ReaLTaiizor.Controls.PoisonDataGridView();
            crownContextMenuStrip1 = new ReaLTaiizor.Controls.CrownContextMenuStrip();
            showPersonInformationToolStripMenuItem = new ToolStripMenuItem();
            editPersonInformationToolStripMenuItem1 = new ToolStripMenuItem();
            deletePersonToolStripMenuItem1 = new ToolStripMenuItem();
            hopePictureBox1 = new ReaLTaiizor.Controls.HopePictureBox();
            bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            cmboBFilters = new ReaLTaiizor.Controls.MaterialComboBox();
            txtBFilterValue = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            cmboBGenderFilterValues = new ReaLTaiizor.Controls.MaterialComboBox();
            ((System.ComponentModel.ISupportInitialize)grdVPeopleInformation).BeginInit();
            crownContextMenuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)hopePictureBox1).BeginInit();
            SuspendLayout();
            // 
            // bigLabel2
            // 
            bigLabel2.AutoSize = true;
            bigLabel2.BackColor = Color.Transparent;
            bigLabel2.Font = new Font("Arial Narrow", 25.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bigLabel2.ForeColor = Color.Black;
            bigLabel2.Location = new Point(12, 9);
            bigLabel2.Name = "bigLabel2";
            bigLabel2.Size = new Size(446, 49);
            bigLabel2.TabIndex = 19;
            bigLabel2.Text = "Manage People Information";
            // 
            // foreverClose1
            // 
            foreverClose1.Anchor = AnchorStyles.Top | AnchorStyles.Right;
            foreverClose1.BackColor = Color.White;
            foreverClose1.BaseColor = Color.FromArgb(45, 47, 49);
            foreverClose1.DefaultLocation = true;
            foreverClose1.DownColor = Color.FromArgb(30, 0, 0, 0);
            foreverClose1.Font = new Font("Marlett", 10F);
            foreverClose1.Location = new Point(1080, 16);
            foreverClose1.Name = "foreverClose1";
            foreverClose1.OverColor = Color.FromArgb(30, 255, 255, 255);
            foreverClose1.Size = new Size(18, 18);
            foreverClose1.TabIndex = 18;
            foreverClose1.Text = "foreverClose1";
            foreverClose1.TextColor = Color.FromArgb(243, 243, 243);
            // 
            // grdVPeopleInformation
            // 
            grdVPeopleInformation.AllowUserToAddRows = false;
            grdVPeopleInformation.AllowUserToDeleteRows = false;
            grdVPeopleInformation.AllowUserToOrderColumns = true;
            grdVPeopleInformation.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grdVPeopleInformation.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            grdVPeopleInformation.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grdVPeopleInformation.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            grdVPeopleInformation.BackgroundColor = Color.FromArgb(255, 255, 255);
            grdVPeopleInformation.BorderStyle = BorderStyle.None;
            grdVPeopleInformation.CellBorderStyle = DataGridViewCellBorderStyle.None;
            grdVPeopleInformation.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(0, 177, 89);
            dataGridViewCellStyle2.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 208, 104);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            grdVPeopleInformation.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            grdVPeopleInformation.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdVPeopleInformation.ContextMenuStrip = crownContextMenuStrip1;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle3.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(136, 136, 136);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(0, 208, 104);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            grdVPeopleInformation.DefaultCellStyle = dataGridViewCellStyle3;
            grdVPeopleInformation.EnableHeadersVisualStyles = false;
            grdVPeopleInformation.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            grdVPeopleInformation.GridColor = Color.FromArgb(255, 255, 255);
            grdVPeopleInformation.Location = new Point(12, 151);
            grdVPeopleInformation.MultiSelect = false;
            grdVPeopleInformation.Name = "grdVPeopleInformation";
            grdVPeopleInformation.ReadOnly = true;
            grdVPeopleInformation.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(0, 177, 89);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(0, 208, 104);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            grdVPeopleInformation.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            grdVPeopleInformation.RowHeadersWidth = 51;
            grdVPeopleInformation.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grdVPeopleInformation.RowsDefaultCellStyle = dataGridViewCellStyle5;
            grdVPeopleInformation.ScrollBars = ScrollBars.Vertical;
            grdVPeopleInformation.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdVPeopleInformation.Size = new Size(1083, 456);
            grdVPeopleInformation.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Green;
            grdVPeopleInformation.TabIndex = 20;
            // 
            // crownContextMenuStrip1
            // 
            crownContextMenuStrip1.BackColor = Color.White;
            crownContextMenuStrip1.Font = new Font("Arial Narrow", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            crownContextMenuStrip1.ForeColor = Color.FromArgb(220, 220, 220);
            crownContextMenuStrip1.ImageScalingSize = new Size(20, 20);
            crownContextMenuStrip1.Items.AddRange(new ToolStripItem[] { showPersonInformationToolStripMenuItem, editPersonInformationToolStripMenuItem1, deletePersonToolStripMenuItem1 });
            crownContextMenuStrip1.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;
            crownContextMenuStrip1.Name = "crownContextMenuStrip1";
            crownContextMenuStrip1.ShowImageMargin = false;
            crownContextMenuStrip1.Size = new Size(217, 82);
            // 
            // showPersonInformationToolStripMenuItem
            // 
            showPersonInformationToolStripMenuItem.BackColor = Color.FromArgb(60, 63, 65);
            showPersonInformationToolStripMenuItem.ForeColor = Color.FromArgb(220, 220, 220);
            showPersonInformationToolStripMenuItem.Name = "showPersonInformationToolStripMenuItem";
            showPersonInformationToolStripMenuItem.Size = new Size(216, 26);
            showPersonInformationToolStripMenuItem.Text = "Show Person Information";
            showPersonInformationToolStripMenuItem.Click += showPersonInformationToolStripMenuItem_Click;
            // 
            // editPersonInformationToolStripMenuItem1
            // 
            editPersonInformationToolStripMenuItem1.BackColor = Color.FromArgb(60, 63, 65);
            editPersonInformationToolStripMenuItem1.ForeColor = Color.FromArgb(220, 220, 220);
            editPersonInformationToolStripMenuItem1.Name = "editPersonInformationToolStripMenuItem1";
            editPersonInformationToolStripMenuItem1.Size = new Size(216, 26);
            editPersonInformationToolStripMenuItem1.Text = "Edit Person Information";
            editPersonInformationToolStripMenuItem1.Click += editPersonInformationToolStripMenuItem1_Click;
            // 
            // deletePersonToolStripMenuItem1
            // 
            deletePersonToolStripMenuItem1.BackColor = Color.FromArgb(60, 63, 65);
            deletePersonToolStripMenuItem1.ForeColor = Color.FromArgb(220, 220, 220);
            deletePersonToolStripMenuItem1.Name = "deletePersonToolStripMenuItem1";
            deletePersonToolStripMenuItem1.Size = new Size(216, 26);
            deletePersonToolStripMenuItem1.Text = "Delete Person";
            deletePersonToolStripMenuItem1.Click += deletePersonToolStripMenuItem1_Click;
            // 
            // hopePictureBox1
            // 
            hopePictureBox1.BackColor = Color.FromArgb(192, 196, 204);
            hopePictureBox1.Image = Properties.Resources.AddPersonIcon;
            hopePictureBox1.Location = new Point(464, 12);
            hopePictureBox1.Name = "hopePictureBox1";
            hopePictureBox1.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            hopePictureBox1.Size = new Size(94, 54);
            hopePictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            hopePictureBox1.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            hopePictureBox1.TabIndex = 34;
            hopePictureBox1.TabStop = false;
            hopePictureBox1.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            hopePictureBox1.Click += btnAddPerson_Click;
            // 
            // bigLabel1
            // 
            bigLabel1.AutoSize = true;
            bigLabel1.BackColor = Color.Transparent;
            bigLabel1.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bigLabel1.ForeColor = Color.Black;
            bigLabel1.Location = new Point(12, 101);
            bigLabel1.Name = "bigLabel1";
            bigLabel1.Size = new Size(80, 27);
            bigLabel1.TabIndex = 35;
            bigLabel1.Text = "Filter By";
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
            cmboBFilters.Location = new Point(118, 79);
            cmboBFilters.MaxDropDownItems = 4;
            cmboBFilters.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cmboBFilters.Name = "cmboBFilters";
            cmboBFilters.Size = new Size(189, 49);
            cmboBFilters.StartIndex = 0;
            cmboBFilters.TabIndex = 36;
            cmboBFilters.SelectedIndexChanged += cmboBFilters_SelectedIndexChanged;
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
            txtBFilterValue.Location = new Point(326, 80);
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
            txtBFilterValue.TabIndex = 37;
            txtBFilterValue.TabStop = false;
            txtBFilterValue.TextAlign = HorizontalAlignment.Left;
            txtBFilterValue.TrailingIcon = null;
            txtBFilterValue.UseSystemPasswordChar = false;
            txtBFilterValue.TextChanged += txtBFilterValue_TextChanged;
            // 
            // cmboBGenderFilterValues
            // 
            cmboBGenderFilterValues.AutoResize = false;
            cmboBGenderFilterValues.BackColor = Color.FromArgb(255, 255, 255);
            cmboBGenderFilterValues.Depth = 0;
            cmboBGenderFilterValues.DrawMode = DrawMode.OwnerDrawVariable;
            cmboBGenderFilterValues.DropDownHeight = 174;
            cmboBGenderFilterValues.DropDownStyle = ComboBoxStyle.DropDownList;
            cmboBGenderFilterValues.DropDownWidth = 121;
            cmboBGenderFilterValues.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cmboBGenderFilterValues.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cmboBGenderFilterValues.FormattingEnabled = true;
            cmboBGenderFilterValues.IntegralHeight = false;
            cmboBGenderFilterValues.ItemHeight = 43;
            cmboBGenderFilterValues.Location = new Point(326, 80);
            cmboBGenderFilterValues.MaxDropDownItems = 4;
            cmboBGenderFilterValues.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cmboBGenderFilterValues.Name = "cmboBGenderFilterValues";
            cmboBGenderFilterValues.Size = new Size(189, 49);
            cmboBGenderFilterValues.StartIndex = 0;
            cmboBGenderFilterValues.TabIndex = 39;
            cmboBGenderFilterValues.Visible = false;
            cmboBGenderFilterValues.SelectedIndexChanged += cmboBGenderFilterValues_SelectedIndexChanged;
            // 
            // ManagePeopleForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1110, 619);
            Controls.Add(cmboBGenderFilterValues);
            Controls.Add(txtBFilterValue);
            Controls.Add(cmboBFilters);
            Controls.Add(bigLabel1);
            Controls.Add(hopePictureBox1);
            Controls.Add(grdVPeopleInformation);
            Controls.Add(bigLabel2);
            Controls.Add(foreverClose1);
            Name = "ManagePeopleForm";
            Text = "ManagePeopleForm";
            Load += ManagePeopleForm_Load;
            ((System.ComponentModel.ISupportInitialize)grdVPeopleInformation).EndInit();
            crownContextMenuStrip1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)hopePictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.BigLabel bigLabel2;
        private ReaLTaiizor.Controls.ForeverClose foreverClose1;
        private ReaLTaiizor.Controls.PoisonDataGridView grdVPeopleInformation;
        private ReaLTaiizor.Controls.HopePictureBox hopePictureBox1;
        private ReaLTaiizor.Controls.CrownContextMenuStrip crownContextMenuStrip1;
        private ToolStripMenuItem showPersonInformationToolStripMenuItem;
        private ToolStripMenuItem editPersonInformationToolStripMenuItem1;
        private ToolStripMenuItem deletePersonToolStripMenuItem1;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private ReaLTaiizor.Controls.MaterialComboBox cmboBFilters;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtBFilterValue;
        private ReaLTaiizor.Controls.MaterialComboBox cmboBGenderFilterValues;
    }
}