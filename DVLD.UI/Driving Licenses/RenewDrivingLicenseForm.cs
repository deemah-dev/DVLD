using DVLD.BLL;
using System.ComponentModel;

namespace DVLD.UI
{
    public partial class RenewDrivingLicenseForm : BaseForm
    {
        public RenewDrivingLicenseForm()
        {
            InitializeComponent();
        }

        private LocalLicense? oldLicense;
        private LocalLicense? renewedLicense;
        private BLL.Application? application;


        private void LoadApplicationInformation()
        {
            if (application is null || oldLicense is null) return;

            lblApplicationID.Text = application.ApplicationID.ToString();
            lblApplicationDate.Text = application.ApplicationDate.ToShortDateString();
            lblApplicatinFees.Text = application.PaidFees.ToString();
            lblApplicationCretedBy.Text = Global.CurrentUser.Username;

            lblRenewedLicenseIssueDate.Text = "[???]";
            lblRenewedLicenseExpirationDate.Text = "[???]";
            lblRenewedLicenseID.Text = "[???]";

            decimal categoryFees = -1;
            lblOldLicenseID.Text = oldLicense.LicenseID.ToString();
            categoryFees = Convert.ToDecimal(LicenseCategory.GetCategory(oldLicense.LicenseCategoryID)?.CategoryFees);
            lblLicenseFees.Text = categoryFees.ToString();
            lblApplicatinFees.Text = (categoryFees + application.PaidFees).ToString();
        }

        private void lnkLblShowLicensesHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (oldLicense is null) return;
            Form form = new DriverLicensesHistoryForm(oldLicense.DriverID);
            form.ShowDialog();
        }

        private void lnkLblShowNewLicense_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (renewedLicense is null) return;
            ShowFormDialog(new LocalLicenseCardForm(renewedLicense));
        }

        private void btnRenew_Click(object sender, EventArgs e)
        {
            if (oldLicense is null) return;
            renewedLicense = LocalLicense.RenewLicense(oldLicense, application.ApplicationID, DateTime.Now, "", Global.CurrentUser.UserID, out int newLicenseID);

            if (renewedLicense is null)
            {
                return;
            }
            lblRenewedLicenseIssueDate.Text = renewedLicense.IssueDate.ToShortDateString();
            lblRenewedLicenseExpirationDate.Text = renewedLicense.ExpirationDate.ToShortDateString();
            lblRenewedLicenseID.Text = renewedLicense.LicenseID.ToString();
            lnkLblShowNewLicense.Enabled = true;
            MessageBox.Show($"License Renewd Successfully With ID {newLicenseID}", "Renew License");
        }

        private void ctrlSearchForLocalLicense1_OnLicenseSelected(object sender, int e)
        {
            oldLicense = LocalLicense.GetLicense(e);
            lnkLblShowLicensesHistory.Enabled = true;
            if (!oldLicense.IsActive)
            {
                MessageBox.Show("License Is Not Active", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if ( oldLicense.ExpirationDate.CompareTo(DateTime.Now) > 0)
            {
                MessageBox.Show("License Is Not Expirated", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            BLL.Application application = new();
            application.ApplicantPersonID = Convert.ToInt32(Driver.GetDriver(oldLicense.DriverID)?.PersonID);
            application.ApplicationDate = DateTime.Now;
            application.ApplicationStatus = ApplicationStatus.New;
            application.ApplicationTypeID = Convert.ToInt32(ApplicationTypes.RenewDrivingLicenseService);
            application.LastStatusDate = DateTime.Now;
            application.PaidFees = Convert.ToDecimal(ApplicationType.GetApplicationType(application.ApplicationTypeID)?.ApplicationFees);
            application.CreatedByUserID = Global.CurrentUser.UserID;
            if (application.Save())
            {
                this.application = application;
                LoadApplicationInformation();
                btnRenew.Enabled = true;
            }
        }
    }
}
