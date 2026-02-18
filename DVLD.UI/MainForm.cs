namespace DVLD.UI
{
    public partial class MainForm : BaseForm
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnNewLocalDrivingLicense_Click(object sender, EventArgs e)
        {
            ShowFormDialog(new AddNewLocalDrivingLicenseApplicationForm());
        }

        private void btnNewInternationalDrivingLicense_Click(object sender, EventArgs e)
        {
            ShowFormDialog(new NewInternationalDrivingLicenseForm());
        }

        private void btnRenewDrivingLicense_Click(object sender, EventArgs e)
        {
            ShowFormDialog(new RenewDrivingLicenseForm());
        }

        private void btnReplaceLostDrivingLicense_Click(object sender, EventArgs e)
        {
            ShowFormDialog(new ReplaceDrivingLicenseForm());
        }

        private void btnReplaceDrivingLicense_Click(object sender, EventArgs e)
        {
            ShowFormDialog(new ReplaceDrivingLicenseForm());
        }

        private void btnReleaseDetainedDrivingLicense_Click(object sender, EventArgs e)
        {
            ShowFormDialog(new ReleaseDetainedDrivingLicenseForm());
        }

        private void btnDetainDrivingLicense_Click(object sender, EventArgs e)
        {
            ShowFormDialog(new DetainDrivingLicenseForm());
        }

        private void btnManageLocalDrivingLicenseApplications_Click(object sender, EventArgs e)
        {
            ShowFormDialog(new ManageLocalDrivingLicenseApplicationsForm());
        }

        private void btnManageInternationalDrivingLicenseApplications_Click(object sender, EventArgs e)
        {
            ShowFormDialog(new ManageInternationalDrivingLicenseApplicationsForm());
        }

        private void btnManageDetainedDrivingLicenses_Click(object sender, EventArgs e)
        {
            ShowFormDialog(new ManageDetainedDrivingLicensesForm());
        }

        private void btnManagePeople_Click(object sender, EventArgs e)
        {
            ShowFormDialog(new ManagePeopleForm());
        }

        private void btnManageDrivers_Click(object sender, EventArgs e)
        {
            ShowFormDialog(new ManageDriversForm());
        }

        private void btnManageSystemUsers_Click(object sender, EventArgs e)
        {
            ShowFormDialog(new ManageSystemUsersForm());
        }

        private void btnManageApplicationsTypes_Click(object sender, EventArgs e)
        {
            ShowFormDialog(new ManageApplicationsTypesForm());
        }

        private void btnManageDrivingTestsTypes_Click(object sender, EventArgs e)
        {
            ShowFormDialog(new ManageDrivingTestsTypesForm());
        }

        private void currentUserInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ShowFormDialog(new UserInformationForm(Global.CurrentUser?.UserID));
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpdateUserInformationForm form = new(Global.CurrentUser?.UserID);
            form.ChangePasswordMode();
            ShowFormDialog(form);
        }

        private void logOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Global.CurrentUser = null;
            Form form = new LoginForm();
            form.Show();
            this.Close();
        }

        private void btnSettings_Click(object sender, EventArgs e)
        {
            btnSettings.ContextMenuStrip?.Show();
        }
    }
}