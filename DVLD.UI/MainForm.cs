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
            ShowFormDialog(new NewLocalDrivingLicenseForm());
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

        private void btnNewCarLicense_Click(object sender, EventArgs e)
        {
            ShowFormDialog(new NewCarLicenseForm());
        }

        private void btnReleaseDetainedCarLicense_Click(object sender, EventArgs e)
        {
            ShowFormDialog(new ReleaseDetainedCarLicenseForm());
        }

        private void btnDetainDrivingLicense_Click(object sender, EventArgs e)
        {
            ShowFormDialog(new DetainDrivingLicenseForm());
        }

        private void btnDetainCarLicense_Click(object sender, EventArgs e)
        {
            ShowFormDialog(new DetainCarLicenseForm());
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

        private void btnManageDetainedCarLicenses_Click(object sender, EventArgs e)
        {
            ShowFormDialog(new ManageDetainedCarLicensesForm());
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

        private void btnRenewCarLicense_Click(object sender, EventArgs e)
        {
            ShowFormDialog(new RenewCarLicenseForm());
        }

        private void btnReplaceLostCarLicense_Click(object sender, EventArgs e)
        {
            ShowFormDialog(new ReplaceCarLicenseForm());
        }

        private void btnReplaceDamagedCarLicense_Click(object sender, EventArgs e)
        {
            ShowFormDialog(new ReplaceCarLicenseForm());
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