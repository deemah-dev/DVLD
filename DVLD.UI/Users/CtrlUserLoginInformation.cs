using DVLD.BLL;

namespace DVLD.UI
{
    public partial class CtrlUserLoginInformation : UserControl
    {
        public CtrlUserLoginInformation()
        {
            InitializeComponent();
        }
        private int _userID = -1;

        internal bool LoadUserInfo(int userID)
        {
            _userID = userID;
            User? user = User.GetUser(userID);
            if (user is not null)
            {
                lblUserID.Text = user.UserID.ToString();
                lblUsername.Text = user.Username;
                if (user.IsActive)
                    lblActivetion.Text = "Active";
                else
                    lblActivetion.Text = "Inactive";
                return true;
            }
            return false;
        }

        private void lnkLblUpdateUserInformation_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_userID == -1) return;
            Form form = new UpdateUserInformationForm(_userID);
            form.ShowDialog();
            LoadUserInfo(_userID);
        }
    }
}