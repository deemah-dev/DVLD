namespace DVLD.UI
{
    partial class CtrlSearchForLocalLicense
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
            bigLabel1 = new ReaLTaiizor.Controls.BigLabel();
            txtBFilterValue = new ReaLTaiizor.Controls.MaterialTextBoxEdit();
            ctrlLocalLicesneInformation1 = new CtrlLocalLicesneInformation();
            SuspendLayout();
            // 
            // bigLabel1
            // 
            bigLabel1.AutoSize = true;
            bigLabel1.BackColor = Color.Transparent;
            bigLabel1.Font = new Font("Arial Narrow", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            bigLabel1.ForeColor = Color.Black;
            bigLabel1.Location = new Point(3, 24);
            bigLabel1.Name = "bigLabel1";
            bigLabel1.Size = new Size(97, 27);
            bigLabel1.TabIndex = 41;
            bigLabel1.Text = "License ID";
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
            txtBFilterValue.Hint = "License ID";
            txtBFilterValue.LeadingIcon = null;
            txtBFilterValue.LeaveOnEnterKey = true;
            txtBFilterValue.Location = new Point(106, 6);
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
            txtBFilterValue.TabIndex = 43;
            txtBFilterValue.TabStop = false;
            txtBFilterValue.TextAlign = HorizontalAlignment.Left;
            txtBFilterValue.TrailingIcon = null;
            txtBFilterValue.UseSystemPasswordChar = false;
            txtBFilterValue.TextChanged += txtBFilterValue_TextChanged;
            txtBFilterValue.Validating += txtBFilterValue_Validating;
            // 
            // ctrlLocalLicesneInformation1
            // 
            ctrlLocalLicesneInformation1.Location = new Point(8, 70);
            ctrlLocalLicesneInformation1.Name = "ctrlLocalLicesneInformation1";
            ctrlLocalLicesneInformation1.Size = new Size(897, 442);
            ctrlLocalLicesneInformation1.TabIndex = 44;
            // 
            // CtrlSearchForLocalLicense
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(ctrlLocalLicesneInformation1);
            Controls.Add(txtBFilterValue);
            Controls.Add(bigLabel1);
            Name = "CtrlSearchForLocalLicense";
            Size = new Size(915, 518);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.BigLabel bigLabel1;
        private ReaLTaiizor.Controls.MaterialTextBoxEdit txtBFilterValue;
        private CtrlLocalLicesneInformation ctrlLocalLicesneInformation1;
    }
}
