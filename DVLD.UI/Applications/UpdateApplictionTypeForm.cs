using DVLD.BLL;

namespace DVLD.UI
{
    public partial class UpdateApplictionTypeForm : BaseForm
    {
        public UpdateApplictionTypeForm(int applicationTypeID)
        {
            InitializeComponent();
            type = ApplicationType.GetApplicationType(applicationTypeID);
        }

        private ApplicationType? type;

        private void UpdateApplictionTypeForm_Load(object sender, EventArgs e)
        {
            if (type is not null)
            {
                txtBID.Text = type.ApplicationTypeID.ToString();
                txtBTitle.Text = type.ApplicationTypeTitle;
                txtBFees.Text = type.ApplicationFees.ToString();
            }
            else
            {
                MessageBox.Show("Something Went Wrong\nApplication Type Does Not Exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (type is not null)
            {
                type.ApplicationTypeTitle = txtBTitle.Text.Trim();
                type.ApplicationFees = Convert.ToDecimal(txtBFees.Text.Trim());
                if (type.Save())
                {
                    MessageBox.Show("Application Type Information Saved Successfully", "Update Application Type Information");
                }
                else
                {
                    MessageBox.Show("Failed To Update Application Type Information", "Update Application Type Information");
                }
            }
            else
            {
                MessageBox.Show("Something Went Wrong\nApplication Type Does Not Exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
            }
        }
    }
}
