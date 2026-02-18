using DVLD.BLL;

namespace DVLD.UI
{
    public partial class CtrlScheduleTest : UserControl
    {
        public CtrlScheduleTest()
        {
            InitializeComponent();
        }

        private LocalDrivingLicenseApplication? application;
        private TestAppointment? appointment1;
        private TestTypes type;
        private Mode mode;

        internal void SetTestType(int localDrivingLicenseApplicationID, TestTypes type)
        {
            application = LocalDrivingLicenseApplication.GetApplication(localDrivingLicenseApplicationID);
            this.type = type;

            if (application is not null)
            {
                lblAppointmentID.Text = application.LocalDrivingLicenseApplicationID.ToString();
                lblLicenseCategory.Text = LicenseCategory.GetCategory(application.LicenseCategoryID)?.CategoryName;
                lblPersonName.Text = Person.GetPerson(application.ApplicantPersonID)?.FullName;
                lblFees.Text = application.PaidFees.ToString();
                lblTrial.Text = (application.FailedTestTrials(type) + 1).ToString();
                dtPkrAppointmentDate.MinDate = DateTime.Now;
                dtPkrAppointmentDate.MaxDate = DateTime.Now.AddYears(2);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (application is null)
            {
                return;
            }
            switch (mode)
            {
                case Mode.AddNew:
                    TestAppointment appointment = new();
                    appointment.TestType = type;
                    appointment.LocalDrivingLicenseApplicationID = application.LocalDrivingLicenseApplicationID;
                    appointment.AppointmentDate = dtPkrAppointmentDate.Value;
                    appointment.PaidFees = TestType.GetTestType(type).TestTypeFees;
                    appointment.CreatedByUserID = Global.CurrentUser.UserID;
                    appointment.IsLocked = false;
                    if (appointment.Save())
                    {
                        MessageBox.Show("Appointment Saved Successfully", "Save Appointment");
                    }
                    else
                    {
                        MessageBox.Show("Something Went Wrong\nCouldn't Save Appointment", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    break;
                case Mode.Update:
                    if (appointment1 is not null)
                    {
                        appointment1.AppointmentDate = dtPkrAppointmentDate.Value;
                        if (appointment1.Save())
                        {
                            MessageBox.Show("Appointment Saved Successfully", "Save Appointment");
                        }
                        else
                        {
                            MessageBox.Show("Something Went Wrong\nCouldn't Save Appointment", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    break;
            }
        }

        internal void AddMode()
        {
            mode = Mode.AddNew;
        }

        internal void EditMode(int testAppointmentID)
        {
            appointment1 = TestAppointment.GetAppointment(testAppointmentID);
            if (appointment1 is not null)
            {
                mode = Mode.Update;
                dtPkrAppointmentDate.Value = appointment1.AppointmentDate;
            }
        }

        internal void ScheduleFirstTestAppointmentMode(TestTypes type)
        {
            gBRetakeTestApplicationInfo.Enabled = false;
            lblMainLabel.Text = $"Schedule {type.ToString()} Test";
        }

        internal void ScheduleRetakeTestAppointmentMode(LocalDrivingLicenseApplication application)
        {
            if (application is null) return;

            gBRetakeTestApplicationInfo.Enabled = true;
            lblMainLabel.Text = "Schedule Retake Test";
            BLL.Application retakeTestApplication = new();
            retakeTestApplication.ApplicantPersonID = application.ApplicantPersonID;
            retakeTestApplication.ApplicationDate = DateTime.Now;
            retakeTestApplication.ApplicationStatus = ApplicationStatus.New;
            retakeTestApplication.ApplicationTypeID = Convert.ToInt32(ApplicationTypes.RetakeTest);
            retakeTestApplication.LastStatusDate = DateTime.Now;
            retakeTestApplication.PaidFees = Convert.ToDecimal(ApplicationType.GetApplicationType(retakeTestApplication.ApplicationTypeID)?.ApplicationFees);
            retakeTestApplication.CreatedByUserID = Global.CurrentUser.UserID;
            if (retakeTestApplication.Save())
            {
                lblRetakeTestApplicationID.Text = retakeTestApplication.ApplicationID.ToString();
                lblRetakeTestApplicationFees.Text = retakeTestApplication.PaidFees.ToString();
                decimal.TryParse(lblFees.Text, out decimal d);
                lblTotalFees.Text = (d + retakeTestApplication.PaidFees).ToString();
            }
        }
    }
}
