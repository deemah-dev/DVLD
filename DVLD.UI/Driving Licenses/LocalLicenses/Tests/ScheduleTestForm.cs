using DVLD.BLL;

namespace DVLD.UI
{
    public partial class ScheduleTestForm : BaseForm
    {
        public ScheduleTestForm(int localDrivingLicenseApplicationID, TestTypes type)
        {
            InitializeComponent();
            this.localDrivingLicenseApplicationID = localDrivingLicenseApplicationID;
            this.type = type;

            ctrlScheduleTest1.ScheduleFirstTestAppointmentMode(type);
        }

        private int localDrivingLicenseApplicationID;
        private TestTypes type;

        internal void AddMode()
        {
            ctrlScheduleTest1.AddMode();
        }

        internal void EditMode(int testAppointmentID)
        {
            ctrlScheduleTest1.EditMode(testAppointmentID);
        }

        internal void ScheduleRetakeTestMode(LocalDrivingLicenseApplication application)
        {
            ctrlScheduleTest1.ScheduleRetakeTestAppointmentMode(application);
        }

        private void ctrlScheduleTest1_Load(object sender, EventArgs e)
        {
            ctrlScheduleTest1.SetTestType(localDrivingLicenseApplicationID, type);

        }
    }
}
