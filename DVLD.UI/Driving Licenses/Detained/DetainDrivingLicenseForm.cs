using DVLD.BLL;

namespace DVLD.UI
{
    public partial class DetainDrivingLicenseForm : BaseForm
    {
        public DetainDrivingLicenseForm()
        {
            InitializeComponent();
        }

        private LocalLicense? license;

        private void lnkLblShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (license is null) return;
            Form form = new DriverLicensesHistoryForm(license.DriverID);
            form.ShowDialog();
        }

        private void lnkLblShowLicenseInformation_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (license is null) return;
            Form form = new LocalLicenseCardForm(license);
            form.ShowDialog();
        }

        private void btnDetain_Click(object sender, EventArgs e)
        {
            if (license is null)
            {
                MessageBox.Show("Something Went Wrong\nLicense Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            if (string.IsNullOrEmpty(txtBFees.Text.Trim()))
            {
                MessageBox.Show("Detain Fees Field Is Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            DetainLicense detainedLicense = new();
            detainedLicense.LicenseID = license.LicenseID;
            detainedLicense.DetaineDate = DateTime.Now;
            detainedLicense.FineFees = Convert.ToDecimal(txtBFees.Text.Trim());
            detainedLicense.CreatedByUserID = Global.CurrentUser.UserID;
            if (detainedLicense.Detain())
            {
                lblDetainID.Text = detainedLicense.DetainID.ToString();
                MessageBox.Show("License Detained Successfully", "Detain License");
            }
        }

        private void LoadDetainInformation()
        {
            if (license is null) return;
            lblDetainID.Text = "[???]";
            lblDetainDate.Text = DateTime.Now.ToShortDateString();
            lblLicenseID.Text = license.LicenseID.ToString();
            lblCretedByUsername.Text = Global.CurrentUser.Username;
            btnDetain.Enabled = true;
        }

        

        private void ctrlSearchForLocalLicense1_OnLicenseSelected(object sender, int e)
        {
            license = LocalLicense.GetLicense(e);
            if (license is null) return;
            lnkLblShowLicensesHistory.Enabled = true;
            lnkLblShowNewLicense.Enabled = true;
            if (!license.IsActive)
            {
                MessageBox.Show("License Is Not Active", "Detain License", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (license.IsDetaind)
            {
                MessageBox.Show("License Is Already Detained", "Detain License", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (license.ExpirationDate.CompareTo(DateTime.Now) < 0)
            {
                MessageBox.Show("License Is Expired", "Detain License", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            LoadDetainInformation();
        }
    }
}