namespace DVLD.UI
{
    public partial class ctrlApplicationInformation : UserControl
    {
        public ctrlApplicationInformation()
        {
            InitializeComponent();
            
        }

        public bool LoadInfo(int applicationID)
        {
            _application = BLL.Application.GetApplication(applicationID);
            if (_application is null) return false;
            lblAppID.Text = _application.ApplicationID.ToString();
            lblAppStatus.Text = _application.ApplicationStatus.ToString();
            lblAppFees.Text = _application.PaidFees.ToString();
            lblApplicantFullName.Text = _application.Person?.FullName;
            lblAppType.Text = _application.Type?.ApplicationTypeTitle;
            lblAppDate.Text = _application.ApplicationDate.ToShortDateString();
            lblLastStatusDate.Text = _application.LastStatusDate.ToShortDateString();
            lblCreatedByUsername.Text = _application.CreatedByUser?.Username;
            return true;
        }

        private BLL.Application? _application;

        private void lnkLblViewPersonInformation_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_application is null) return;
            Form form = new PersonInformationForm(_application.ApplicantPersonID);

        }
    }
}
