using DVLD.BLL;
using System.Data;

namespace DVLD.UI
{
    public partial class ManageSystemUsersForm : BaseForm
    {
        public ManageSystemUsersForm()
        {
            InitializeComponent();
            _userDataTable = new DataTable();
        }
        private DataTable _userDataTable;
        private void RefreshDataGridView()
        {
            _userDataTable = User.GetAll();
            grdVUsersInformation.DataSource = _userDataTable;
        }
        private void LoadFilters()
        {
            foreach (var item in _userDataTable.Columns)
            {
                cmboBFilters.Items.Add(item.ToString());
            }
            List<string> activetionFilters = new List<string> { "All", "Active", "Inactive" };
            foreach (var item in activetionFilters)
            {
                cmboBActivationFilterValues.Items.Add(item);
            }
            cmboBFilters.SelectedIndex = 0;
            cmboBActivationFilterValues.SelectedIndex = 0;
        }

        private void ManageSystemUsersForm_Load(object sender, EventArgs e)
        {
            RefreshDataGridView();
            LoadFilters();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            ShowFormDialog(new AddSystemUserForm());
            RefreshDataGridView();
        }

        private void showUserDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int userID = Convert.ToInt32(grdVUsersInformation.CurrentRow?.Cells["UserID"].Value);
            ShowFormDialog(new UserInformationForm(userID));
            RefreshDataGridView();
        }

        private void updatePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int userID = Convert.ToInt32(grdVUsersInformation.CurrentRow?.Cells["UserID"].Value);

            UpdateUserInformationForm form = new(userID);
            form.ChangePasswordMode();
            ShowFormDialog(form);
            RefreshDataGridView();
        }

        private void updateActivetionToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int userID = Convert.ToInt32(grdVUsersInformation.CurrentRow?.Cells["UserID"].Value);

            UpdateUserInformationForm form = new(userID);
            form.ChangeActivationMode();
            ShowFormDialog(form);
            RefreshDataGridView();
        }

        private void deleteUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int userID = Convert.ToInt32(grdVUsersInformation.CurrentRow?.Cells["UserID"].Value);

            if (MessageBox.Show($"Are you sure you want to delete User with ID ({userID})?", "Confirm Delete User", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (User.Delete(userID))
                {
                    MessageBox.Show("User Deleted Successfully", "Delete User");
                    RefreshDataGridView();
                }
                else
                {
                    MessageBox.Show("Failed To Delete User\nThere is data related to this User", "Delete User", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
                }
            }
        }

        private void cmboBFilters_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmboBFilters.SelectedIndex == cmboBFilters.FindString("Activation"))
            {
                cmboBActivationFilterValues.Visible = true;
                txtBFilterValue.Visible = false;
            }
            else
            {
                cmboBActivationFilterValues.Visible = false;
                txtBFilterValue.Visible = true;
            }
        }

        private void cmboBActivationFilterValues_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmboBActivationFilterValues.Text == "All")
            {
                RefreshDataGridView();
            }
            else if(cmboBActivationFilterValues.Text == "Active")
            {
                _userDataTable.DefaultView.RowFilter = string.Format("[Activation] = 1");
            }
            else if(cmboBActivationFilterValues.Text == "Inactive")
            {
                _userDataTable.DefaultView.RowFilter = string.Format("[Activation] = 0");
            }
        }

        private void txtBFilterValue_TextChanged(object sender, EventArgs e)
        {
            if (Validation.Empty(txtBFilterValue.Text))
            {
                RefreshDataGridView(); return;
            }
            string filterColumn = cmboBFilters.Text;
            string filterValue = txtBFilterValue.Text.Trim();
            if ((filterColumn == "PersonID" || filterColumn == "UserID") && Validation.IsNumber(filterValue))
                _userDataTable.DefaultView.RowFilter = string.Format($"[{filterColumn}] = {filterValue}");
            else if(!(filterColumn == "PersonID" || filterColumn == "UserID"))
                _userDataTable.DefaultView.RowFilter = string.Format($"[{filterColumn}] LIKE '{filterValue}%'");
        }
    }
}