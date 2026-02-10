using DVLD.BLL;
using System.ComponentModel;
using System.Data;

namespace DVLD.UI
{
    public partial class AddSystemUserForm : BaseForm
    {
        public AddSystemUserForm()
        {
            InitializeComponent();
        }

        int personID = -1;

        private void btnNext_Click(object sender, EventArgs e)
        {
            if (!User.IsExist(personID))
                tabControl1.SelectTab("tabPUserInfo");
            else
                MessageBox.Show("This Person Already Have a User Account", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void ctrlFindPerson1_OnPersonSelected(object sender, int e)
        {
            personID = e;
        }

        private void txtBUsername_Validating(object sender, CancelEventArgs e)
        {
            if (User.IsExist(txtBUsername.Text.Trim()))
            {
                e.Cancel = true;
                txtBUsername.Focus();
                errorProvider1.SetError(txtBUsername, "This Username Already Exists In The System");
            }
            if (Validation.Empty(txtBUsername.Text))
            {
                e.Cancel = true;
                txtBUsername.Focus();
                errorProvider1.SetError(txtBUsername, "Username Should Not Be Empty");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtBUsername, "");
            }
        }

        private void txtBConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if (txtBConfirmPassword.Text.Trim() != txtBPassword.Text.Trim())
            {
                e.Cancel = true;
                txtBConfirmPassword.Focus();
                errorProvider1.SetError(txtBConfirmPassword, "The confirmation password does not match the new password.");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtBConfirmPassword, "");
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                MessageBox.Show("Something Went Wrong\nSome Data Not Valid", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            User user = new User() { PersonID = personID, Username = txtBUsername.Text.Trim(), Password = txtBPassword.Text.Trim(), IsActive = rbActive.Checked };
            if (user.Save())
            {
                MessageBox.Show("User Information Added Seccessfully");

                Clear();
            }
            else MessageBox.Show("Something Went Wrong\nFailed To Save User Inforamtion", null, MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void Clear()
        {
            txtBConfirmPassword.Clear();
            txtBPassword.Clear();
            txtBUsername.Clear();
            ctrlFindPerson1.Clear();
            tabControl1.SelectTab("tabPPersonInfo");
        }

        private void txtBPassword_Validating(object sender, CancelEventArgs e)
        {
            if (!Validation.IsValidPassword(txtBPassword.Text.Trim()))
            {
                e.Cancel = true;
                txtBPassword.Focus();
                errorProvider1.SetError(txtBPassword, "The password must contain at least 8 characters,\nand include at least one uppercase letter,\none lowercase letter, and one number.");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtBPassword, "");
            }
        }
    }
}
