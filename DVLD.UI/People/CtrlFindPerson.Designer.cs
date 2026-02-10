namespace DVLD.UI
{
    partial class CtrlFindPerson
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
            txtBFilterValue = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            cmboBFilters = new ReaLTaiizor.Controls.MaterialComboBox();
            bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            btnAddPerson = new ReaLTaiizor.Controls.HopePictureBox();
            ctrlPersonInformation1 = new CtrlPersonInformation();
            ((System.ComponentModel.ISupportInitialize)btnAddPerson).BeginInit();
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
            txtBFilterValue.LeaveOnEnterKey = true;
            txtBFilterValue.Location = new Point(317, 15);
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
            txtBFilterValue.TabIndex = 42;
            txtBFilterValue.TabStop = false;
            txtBFilterValue.TextAlign = HorizontalAlignment.Left;
            txtBFilterValue.TrailingIcon = null;
            txtBFilterValue.UseSystemPasswordChar = false;
            txtBFilterValue.TextChanged += txtBFilterValue_TextChanged;
            txtBFilterValue.Validating += txtBFilterValue_Validating;
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
            cmboBFilters.Location = new Point(109, 14);
            cmboBFilters.MaxDropDownItems = 4;
            cmboBFilters.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.OUT;
            cmboBFilters.Name = "cmboBFilters";
            cmboBFilters.Size = new Size(189, 49);
            cmboBFilters.StartIndex = 0;
            cmboBFilters.TabIndex = 41;
            cmboBFilters.SelectedIndexChanged += cmboBFilters_SelectedIndexChanged;
            // 
            // bigLabel1
            // 
            bigLabel1.AutoSize = true;
            bigLabel1.BackColor = Color.Transparent;
            bigLabel1.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bigLabel1.ForeColor = Color.Black;
            bigLabel1.Location = new Point(23, 36);
            bigLabel1.Name = "bigLabel1";
            bigLabel1.Size = new Size(80, 27);
            bigLabel1.TabIndex = 40;
            bigLabel1.Text = "Filter By";
            // 
            // btnAddPerson
            // 
            btnAddPerson.BackColor = Color.FromArgb(192, 196, 204);
            btnAddPerson.ErrorImage = Properties.Resources.AddPersonIcon;
            btnAddPerson.Image = Properties.Resources.AddPersonIcon;
            btnAddPerson.InitialImage = Properties.Resources.AddPersonIcon;
            btnAddPerson.Location = new Point(652, 14);
            btnAddPerson.Name = "btnAddPerson";
            btnAddPerson.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            btnAddPerson.Size = new Size(76, 49);
            btnAddPerson.SizeMode = PictureBoxSizeMode.StretchImage;
            btnAddPerson.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            btnAddPerson.TabIndex = 43;
            btnAddPerson.TabStop = false;
            btnAddPerson.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            btnAddPerson.Click += btnAddPerson_Click;
            // 
            // ctrlPersonInformation1
            // 
            ctrlPersonInformation1.Location = new Point(8, 80);
            ctrlPersonInformation1.Name = "ctrlPersonInformation1";
            ctrlPersonInformation1.Size = new Size(740, 495);
            ctrlPersonInformation1.TabIndex = 44;
            // 
            // CtrlFindPerson
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ctrlPersonInformation1);
            Controls.Add(btnAddPerson);
            Controls.Add(txtBFilterValue);
            Controls.Add(cmboBFilters);
            Controls.Add(bigLabel1);
            Name = "CtrlFindPerson";
            Size = new Size(757, 585);
            Load += CtrlFindPerson_Load;
            ((System.ComponentModel.ISupportInitialize)btnAddPerson).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtBFilterValue;
        private ReaLTaiizor.Controls.MaterialComboBox cmboBFilters;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private ReaLTaiizor.Controls.HopePictureBox btnAddPerson;
        private CtrlPersonInformation ctrlPersonInformation1;
    }
}
