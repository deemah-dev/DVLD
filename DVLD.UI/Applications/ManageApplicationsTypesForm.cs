using DVLD.BLL;
using System.Data;

namespace DVLD.UI
{
    public partial class ManageApplicationsTypesForm : BaseForm
    {
        public ManageApplicationsTypesForm()
        {
            InitializeComponent();
        }
        private void RefreshDataGridView()
        {
            DataTable dtApplicationTypes = ApplicationType.GetAll();
            grdVApplications.DataSource = dtApplicationTypes;
            grdVApplications.Columns["ApplicationTypeTitle"]?.Width = 400;
            grdVApplications.Columns["ApplicationTypeID"]?.Width = 170;
            grdVApplications.Columns["ApplicationFees"]?.Width = 150;
            grdVApplications.Text = dtApplicationTypes.Rows.Count.ToString();
        }

        private void ManageApplicationsTypesForm_Load(object sender, EventArgs e)
        {
            RefreshDataGridView();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int appTypeId = Convert.ToInt32(grdVApplications.CurrentRow?.Cells[0].Value);
            ShowFormDialog(new UpdateApplictionTypeForm(appTypeId));
            RefreshDataGridView();
        }
    }
}
