using DVLD.BLL;

namespace DVLD.UI
{
    public partial class IssueDriverLicenseForTheFirstTimeForm : BaseForm
    {
        public IssueDriverLicenseForTheFirstTimeForm(int lDLApplicationID)
        {
            InitializeComponent();
            ctrlLocalDrivingLicenseApplicationInformation1.Load(lDLApplicationID);
            localDrivingLicenseApplication = LocalDrivingLicenseApplication.GetApplication(lDLApplicationID);
        }

        private LocalDrivingLicenseApplication? localDrivingLicenseApplication;

        private void btnIssue_Click(object sender, EventArgs e)
        {
            if (localDrivingLicenseApplication is null) return;
            LocalLicense license = new();
            license.ApplicationID = localDrivingLicenseApplication.ApplicationID;
            int? driverID = Driver.GetDriverByPersonID(localDrivingLicenseApplication.ApplicantPersonID)?.DriverID;
            if (driverID is not null)
                license.DriverID = (int)driverID;
            license.LicenseCategoryID = localDrivingLicenseApplication.LicenseCategoryID;
            license.IssueDate = DateTime.Now;
            license.IsActive = true;
            license.IssueReason = IssueLicenseReson.FirstTime;
            license.CreatedByUserID = Global.CurrentUser.UserID;
            license.Notes = txtBNotes.Text;
            if (license.Save())
            {
                MessageBox.Show($"Local License Issued Successfully With ID {license.LicenseID}");
            }
        }
    }
}
