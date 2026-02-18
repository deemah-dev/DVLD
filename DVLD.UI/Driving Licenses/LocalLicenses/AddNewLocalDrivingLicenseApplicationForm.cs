using DVLD.BLL;

namespace DVLD.UI
{
    public partial class AddNewLocalDrivingLicenseApplicationForm : BaseForm
    {
        public AddNewLocalDrivingLicenseApplicationForm()
        {
            InitializeComponent();
            cmboBLicenseCategories.DataSource = LicenseCategory.GetNames();
            cmboBLicenseCategories.SelectedIndex = -1;
        }
        private int _applicantPersonID;
        private void btnSave_Click(object sender, EventArgs e)
        {
            int licenseCategoryID = LicenseCategory.GetID(cmboBLicenseCategories.Text);
            if (LocalDrivingLicenseApplication.HaveNewApplication(_applicantPersonID, licenseCategoryID))
            {
                MessageBox.Show($"Person With ID ({_applicantPersonID}) Already Have a New License\nDriving Application For Category\n({cmboBLicenseCategories.Text})", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (LocalDrivingLicenseApplication.HaveCompletedApplication(_applicantPersonID, licenseCategoryID))
            {
                MessageBox.Show($"Person With ID ({_applicantPersonID}) Already Have a Completed License\nDriving Application For Category\n({cmboBLicenseCategories.Text})", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            LocalDrivingLicenseApplication LDLApplication = new LocalDrivingLicenseApplication();
            LDLApplication.ApplicationDate = DateTime.Now;
            LDLApplication.ApplicationStatus = ApplicationStatus.New;
            LDLApplication.ApplicantPersonID = _applicantPersonID;
            LDLApplication.ApplicationTypeID = Convert.ToInt32(ApplicationTypes.NewInternationalLicense);
            LDLApplication.PaidFees = Convert.ToDecimal(ApplicationType.GetApplicationType(LDLApplication.ApplicationTypeID)?.ApplicationFees);
            LDLApplication.CreatedByUserID = (int)Global.CurrentUser?.UserID;
            LDLApplication.LastStatusDate = LDLApplication.ApplicationDate;
            LDLApplication.ApplicationID = LDLApplication.ApplicationID;
            LDLApplication.LicenseCategoryID = licenseCategoryID;
            if (LDLApplication.Save())
            {
                MessageBox.Show("Application Saved Successfully", "Add Application");
            }
            else
            {
                MessageBox.Show("Failed To Save Application Information", "Add Application", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            Clear();
        }

        private void Clear()
        {
            lblApplicationFees.Text = "[???]";
            lblCreatedByUsername.Text = "[???]";
            lblLicenseApplicationID.Text = "[???]";
            lblApplicationDate.Text = DateTime.Now.ToShortDateString();
            cmboBLicenseCategories.SelectedIndex = -1;
            ctrlFindPerson1.Clear();
        }

        private void ctrlFindPerson1_OnPersonSelected(object sender, int e)
        {
            _applicantPersonID = e;
        }

        private void btnNext_Click(object sender, EventArgs e)
        {
            tabControl1.SelectTab("tabPAppInfo");
            lblApplicationDate.Text = DateTime.Now.ToShortDateString();
            lblCreatedByUsername.Text = Global.CurrentUser?.Username;
        }

        private void cmboBLicenseCategories_SelectedIndexChanged(object sender, EventArgs e)
        {
            LicenseCategory? licenseCategory = LicenseCategory.GetCategory(cmboBLicenseCategories.Text);
            if (licenseCategory is null) return;
            string categoriesFees = licenseCategory.CategoryFees.ToString();
            lblApplicationFees.Text = categoriesFees;
        }
    }
}
