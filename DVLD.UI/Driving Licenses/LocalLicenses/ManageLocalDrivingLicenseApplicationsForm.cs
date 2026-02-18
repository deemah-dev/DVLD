using DVLD.BLL;
using System.ComponentModel;
using System.Data;

namespace DVLD.UI
{
    public partial class ManageLocalDrivingLicenseApplicationsForm : BaseForm
    {
        public ManageLocalDrivingLicenseApplicationsForm()
        {
            InitializeComponent();
            _lDLApplicationsDataTable = new DataTable();
        }

        private DataTable _lDLApplicationsDataTable;

        private void RefreshDataGridView()
        {
            _lDLApplicationsDataTable = LocalDrivingLicenseApplication.GetAll();
            grdVApplications.DataSource = _lDLApplicationsDataTable;

            if (grdVApplications.Rows.Count > 0)
            {

                grdVApplications.Columns[0].HeaderText = "L.D.L.AppID";
                grdVApplications.Columns[0].Width = 110;
                grdVApplications.Columns[1].HeaderText = "Driving Class";
                grdVApplications.Columns[1].Width = 300;
                grdVApplications.Columns[2].HeaderText = "National No.";
                grdVApplications.Columns[2].Width = 100;
                grdVApplications.Columns[3].HeaderText = "Full Name";
                grdVApplications.Columns[3].Width = 350;
                grdVApplications.Columns[4].HeaderText = "Application Date";
                grdVApplications.Columns[4].Width = 180;
                grdVApplications.Columns[5].HeaderText = "Passed Tests";
                grdVApplications.Columns[5].Width = 90;
                grdVApplications.Columns[6].HeaderText = "Status";
                grdVApplications.Columns[6].Width = 90;
            }
        }

        private void ManageLocalDrivingLicenseApplicationsForm_Load(object sender, EventArgs e)
        {
            RefreshDataGridView();
        }

        private void showApplicationDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LDLApplicationID = Convert.ToInt32(grdVApplications.CurrentRow?.Cells[0].Value);
            ShowFormDialog(new LocalDrivingLicenseApplicationDetailsForm(LDLApplicationID));
            RefreshDataGridView();
        }

        private void deleteApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LDLApplicationID = Convert.ToInt32(grdVApplications.CurrentRow?.Cells[0].Value);
            if (MessageBox.Show($"Are you sure you want to delete local driving license\napplication with ID ({LDLApplicationID})?", "Delete Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (LocalDrivingLicenseApplication.DeleteApplication(LDLApplicationID))
                {
                    MessageBox.Show("Delete Application Done Successfully", "Delete Application");
                    RefreshDataGridView();
                }
                else
                {
                    MessageBox.Show("Failed To Delete The Application", "Delete Application", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cancelApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LDLApplicationID = Convert.ToInt32(grdVApplications.CurrentRow?.Cells[0].Value);
            LocalDrivingLicenseApplication? application = LocalDrivingLicenseApplication.GetApplication(LDLApplicationID);
            if (application is not null)
            {
                if (MessageBox.Show($"Are you sure you want to cancel local driving license\napplication with ID ({LDLApplicationID})?", "Cancel Application", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (application.CancelApplication())
                    {
                        MessageBox.Show("Cancel Application Done Successfully", "Cancel Application");
                        RefreshDataGridView();
                    }
                    else
                    {
                        MessageBox.Show("Failed To Cancel The Application", "Cancel Application", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                MessageBox.Show("Somthing Went Wrong\nApplication Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void scheduleVisionTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LDLApplicationID = Convert.ToInt32(grdVApplications.CurrentRow?.Cells[0].Value);
           ShowFormDialog(new  VisionTestAppointmentForm(LDLApplicationID));
            RefreshDataGridView();
        }

        private void scheduleWrittenTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LDLApplicationID = Convert.ToInt32(grdVApplications.CurrentRow?.Cells[0].Value);
            ShowFormDialog(new WrittenTestAppointmentForm(LDLApplicationID));
            RefreshDataGridView();
        }

        private void scheduleStreetTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LDLApplicationID = Convert.ToInt32(grdVApplications.CurrentRow?.Cells[0].Value);

            ShowFormDialog(new StreetTestAppointmentForm(LDLApplicationID));
            RefreshDataGridView();
        }

        private void issueDrivingLicenseFirstTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LDLApplicationID = Convert.ToInt32(grdVApplications.CurrentRow?.Cells[0].Value);

            ShowFormDialog(new IssueDriverLicenseForTheFirstTimeForm(LDLApplicationID));
            RefreshDataGridView();
        }

        private void showLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int LDLApplicationID = Convert.ToInt32(grdVApplications.CurrentRow?.Cells[0].Value);
            int applicationID = LocalDrivingLicenseApplication.GetApplication(LDLApplicationID).ApplicationID;

            ShowFormDialog(new LocalLicenseCardForm(applicationID));
            RefreshDataGridView();
        }

        private void showDriverLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string nationalNo = Convert.ToString(grdVApplications.CurrentRow?.Cells[2].Value);
            Person person = Person.GetPerson(nationalNo);

            int? driverID = Driver.GetDriverByPersonID((int)person?.PersonID)?.DriverID;
            if (driverID is null) return;
            ShowFormDialog(new DriverLicensesHistoryForm((int)driverID));
            RefreshDataGridView();
        }

        private ApplicationStatus GetCurrentAppStatus(DataGridViewRow row)
        {
            string status = Convert.ToString(row.Cells[6].Value);
            switch (status.ToLower())
            {
                case "new":
                    return ApplicationStatus.New;
                case "cancled":
                    return ApplicationStatus.Cancled;
                case "completed":
                    return ApplicationStatus.Completed;
            }
            return ApplicationStatus.Cancled;
        }

        private void crownContextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            ResetMenu();

            DataGridViewRow? row = grdVApplications.CurrentRow;
            if (row == null) { e.Cancel = true; return; }


            ApplicationStatus status = GetCurrentAppStatus(row);
            PassedTests passedTestsCount = (PassedTests)row.Cells[5].Value;

            if (status == ApplicationStatus.New)
                ConfigureNewApplication(passedTestsCount);
            else if (status == ApplicationStatus.Completed)
                ConfigureCompletedApplication();
            else if (status == ApplicationStatus.Cancled)
                ConfigureCanceledApplication();
        }

        private void ConfigureCanceledApplication()
        {
            cancelApplicationToolStripMenuItem.Enabled = false;

            scheduleVisionTestToolStripMenuItem.Enabled = false;
            scheduleWrittenTestToolStripMenuItem.Enabled = false;
            scheduleStreetTestToolStripMenuItem.Enabled = false;
            scheduleTestToolStripMenuItem.Enabled = false;

            issueDrivingLicenseFirstTimeToolStripMenuItem.Visible = false;
            showLicenseToolStripMenuItem.Enabled = false;
        }

        private void ConfigureCompletedApplication()
        {
            deleteApplicationToolStripMenuItem.Enabled = false;
            cancelApplicationToolStripMenuItem.Enabled = false;

            scheduleVisionTestToolStripMenuItem.Enabled = false;
            scheduleWrittenTestToolStripMenuItem.Enabled = false;
            scheduleStreetTestToolStripMenuItem.Enabled = false;
            scheduleTestToolStripMenuItem.Enabled = false;
            issueDrivingLicenseFirstTimeToolStripMenuItem.Visible = false;
        }

        private void ConfigureNewApplication(PassedTests passedTestsCount)
        {
            issueDrivingLicenseFirstTimeToolStripMenuItem.Enabled = false;
            showLicenseToolStripMenuItem.Enabled = false;

            switch (passedTestsCount)
            {
                case PassedTests.None:
                    scheduleVisionTestToolStripMenuItem.Enabled = true;
                    scheduleWrittenTestToolStripMenuItem.Enabled = false;
                    scheduleStreetTestToolStripMenuItem.Enabled = false;
                    break;

                case PassedTests.Vision:
                    scheduleVisionTestToolStripMenuItem.Enabled = false;
                    scheduleWrittenTestToolStripMenuItem.Enabled = true;
                    scheduleStreetTestToolStripMenuItem.Enabled = false;
                    break;

                case PassedTests.Written:
                    scheduleVisionTestToolStripMenuItem.Enabled = false;
                    scheduleWrittenTestToolStripMenuItem.Enabled = false;
                    scheduleStreetTestToolStripMenuItem.Enabled = true;
                    break;

                case PassedTests.All:
                    issueDrivingLicenseFirstTimeToolStripMenuItem.Enabled = true;
                    scheduleTestToolStripMenuItem.Enabled = false;
                    break;
            }
        }

        private void ResetMenu()
        {
            foreach (ToolStripItem item in crownContextMenuStrip1.Items)
                item.Enabled = true;
        }
    }
}
