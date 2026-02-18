using DVLD.BLL;

namespace DVLD.UI
{
    public partial class CtrlLocalLicesneInformation : UserControl
    {
        public CtrlLocalLicesneInformation()
        {
            InitializeComponent();
        }
        internal bool LoadLicenseInformation(int licenseID)
        {
            LocalLicense? license = LocalLicense.GetLicense(licenseID);
            if (license is null) return false;
            lblLicenseID.Text = license.LicenseID.ToString();
            lblLicenseCategory.Text = license.LicenseCategory.CategoryName;
            lblLicenseIssueDate.Text = license.IssueDate.ToShortDateString();
            lblLicenseExpirationDate.Text = license.ExpirationDate.ToShortDateString();
            lblLicenseIssueReason.Text = license.IssueReason.ToString();
            lblLicenseIsActive.Text = license.IsActive.ToString();
            lblLicenseIsDetaind.Text = license.IsDetaind.ToString();
            lblNotes.Text = license.Notes;
            Driver? driver = Driver.GetDriver(license.DriverID);
            if (driver is not null)
            {
                lblDriverID.Text = driver.DriverID.ToString();
                if (driver.Person is not null)
                {
                    lblDriverName.Text = $"{driver.Person.FirstName} {driver.Person.LastName}";
                    lblDriverNationalNo.Text = driver.Person.NationalNo;
                    lblDriverBirthDate.Text = driver.Person.DateOfBirth.ToShortDateString();
                    lblDriverGender.Text = driver.Person.Gender.ToString();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            else
            {
                return false;
            }
        }
    }
}
