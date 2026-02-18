using DVLD.BLL;
using System.Data;

namespace DVLD.UI
{
    public partial class ManageDriversForm : BaseForm
    {
        public ManageDriversForm()
        {
            InitializeComponent();
            dtDrivers = Driver.GetAll();
        }

        private DataTable? dtDrivers;

        private void RefreshDataGridView()
        {
            dtDrivers = Driver.GetAll();

            grdVDrivers.DataSource = dtDrivers;
        }

        private void ManageDriversForm_Load(object sender, EventArgs e)
        {
            RefreshDataGridView();
        }

        private void showPersonDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int personID = Convert.ToInt32(grdVDrivers.CurrentRow?.Cells["PersonID"].Value);
            ShowFormDialog(new PersonInformationForm(personID));
        }

        private void issueInternationalLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int driverID = Convert.ToInt32(grdVDrivers.CurrentRow?.Cells["DriverID"].Value);
            ShowFormDialog(new NewInternationalDrivingLicenseForm(driverID));
        }

        private void showDriverLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int driverID = Convert.ToInt32(grdVDrivers.CurrentRow?.Cells["DriverID"].Value);
            ShowFormDialog(new DriverLicensesHistoryForm(driverID));
        }
    }
}
