using DVLD.BLL;
using System.ComponentModel;

namespace DVLD.UI
{
    public partial class NewInternationalDrivingLicenseForm : BaseForm
    {
        //private int driverID;

        public NewInternationalDrivingLicenseForm()
        {
            InitializeComponent();
        }

        public NewInternationalDrivingLicenseForm(int driverID)
        {
            //this.driverID = driverID;
        }

        private LocalLicense? license;
        private InternationalLicense? internationalLicense;
        private BLL.Application? application;

        private void lnkLblShowLicensesHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (license is null) return;
            ShowFormDialog(new DriverLicensesHistoryForm(license.DriverID));
        }

        private void lnkLblShowInternationalLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (internationalLicense is null) return;
            ShowFormDialog(new InternationalLicenseCardForm(internationalLicense));

        }

        private void LoadApplicationInformation()
        {
            if (application is null) return;
            lblApplicationID.Text = application.ApplicationID.ToString();
            lblApplicationDate.Text = application.ApplicationDate.ToShortDateString();
            lblApplicationFees.Text = application.PaidFees.ToString();
            lblLocalLicenseID.Text = license?.LicenseID.ToString();
            lblApplicationCreatedByUser.Text = Global.CurrentUser.Username;
        }

        private void LoadIssuedLicenseInfo()
        {
            if (internationalLicense is null) return;
            lblInternationalLicenseIssueDate.Text = internationalLicense.IssueDate.ToShortDateString();
            lblInternationalLicenseID.Text = internationalLicense.InternationalLicenseID.ToString();
            lblInternationalLicenseExpirationDate.Text = internationalLicense.ExpirationDate.ToShortDateString();
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            if (application is null || license is null) return;
            InternationalLicense internationalLicense = new();
            internationalLicense.ApplicationID = application.ApplicationID;
            internationalLicense.DriverID = license.DriverID;
            internationalLicense.IssuedUsingLocalLicenseID = license.LicenseID;
            internationalLicense.IssueDate = DateTime.Now;
            internationalLicense.IsActive = true;
            internationalLicense.CreatedByUserID = Global.CurrentUser.UserID;
            if (internationalLicense.Save())
            {
                MessageBox.Show($"International License Issued Successfully With ID {internationalLicense.InternationalLicenseID}", "International License");
                this.internationalLicense = internationalLicense;
                LoadIssuedLicenseInfo();
                lnkLblShowInternationalLicenseInfo.Enabled = true;
            }
        }

        private void ctrlSearchForLocalLicense1_OnLicenseSelected(object sender, int e)
        {
            license = LocalLicense.GetLicense(e);
            lnkLblShowLicensesHistory.Enabled = true;
            if (InternationalLicense.IsExist(license.LicenseID))
            {
                MessageBox.Show($"Local License With ID {license.LicenseID} Already Have International License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!(license.LicenseCategoryID == (int)LicenseCategories.OrdinaryDrivingLicense))
            {
                MessageBox.Show("Local License Should Be Ordinary Driving License To Issue International License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!license.IsActive)
            {
                MessageBox.Show($"Local License With ID {license.LicenseID} Is Not Active", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            BLL.Application application = new();
            application.ApplicantPersonID = Convert.ToInt32(Driver.GetDriver(license.DriverID)?.PersonID);
            application.ApplicationDate = DateTime.Now;
            application.ApplicationStatus = ApplicationStatus.New;
            application.ApplicationTypeID = Convert.ToInt32(ApplicationTypes.NewInternationalLicense);
            application.LastStatusDate = DateTime.Now;
            application.PaidFees = Convert.ToDecimal(ApplicationType.GetApplicationType(application.ApplicationTypeID)?.ApplicationFees);
            application.CreatedByUserID = Global.CurrentUser.UserID;
            if (application.Save())
            {
                this.application = application;
                LoadApplicationInformation();
                btnIssue.Enabled = true;
            }
        }
    }
}
