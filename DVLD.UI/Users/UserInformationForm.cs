using DVLD.BLL;

namespace DVLD.UI
{
    public partial class UserInformationForm : BaseForm
    {
        public UserInformationForm(int? userID)
        {
            InitializeComponent();
            if (userID is null) return;
            _user = User.GetUser((int)userID);
            if (_user is null) return;
            try
            {
                ctrlPersonInformation1.LoadPersonInfo(_user.PersonID);
                bool load = ctrlUserLoginInformation1.LoadUserInfo(_user.UserID);
            }
            catch(Exception ex)
            {
                MessageBox.Show($"Error : {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        private User? _user;
    }
}
