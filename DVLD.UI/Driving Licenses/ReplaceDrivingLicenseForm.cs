using DVLD.BLL;

namespace DVLD.UI
{
    public partial class ReplaceDrivingLicenseForm : BaseForm
    {
        public ReplaceDrivingLicenseForm()
        {
            InitializeComponent();
        }

        private LocalLicense? oldLicense;
        private LocalLicense? replacedLicnese;
        private BLL.Application? application;
        private ReplacementLicneseReason replacementReason;

        private void LoadApplicationInformation()
        {
            if (oldLicense is null) return;
            if (!oldLicense.IsActive)
            {
                return;
            }
            application = new();
            application.ApplicantPersonID = Convert.ToInt32(Driver.GetDriver(oldLicense.DriverID)?.PersonID);
            application.ApplicationDate = DateTime.Now;
            application.ApplicationStatus = ApplicationStatus.New;
            if (rbtnLostLicense.Checked)
                application.ApplicationTypeID = Convert.ToInt32(ApplicationTypes.ReplacementforaLostDrivingLicense);
            else
                application.ApplicationTypeID = Convert.ToInt32(ApplicationTypes.ReplacementforaDamagedDrivingLicense);
            application.LastStatusDate = DateTime.Now;
            application.PaidFees = Convert.ToDecimal(ApplicationType.GetApplicationType(application.ApplicationTypeID)?.ApplicationFees);
            application.CreatedByUserID = Global.CurrentUser.UserID;
            if (application.Save())
            {
                lblApplicationID.Text = application.ApplicationID.ToString();
                lblApplicationDate.Text = application.ApplicationDate.ToShortDateString();
                lblApplicationFees.Text = application.PaidFees.ToString();
                lblNewLicenseID.Text = "[???]";
                lblOldLicenseID.Text = oldLicense.LicenseID.ToString();
                lblCreatedByUsername.Text = Global.CurrentUser.Username;
                btnIssue.Enabled = true;
            }
        }

        private void rBDamagedLicense_CheckedChanged(object sender, EventArgs e)
        {
            if (rbtnDamagedLicense.Checked)
            {
                replacementReason = ReplacementLicneseReason.DamagedLicense;
                LoadApplicationInformation();
            }
            else
            {
                replacementReason = ReplacementLicneseReason.DamagedLicense;
                LoadApplicationInformation();
            }
        }

        private void lnkLblShowLicenseHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (oldLicense is null) return;
            ShowFormDialog(new DriverLicensesHistoryForm(oldLicense.DriverID));
        }

        private void lnkLblShowNewLicense_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (replacedLicnese is null) return;
            ShowFormDialog(new LocalLicenseCardForm(replacedLicnese));
        }

        private void btnIssue_Click(object sender, EventArgs e)
        {
            if (oldLicense is null || application is null) return;
            replacedLicnese = LocalLicense.ReplaceLicense(oldLicense, replacementReason, application.ApplicationID, "", Global.CurrentUser.UserID, out int newLicenseID);
            if (replacedLicnese is null)
            {
                return;
            }
            lblNewLicenseID.Text = replacedLicnese.LicenseID.ToString();
            lnkLblShowNewLicense.Enabled = true;
            MessageBox.Show($"License Replaced Successfully With ID {newLicenseID}");
        }

        private void ctrlSearchForLocalLicense1_OnLicenseSelected(object sender, int e)
        {
            
            oldLicense = BLL.LocalLicense.GetLicense(e);
            if (oldLicense is null) return;
            if (oldLicense.IsDetaind)
            {
                MessageBox.Show("License Is Detained\nYou Can't Replace It", "Replace License", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (!oldLicense.IsActive)
            {
                MessageBox.Show("License Is Not Active\nYou Can't Replace It", "Replace License", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            if(oldLicense.ExpirationDate.CompareTo(DateTime.Now) < 0)
            {
                MessageBox.Show("License Is Expired\nYou Can't Replace It", "Replace License", MessageBoxButtons.OK, MessageBoxIcon.Error);

                return;
            }
            lnkLblShowLicenseHistory.Enabled = true;
            LoadApplicationInformation();
        }
    }
}
