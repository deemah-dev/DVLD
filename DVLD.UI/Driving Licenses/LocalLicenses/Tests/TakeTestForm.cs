using DVLD.BLL;

namespace DVLD.UI
{
    public partial class TakeTestForm : BaseForm
    {
        public TakeTestForm(int testAppointmentID)
        {
            InitializeComponent();
            _appointment = TestAppointment.GetAppointment(testAppointmentID);
        }


        TestAppointment? _appointment;
        private void TakeTestForm_Load(object sender, EventArgs e)
        {
            if (_appointment is null) return;
            lblMainLabel.Text = _appointment.TestType.ToString();
            lblAppointmentID.Text = _appointment.TestAppointmentID.ToString();
            lblLicenseCategory.Text = _appointment.LicenseCategory?.CategoryName;
            lblPersonName.Text = _appointment.Person?.FullName;
            lblTrial.Text = _appointment.Trial.ToString();
            lblDate.Text = _appointment.AppointmentDate.ToShortDateString();
            lblFees.Text = _appointment.PaidFees.ToString();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (_appointment is not null)
            {
                Test test = new();
                test.TestAppointmentID = _appointment.TestAppointmentID;
                test.TestResult = (TestResult)Convert.ToInt16(rbtnPassed.Checked);
                test.Notes = txtBNotes.Text.Trim();
                test.CreatedByUserID = Global.CurrentUser.UserID;
                if (test.Save())
                {
                    MessageBox.Show("Result Info Saved Successfully", "Take Test");
                    rbtnFailed.Enabled = false;
                    rbtnPassed.Enabled = false;
                    txtBNotes.Enabled = false;
                }
                else
                {
                    MessageBox.Show("Failed To Save Result", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
