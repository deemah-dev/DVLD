namespace DVLD.UI
{
    partial class ManageSystemUsersForm
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
            bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            btnAdd = new ReaLTaiizor.Controls.HopePictureBox();
            grdVUsersInformation = new ReaLTaiizor.Controls.PoisonDataGridView();
            crownContextMenuStrip1 = new ReaLTaiizor.Controls.CrownContextMenuStrip();
            showUserDetailsToolStripMenuItem = new ToolStripMenuItem();
            updatePasswordToolStripMenuItem = new ToolStripMenuItem();
            updateActivetionToolStripMenuItem = new ToolStripMenuItem();
            deleteUserToolStripMenuItem = new ToolStripMenuItem();
            bigLabel2 = new ReaLTaiizor.Controls.BigLabel();
            foreverClose1 = new ReaLTaiizor.Controls.ForeverClose();
            cmboBFilters = new ReaLTaiizor.Controls.MaterialComboBox();
            cmboBActivationFilterValues = new ReaLTaiizor.Controls.MaterialComboBox();
            ((System.ComponentModel.ISupportInitialize)btnAdd).BeginInit();
            ((System.ComponentModel.ISupportInitialize)grdVUsersInformation).BeginInit();
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
            txtBFilterValue.TabIndex = 44;
            txtBFilterValue.TabStop = false;
            txtBFilterValue.TextAlign = HorizontalAlignment.Left;
            txtBFilterValue.TrailingIcon = null;
            txtBFilterValue.UseSystemPasswordChar = false;
            txtBFilterValue.TextChanged += txtBFilterValue_TextChanged;
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
            bigLabel1.TabIndex = 43;
            bigLabel1.Text = "Filter By";
            // 
            // btnAdd
            // 
            btnAdd.BackColor = Color.FromArgb(192, 196, 204);
            btnAdd.Image = Properties.Resources.add_icon_215758;
            btnAdd.Location = new Point(388, 4);
            btnAdd.Name = "btnAdd";
            btnAdd.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            btnAdd.Size = new Size(94, 54);
            btnAdd.SizeMode = PictureBoxSizeMode.StretchImage;
            btnAdd.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnAdd.TabIndex = 42;
            btnAdd.TabStop = false;
            btnAdd.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnAdd.Click += btnAdd_Click;
            // 
            // grdVUsersInformation
            // 
            grdVUsersInformation.AllowUserToAddRows = false;
            grdVUsersInformation.AllowUserToDeleteRows = false;
            grdVUsersInformation.AllowUserToOrderColumns = true;
            grdVUsersInformation.AllowUserToResizeRows = false;
            dataGridViewCellStyle1.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grdVUsersInformation.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            grdVUsersInformation.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            grdVUsersInformation.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.AllCells;
            grdVUsersInformation.BackgroundColor = Color.FromArgb(255, 255, 255);
            grdVUsersInformation.BorderStyle = BorderStyle.None;
            grdVUsersInformation.CellBorderStyle = DataGridViewCellBorderStyle.None;
            grdVUsersInformation.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(0, 177, 89);
            dataGridViewCellStyle2.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(0, 208, 104);
            dataGridViewCellStyle2.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            grdVUsersInformation.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            grdVUsersInformation.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            grdVUsersInformation.ContextMenuStrip = crownContextMenuStrip1;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle3.Font = new Font("Arial Narrow", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.FromArgb(136, 136, 136);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(0, 208, 104);
            dataGridViewCellStyle3.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            grdVUsersInformation.DefaultCellStyle = dataGridViewCellStyle3;
            grdVUsersInformation.EnableHeadersVisualStyles = false;
            grdVUsersInformation.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            grdVUsersInformation.GridColor = Color.FromArgb(255, 255, 255);
            grdVUsersInformation.Location = new Point(12, 151);
            grdVUsersInformation.MultiSelect = false;
            grdVUsersInformation.Name = "grdVUsersInformation";
            grdVUsersInformation.ReadOnly = true;
            grdVUsersInformation.RowHeadersBorderStyle = DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(0, 177, 89);
            dataGridViewCellStyle4.Font = new Font("Segoe UI", 11F, FontStyle.Regular, GraphicsUnit.Pixel);
            dataGridViewCellStyle4.ForeColor = Color.FromArgb(255, 255, 255);
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(0, 208, 104);
            dataGridViewCellStyle4.SelectionForeColor = Color.FromArgb(17, 17, 17);
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            grdVUsersInformation.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            grdVUsersInformation.RowHeadersWidth = 51;
            grdVUsersInformation.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.DisableResizing;
            dataGridViewCellStyle5.Font = new Font("Microsoft Sans Serif", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            grdVUsersInformation.RowsDefaultCellStyle = dataGridViewCellStyle5;
            grdVUsersInformation.ScrollBars = ScrollBars.Vertical;
            grdVUsersInformation.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            grdVUsersInformation.Size = new Size(880, 456);
            grdVUsersInformation.Style = ReaLTaiizor.Enum.Poison.ColorStyle.Green;
            grdVUsersInformation.TabIndex = 41;
            // 
            // crownContextMenuStrip1
            // 
            crownContextMenuStrip1.BackColor = Color.White;
            crownContextMenuStrip1.Font = new Font("Arial Narrow", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            crownContextMenuStrip1.ForeColor = Color.FromArgb(220, 220, 220);
            crownContextMenuStrip1.ImageScalingSize = new Size(20, 20);
            crownContextMenuStrip1.Items.AddRange(new ToolStripItem[] { showUserDetailsToolStripMenuItem, updatePasswordToolStripMenuItem, updateActivetionToolStripMenuItem, deleteUserToolStripMenuItem });
            crownContextMenuStrip1.LayoutStyle = ToolStripLayoutStyle.HorizontalStackWithOverflow;
            crownContextMenuStrip1.Name = "crownContextMenuStrip1";
            crownContextMenuStrip1.ShowImageMargin = false;
            crownContextMenuStrip1.Size = new Size(175, 108);
            // 
            // showUserDetailsToolStripMenuItem
            // 
            showUserDetailsToolStripMenuItem.BackColor = Color.FromArgb(60, 63, 65);
            showUserDetailsToolStripMenuItem.ForeColor = Color.FromArgb(220, 220, 220);
            showUserDetailsToolStripMenuItem.Name = "showUserDetailsToolStripMenuItem";
            showUserDetailsToolStripMenuItem.Size = new Size(174, 26);
            showUserDetailsToolStripMenuItem.Text = "Show User Details";
            showUserDetailsToolStripMenuItem.Click += showUserDetailsToolStripMenuItem_Click;
            // 
            // updatePasswordToolStripMenuItem
            // 
            updatePasswordToolStripMenuItem.BackColor = Color.FromArgb(60, 63, 65);
            updatePasswordToolStripMenuItem.ForeColor = Color.FromArgb(220, 220, 220);
            updatePasswordToolStripMenuItem.Name = "updatePasswordToolStripMenuItem";
            updatePasswordToolStripMenuItem.Size = new Size(174, 26);
            updatePasswordToolStripMenuItem.Text = "Update Password";
            updatePasswordToolStripMenuItem.Click += updatePasswordToolStripMenuItem_Click;
            // 
            // updateActivetionToolStripMenuItem
            // 
            updateActivetionToolStripMenuItem.BackColor = Color.FromArgb(60, 63, 65);
            updateActivetionToolStripMenuItem.ForeColor = Color.FromArgb(220, 220, 220);
            updateActivetionToolStripMenuItem.Name = "updateActivetionToolStripMenuItem";
            updateActivetionToolStripMenuItem.Size = new Size(174, 26);
            updateActivetionToolStripMenuItem.Text = "Update Activetion";
            updateActivetionToolStripMenuItem.Click += updateActivetionToolStripMenuItem_Click;
            // 
            // deleteUserToolStripMenuItem
            // 
            deleteUserToolStripMenuItem.BackColor = Color.FromArgb(60, 63, 65);
            deleteUserToolStripMenuItem.ForeColor = Color.FromArgb(220, 220, 220);
            deleteUserToolStripMenuItem.Name = "deleteUserToolStripMenuItem";
            deleteUserToolStripMenuItem.Size = new Size(174, 26);
            deleteUserToolStripMenuItem.Text = "Delete User";
            deleteUserToolStripMenuItem.Click += deleteUserToolStripMenuItem_Click;
            // 
            // bigLabel2
            // 
            bigLabel2.AutoSize = true;
            bigLabel2.BackColor = Color.Transparent;
            bigLabel2.Font = new Font("Arial Narrow", 25.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bigLabel2.ForeColor = Color.Black;
            bigLabel2.Location = new Point(12, 9);
            bigLabel2.Name = "bigLabel2";
            bigLabel2.Size = new Size(370, 49);
            bigLabel2.TabIndex = 40;
            bigLabel2.Text = "Manage System Users";
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
            foreverClose1.TabIndex = 39;
            foreverClose1.Text = "foreverClose1";
            foreverClose1.TextColor = Color.FromArgb(243, 243, 243);
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
            cmboBFilters.Location = new Point(98, 79);
            cmboBFilters.MaxDropDownItems = 4;
            cmboBFilters.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cmboBFilters.Name = "cmboBFilters";
            cmboBFilters.Size = new Size(189, 49);
            cmboBFilters.StartIndex = 0;
            cmboBFilters.TabIndex = 46;
            cmboBFilters.SelectedIndexChanged += cmboBFilters_SelectedIndexChanged;
            // 
            // cmboBActivationFilterValues
            // 
            cmboBActivationFilterValues.AutoResize = false;
            cmboBActivationFilterValues.BackColor = Color.FromArgb(255, 255, 255);
            cmboBActivationFilterValues.Depth = 0;
            cmboBActivationFilterValues.DrawMode = DrawMode.OwnerDrawVariable;
            cmboBActivationFilterValues.DropDownHeight = 174;
            cmboBActivationFilterValues.DropDownStyle = ComboBoxStyle.DropDownList;
            cmboBActivationFilterValues.DropDownWidth = 121;
            cmboBActivationFilterValues.Font = new Font("Microsoft Sans Serif", 14F, FontStyle.Bold, GraphicsUnit.Pixel);
            cmboBActivationFilterValues.ForeColor = Color.FromArgb(222, 0, 0, 0);
            cmboBActivationFilterValues.FormattingEnabled = true;
            cmboBActivationFilterValues.IntegralHeight = false;
            cmboBActivationFilterValues.ItemHeight = 43;
            cmboBActivationFilterValues.Location = new Point(326, 79);
            cmboBActivationFilterValues.MaxDropDownItems = 4;
            cmboBActivationFilterValues.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cmboBActivationFilterValues.Name = "cmboBActivationFilterValues";
            cmboBActivationFilterValues.Size = new Size(189, 49);
            cmboBActivationFilterValues.StartIndex = 0;
            cmboBActivationFilterValues.TabIndex = 47;
            cmboBActivationFilterValues.Visible = false;
            cmboBActivationFilterValues.SelectedIndexChanged += cmboBActivationFilterValues_SelectedIndexChanged;
            // 
            // ManageSystemUsersForm
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(906, 619);
            Controls.Add(cmboBActivationFilterValues);
            Controls.Add(cmboBFilters);
            Controls.Add(txtBFilterValue);
            Controls.Add(bigLabel1);
            Controls.Add(btnAdd);
            Controls.Add(grdVUsersInformation);
            Controls.Add(bigLabel2);
            Controls.Add(foreverClose1);
            Name = "ManageSystemUsersForm";
            Text = "ManageSystemUsersForm";
            Load += ManageSystemUsersForm_Load;
            ((System.ComponentModel.ISupportInitialize)btnAdd).EndInit();
            ((System.ComponentModel.ISupportInitialize)grdVUsersInformation).EndInit();
            crownContextMenuStrip1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtBFilterValue;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private ReaLTaiizor.Controls.HopePictureBox btnAdd;
        private ReaLTaiizor.Controls.PoisonDataGridView grdVUsersInformation;
        private ReaLTaiizor.Controls.BigLabel bigLabel2;
        private ReaLTaiizor.Controls.ForeverClose foreverClose1;
        private ReaLTaiizor.Controls.MaterialComboBox cmboBFilters;
        private ReaLTaiizor.Controls.MaterialComboBox cmboBActivationFilterValues;
        private ReaLTaiizor.Controls.CrownContextMenuStrip crownContextMenuStrip1;
        private ToolStripMenuItem showUserDetailsToolStripMenuItem;
        private ToolStripMenuItem updatePasswordToolStripMenuItem;
        private ToolStripMenuItem updateActivetionToolStripMenuItem;
        private ToolStripMenuItem deleteUserToolStripMenuItem;
    }
}