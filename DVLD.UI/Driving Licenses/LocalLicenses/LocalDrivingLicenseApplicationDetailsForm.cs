using DVLD.BLL;

namespace DVLD.UI
{
    public partial class LocalDrivingLicenseApplicationDetailsForm : BaseForm
    {
        public LocalDrivingLicenseApplicationDetailsForm(int LocalDrivingLicenseApplicationID)
        {
            InitializeComponent();
            ctrlLocalDrivingLicenseApplicationInformation1.Load(LocalDrivingLicenseApplicationID);
        }
    }
}
