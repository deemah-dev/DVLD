using DVLD.BLL;

namespace DVLD.UI
{
    public partial class CtrlLocalDrivingLicenseApplicationInformation : UserControl
    {
        public CtrlLocalDrivingLicenseApplicationInformation()
        {
            InitializeComponent();
        }

        public new bool Load(int localDrivingLicenseApplicationID)
        {
            LocalDrivingLicenseApplication? localDrivingLicenseApplication = LocalDrivingLicenseApplication.GetApplication(localDrivingLicenseApplicationID);
            if (localDrivingLicenseApplication is null) return false;
            _load(localDrivingLicenseApplication);
            return  ctrlApplicationInformation1.LoadInfo(localDrivingLicenseApplication.ApplicationID);
        }

        private void _load(LocalDrivingLicenseApplication localDrivingLicenseApplication)
        { 
            lblLocalAppID.Text = localDrivingLicenseApplication.LocalDrivingLicenseApplicationID.ToString();
            lblPassedTests.Text = localDrivingLicenseApplication.PassedTestsNumber.ToString();
            lblLicenseCategory.Text = localDrivingLicenseApplication.LicenseCategory?.CategoryName;
        }
    }
}
