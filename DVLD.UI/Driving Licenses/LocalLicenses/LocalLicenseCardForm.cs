using DVLD.BLL;
using System.ComponentModel;

namespace DVLD.UI
{
    public partial class LocalLicenseCardForm : BaseForm
    {
        private LocalLicense? _license;

        public LocalLicenseCardForm(int applicationID)
        {
            InitializeComponent();
            _license = LocalLicense.GetLicenseByApplicationID(applicationID);
        }

        public LocalLicenseCardForm(LocalLicense licnese)
        {
            InitializeComponent();

            _license = licnese;
        }

        private void LocalLicenseCardForm_Load(object sender, EventArgs e)
        {
            ctrlLocalLicesneInformation1.LoadLicenseInformation(_license.LicenseID);
        }
    }
}
