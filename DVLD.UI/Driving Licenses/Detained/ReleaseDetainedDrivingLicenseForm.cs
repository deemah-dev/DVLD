using DVLD.BLL;

namespace DVLD.UI
{
    public partial class ReleaseDetainedDrivingLicenseForm : BaseForm
    {
        public ReleaseDetainedDrivingLicenseForm()
        {
            InitializeComponent();
        }

        private BLL.LocalLicense? license;
        private DetainLicense? detainLicense;
        private BLL.Application? application;

        private void lnkLblShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (license is null) return;
            ShowFormDialog(new DriverLicensesHistoryForm(license.DriverID));
        }

        private void lnkLblShowLicenseInformation_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (license is null) return;
            ShowFormDialog(new LocalLicenseCardForm(license));
        }

        private void LoadApplicationInformation()
        {
            if (license is null) return;
            detainLicense = DetainLicense.GetDetainInfo(license.LicenseID);
            if (detainLicense is null) return;
            lblDetainID.Text = detainLicense.DetainID.ToString();
            lblDetainDate.Text = detainLicense.DetaineDate.ToShortDateString();
            lblLicenseID.Text = license.LicenseID.ToString();
            lblFineFees.Text = detainLicense.FineFees.ToString();

            application = new();
            application.ApplicantPersonID = Convert.ToInt32(Driver.GetDriver(license.DriverID)?.PersonID);
            application.ApplicationDate = DateTime.Now;
            application.ApplicationStatus = ApplicationStatus.New;
            application.ApplicationTypeID = Convert.ToInt32(ApplicationTypes.ReleaseDetainedDrivingLicsense);
            application.LastStatusDate = DateTime.Now;
            application.PaidFees = Convert.ToDecimal(ApplicationType.GetApplicationType(application.ApplicationTypeID)?.ApplicationFees);
            application.CreatedByUserID = Global.CurrentUser.UserID;
            if (application.Save())
            {
                lblApplicationFees.Text = application.PaidFees.ToString();
                lblTotalFees.Text = (detainLicense.FineFees + application.PaidFees).ToString();
                lblApplicationID.Text = application.ApplicationID.ToString();
                lblCreatedBy.Text = Global.CurrentUser.Username;
                btnRelease.Enabled = true;
            }
        }

        private void btnRelease_Click(object sender, EventArgs e)
        {
            if (detainLicense is null || application is null) return;
            detainLicense.ReleaseDate = DateTime.Now;
            detainLicense.ReleasedByUserID = Global.CurrentUser.UserID;
            detainLicense.ReleaseApplicationID = application.ApplicationID;
            if (detainLicense.Release())
            {
                MessageBox.Show("Release Detained License Done Successfully", "Release Detained License");
            }
            else
            {
                MessageBox.Show("Failed To Release Detained License", "Release Detained License", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ctrlSearchForLocalLicense1_OnLicenseSelected(object sender, int e)
        {
            license = BLL.LocalLicense.GetLicense(e) ;
            if (license is null) return;
            if (!license.IsDetaind)
            {
                MessageBox.Show($"License With ID {e} is not Detained", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!license.IsActive)
            {
                MessageBox.Show($"License With ID {e} is not Active", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            lnkLblShowLicenseHistory.Enabled = true;
            lnkLblShowLicenseInformation.Enabled = true;
            LoadApplicationInformation();
        }
    }
}
