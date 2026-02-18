using System.ComponentModel;

namespace DVLD.UI
{
    public partial class CtrlSearchForLocalLicense : UserControl
    {
        public event EventHandler<int>? OnLicenseSelected;
        public CtrlSearchForLocalLicense()
        {
            InitializeComponent();
        }

        private void txtBFilterValue_Validating(object sender, CancelEventArgs e)
        {
            if (!Validation.IsNumber(txtBFilterValue.Text.Trim()))
            {
                e.Cancel = true;
                txtBFilterValue.Focus();
            }
        }

        private void txtBFilterValue_TextChanged(object sender, EventArgs e)
        {
            if (!ValidateChildren()) return;

            int licenseID = Convert.ToInt32(txtBFilterValue.Text.Trim());
            if (ctrlLocalLicesneInformation1.LoadLicenseInformation(licenseID))
                OnLicenseSelected?.Invoke(this, licenseID);
        }
    }
}
