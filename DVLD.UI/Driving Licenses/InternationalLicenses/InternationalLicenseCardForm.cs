using DVLD.BLL;

namespace DVLD.UI
{
    public partial class InternationalLicenseCardForm : BaseForm
    {
        public InternationalLicenseCardForm(InternationalLicense internationalLicense)
        {
            InitializeComponent();
            LoadInternationalLicenseInformation(internationalLicense);
        }

        private void LoadInternationalLicenseInformation(InternationalLicense internationalLicense)
        {
            Driver? driver = Driver.GetDriver(internationalLicense.DriverID);
            if (driver is null) return;
            Person? person = Person.GetPerson(driver.PersonID);
            if (person is null) return;

            lblDriverBirthDate.Text = person.DateOfBirth.ToShortDateString();
            lblDriverGender.Text = person.Gender.ToString();
            lblDriverID.Text = driver.DriverID.ToString();
            lblDriverName.Text = person.FullName;
            lblDriverNationalNo.Text = person.NationalNo;


            lblInternationalLicenseApplicationID.Text = internationalLicense.ApplicationID.ToString();
            lblInternationalLicenseExpirationDate.Text = internationalLicense.ExpirationDate.ToString();
            lblInternationalLicenseID.Text = internationalLicense.InternationalLicenseID.ToString();
            lblInternationalLicenseIsActive.Text = internationalLicense.IsActive.ToString();
            lblInternationalLicenseIssueDate.Text = internationalLicense.IssueDate.ToShortDateString();
            lblLocalLicenseID.Text = internationalLicense.IssuedUsingLocalLicenseID.ToString();
        }
    }
}
