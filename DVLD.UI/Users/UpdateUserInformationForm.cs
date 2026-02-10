using DVLD.BLL;
using System.ComponentModel;

namespace DVLD.UI
{
    public partial class UpdateUserInformationForm : BaseForm
    {
        private enum Mode { ChangePassword, ChangeActivetion, UpdateAll };
        private Mode mode;
        public UpdateUserInformationForm(int? userID)
        {
            InitializeComponent();
            if (userID is null) return;
            _user = User.GetUser((int)userID);
            if (_user is null) return;
            rbActive.Checked = _user.IsActive;
            rbInactive.Checked = !_user.IsActive;
            SwitchMode(Mode.UpdateAll, true, true);
        }
        private User? _user;

        private void SwitchMode(Mode mode, bool enablePasswordMode, bool enableActivetionMode)
        {
            this.mode = mode;

            lblChangePassword.Enabled = enablePasswordMode;
            txtBCurrentPassword.Enabled = enablePasswordMode;
            txtBNewPassword.Enabled = enablePasswordMode;
            txtBConfirmNewPassword.Enabled = enablePasswordMode;
            lblChangeActivetion.Enabled = enableActivetionMode;
            lblUserActivetion.Enabled = enableActivetionMode;
            rbActive.Enabled = enableActivetionMode;
            rbInactive.Enabled = enableActivetionMode;
        }

        public void ChangePasswordMode()
        {
            SwitchMode(Mode.ChangePassword, true, false);
        }
        public void ChangeActivationMode()
        {
            SwitchMode(Mode.ChangeActivetion, false, true);
        }

        private void txtBCurrentPassword_Validating(object sender, CancelEventArgs e)
        {
            if (!User.ValidatePassword(_user?.PasswordHash, txtBCurrentPassword.Text.Trim()))
            {
                e.Cancel = true;
                txtBCurrentPassword.Focus();
                errorProvider1.SetError(txtBCurrentPassword, "Value does not mach the current password");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtBCurrentPassword, "");
            }
        }

        private void txtBConfirmNewPassword_Validating(object sender, CancelEventArgs e)
        {
            if (txtBCurrentPassword.Text.Trim() != txtBConfirmNewPassword.Text.Trim())
            {
                e.Cancel = true;
                txtBConfirmNewPassword.Focus();
                errorProvider1.SetError(txtBConfirmNewPassword, "The confirmation password does not match the new password.");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtBConfirmNewPassword, "");
            }
        }

        private void UpdatePassword()
        {
            if (User.UpdatePassword(_user?.UserID, txtBCurrentPassword.Text.Trim(), txtBNewPassword.Text.Trim()))
            {
                MessageBox.Show("Password Updated Successfully", "Update Password");
            }
            else
            {
                MessageBox.Show("Failed To Update Password\nTry Again", "Update Password", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void UpdateActivetion()
        {
            if (User.UpdateActivation(_user?.UserID, rbActive.Checked))
            {
                MessageBox.Show("Activation Updated Successfully", "Update Activation");
            }
            else
            {
                MessageBox.Show("Failed To Update Activation\nTry Again", "Update Activation", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
                return;

            switch (mode)
            {
                case Mode.UpdateAll:
                    UpdatePassword();
                    UpdateActivetion();
                    break;
                case Mode.ChangePassword:
                    UpdatePassword();
                    break;
                case Mode.ChangeActivetion:
                    UpdateActivetion();
                    break;
            }

        }

        private void txtBNewPassword_Validating(object sender, CancelEventArgs e)
        {
            if (!Validation.IsValidPassword(txtBNewPassword.Text.Trim()))
            {
                e.Cancel = true;
                txtBNewPassword.Focus();
                errorProvider1.SetError(txtBNewPassword, "The password must contain at least 8 characters,\nand include at least one uppercase letter,\none lowercase letter, and one number.");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtBNewPassword, "");
            }
        }
    }
}
