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
            ctrlPersonInformation1 = new CtrlPersonInformation();
            btnAddPerson = new ReaLTaiizor.Controls.MaterialButton();
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
            // ctrlPersonInformation1
            // 
            ctrlPersonInformation1.Location = new Point(8, 80);
            ctrlPersonInformation1.Name = "ctrlPersonInformation1";
            ctrlPersonInformation1.Size = new Size(740, 495);
            ctrlPersonInformation1.TabIndex = 44;
            // 
            // btnAddPerson
            // 
            btnAddPerson.AutoSize = false;
            btnAddPerson.AutoSizeMode = AutoSizeMode.GrowAndShrink;
            btnAddPerson.Density = ReaLTaiizor.Controls.MaterialButton.MaterialButtonDensity.Default;
            btnAddPerson.Depth = 0;
            btnAddPerson.HighEmphasis = true;
            btnAddPerson.Icon = Properties.Resources.AddPersonIcon;
            btnAddPerson.IconType = ReaLTaiizor.Controls.MaterialButton.MaterialIconType.Rebase;
            btnAddPerson.Location = new Point(636, 14);
            btnAddPerson.Margin = new Padding(4, 6, 4, 6);
            btnAddPerson.MouseState = ReaLTaiizor.Helper.MaterialDrawHelper.MaterialMouseState.HOVER;
            btnAddPerson.Name = "btnAddPerson";
            btnAddPerson.NoAccentTextColor = Color.Empty;
            btnAddPerson.Size = new Size(44, 53);
            btnAddPerson.TabIndex = 45;
            btnAddPerson.Type = ReaLTaiizor.Controls.MaterialButton.MaterialButtonType.Contained;
            btnAddPerson.UseAccentColor = false;
            btnAddPerson.UseVisualStyleBackColor = true;
            btnAddPerson.Click += btnAddPerson_Click;
            // 
            // CtrlFindPerson
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(btnAddPerson);
            Controls.Add(ctrlPersonInformation1);
            Controls.Add(txtBFilterValue);
            Controls.Add(cmboBFilters);
            Controls.Add(bigLabel1);
            Name = "CtrlFindPerson";
            Size = new Size(757, 585);
            Load += CtrlFindPerson_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtBFilterValue;
        private ReaLTaiizor.Controls.MaterialComboBox cmboBFilters;
        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private CtrlPersonInformation ctrlPersonInformation1;
        private ReaLTaiizor.Controls.MaterialButton btnAddPerson;
    }
}
