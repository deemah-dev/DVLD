using DVLD.BLL;
using System.Data;

namespace DVLD.UI
{
    public partial class ManagePeopleForm : BaseForm
    {
        public ManagePeopleForm()
        {
            InitializeComponent();
            _peopleDataTable = new DataTable();
        }
        private DataTable _peopleDataTable;

        private void RefreshDataGridView()
        {
            _peopleDataTable = Person.GetAll();
            grdVPeopleInformation.DataSource = _peopleDataTable;
        }
        private void LoadFilters()
        {
            foreach (var item in _peopleDataTable.Columns)
            {
                if (item.ToString() == "DateOfBirth") continue;
                cmboBFilters.Items.Add(item.ToString());
            }
            cmboBFilters.SelectedIndex = 0;
        }

        private void ManagePeopleForm_Load(object sender, EventArgs e)
        {
            RefreshDataGridView();
            LoadFilters();
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            ShowFormDialog(new AddEditPersonForm());
            RefreshDataGridView();
        }

        private void showPersonInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int personID = Convert.ToInt32(grdVPeopleInformation.CurrentRow?.Cells[0].Value);

            ShowFormDialog(new PersonInformationForm(personID));
            RefreshDataGridView();
        }

        private void editPersonInformationToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int personID = Convert.ToInt32(grdVPeopleInformation.CurrentRow?.Cells[0].Value);
            ShowFormDialog(new AddEditPersonForm(personID));
            RefreshDataGridView();
        }

        private void deletePersonToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int PersonID = Convert.ToInt32(grdVPeopleInformation.CurrentRow?.Cells[0].Value);
            if (MessageBox.Show($"Are you sure you want to delete person with ID ({PersonID})?", "Confirm Delete Person", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (Person.Delete(PersonID))
                {
                    MessageBox.Show("Person Deleted Successfully", "Delete Person");
                    RefreshDataGridView();
                }
                else
                {
                    MessageBox.Show("Failed To Delete Person\nThere is data related to this person", "Delete Person", MessageBoxButtons.OK, MessageBoxIcon.Error); ;
                }
            }
        }

        private void cmboBFilters_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmboBFilters.SelectedIndex == cmboBFilters.FindString("Gender"))
            {
                txtBFilterValue.Visible = false;
                cmboBGenderFilterValues.Visible = true;
                List<string> genders = new List<string>(Enum.GetNames(typeof(Gender)));
                cmboBGenderFilterValues.DataSource = genders;
                cmboBGenderFilterValues.SelectedIndex = -1;
            }
            else
            {
                txtBFilterValue.Visible = true;
                cmboBGenderFilterValues.Visible = false;
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
            if (filterColumn == "PersonID" && Validation.IsNumber(filterValue))
                _peopleDataTable.DefaultView.RowFilter = string.Format($"[{filterColumn}] = {filterValue}");
            else if(filterColumn != "PersonID")
                _peopleDataTable.DefaultView.RowFilter = string.Format($"[{filterColumn}] LIKE '{filterValue}%'");
        }

        private void cmboBGenderFilterValues_SelectedIndexChanged(object sender, EventArgs e)
        {
            string filterColumn = cmboBFilters.Text;
            if (filterColumn == "Gender")
                switch (cmboBGenderFilterValues.SelectedIndex)
                {
                    case 0:
                        _peopleDataTable.DefaultView.RowFilter = string.Format($"[{filterColumn}] LIKE '{Gender.Male}%'");
                        break;
                    case 1:
                        _peopleDataTable.DefaultView.RowFilter = string.Format($"[{filterColumn}] LIKE '{Gender.Female}%'");
                        break;
                }
        }
    }
}
