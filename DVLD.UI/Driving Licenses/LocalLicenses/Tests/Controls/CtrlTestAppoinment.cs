using DVLD.BLL;
using System.ComponentModel;

namespace DVLD.UI
{
    public partial class CtrlTestAppoinment : UserControl
    {
        public CtrlTestAppoinment()
        {
            InitializeComponent();
        }
        private LocalDrivingLicenseApplication? _localDrivingLicenseApplication;
        private TestTypes _testType;

        private void btnAddAppoinment_Click(object sender, EventArgs e)
        {
            
            if (_localDrivingLicenseApplication is not null)
            {
                if (_localDrivingLicenseApplication.HavePassedTest(_testType))
                {
                    MessageBox.Show("Applicant Person Already Passed This Test");
                    return;
                }
                if (_localDrivingLicenseApplication.HaveFailedTest(_testType))
                {
                    ScheduleTestForm form = new ScheduleTestForm(_localDrivingLicenseApplication.LocalDrivingLicenseApplicationID, _testType);
                    form.AddMode();
                    form.ScheduleRetakeTestMode(_localDrivingLicenseApplication);
                    form.ShowDialog();
                    RefreshDataGridView();

                    return;
                }
                ScheduleTestForm form1 = new ScheduleTestForm(_localDrivingLicenseApplication.LocalDrivingLicenseApplicationID, _testType);
                form1.AddMode();
                form1.ShowDialog();
                RefreshDataGridView();
            }
        }

        private void RefreshDataGridView()
        {
            grdVAppoinments.DataSource = TestAppointment.GetApplicationAppointments(_localDrivingLicenseApplication.LocalDrivingLicenseApplicationID, _testType);
        }

        public new void Load(int localDrivingLicenseApplicationID)
        {
            ctrlLocalDrivingLicenseApplicationInformation1.Load(localDrivingLicenseApplicationID);
            grdVAppoinments.DataSource = TestAppointment.GetApplicationAppointments(localDrivingLicenseApplicationID, _testType);
            _localDrivingLicenseApplication = LocalDrivingLicenseApplication.GetApplication(localDrivingLicenseApplicationID);
        }

        private void editDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_localDrivingLicenseApplication is not null)
            {
                int appointmentID = Convert.ToInt32(grdVAppoinments.CurrentRow?.Cells[0].Value);
                TestAppointment? appointment = TestAppointment.GetAppointment(appointmentID);
                if ((appointment is not null) && !appointment.IsLocked)
                {
                    ScheduleTestForm form = new ScheduleTestForm(_localDrivingLicenseApplication.LocalDrivingLicenseApplicationID, _testType);
                    form.EditMode(appointmentID);
                    form.ShowDialog();
                    RefreshDataGridView();
                }
            }
        }

        private void takeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (_localDrivingLicenseApplication is not null)
            {
                int appointmentID = Convert.ToInt32(grdVAppoinments.CurrentRow?.Cells[0].Value);
                TestAppointment? appointment = TestAppointment.GetAppointment(appointmentID);
                if ((appointment is not null) && !appointment.IsLocked)
                {
                    Form form = new TakeTestForm(appointment.TestAppointmentID);
                    form.ShowDialog();
                    RefreshDataGridView();
                }
            }
        }

        [DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
        public TestTypes TestType
        {
            get
            {
                return _testType;
            }
            set
            {
                _testType = value;
            }
        }
    }
}
