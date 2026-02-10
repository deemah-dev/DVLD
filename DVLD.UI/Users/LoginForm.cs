using DVLD.BLL;

namespace DVLD.UI
{
    public partial class LoginForm : BaseForm
    {
        public LoginForm()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtBUsername.Text.Trim();
            string password = txtBPassword.Text.Trim();
            User? user = User.Login(username, password);
            if (user is not null)
            {
                if (user.IsActive)
                {
                    Global.CurrentUser = user;
                    Form form = new MainForm();
                    form.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("This User Account Is Not Active", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("Unvalid Username/Password");
            }
        }
    }
}
