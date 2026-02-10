using DVLD.BLL;
using System.ComponentModel;

namespace DVLD.UI
{
    public partial class CtrlFindPerson : UserControl
    {
        public event EventHandler<int>? OnPersonSelected;
        public CtrlFindPerson()
        {
            InitializeComponent();
        }

        private void CtrlFindPerson_Load(object sender, EventArgs e)
        {
            cmboBFilters.Items.Add("Person ID");
            cmboBFilters.Items.Add("National No.");
        }

        private void cmboBFilters_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmboBFilters.Text == "Person ID")
            {
                txtBFilterValue.Hint = "Person ID";
            }
            else if (cmboBFilters.Text == "National No.")
            {
                txtBFilterValue.Hint = "National No.";
            }
        }

        private void txtBFilterValue_Validating(object sender, CancelEventArgs e)
        {
            if (cmboBFilters.Text == "Person ID")
            {
                if (!Validation.IsNumber(txtBFilterValue.Text.Trim()))
                {
                    txtBFilterValue.ErrorMessage = "Person ID Should Be Integer";
                    txtBFilterValue.SetErrorState(true);
                    e.Cancel = true;
                    txtBFilterValue.Focus();
                }
                else
                {
                    txtBFilterValue.SetErrorState(false);
                }
            }
        }

        private void btnAddPerson_Click(object sender, EventArgs e)
        {
            AddEditPersonForm form = new AddEditPersonForm();
            form.PersonIDBack += AddPersonForm_PersonIDBack;
            form.ShowDialog();
        }

        private void AddPersonForm_PersonIDBack(object? sender, int e)
        {
            cmboBFilters.SelectedIndex = cmboBFilters.FindString("Person ID");
            txtBFilterValue.Text = e.ToString();
            if (ctrlPersonInformation1.LoadPersonInfo(e))
                OnPersonSelected?.Invoke(this, e);
        }

        private void txtBFilterValue_TextChanged(object sender, EventArgs e)
        {
            if (cmboBFilters.Text == "Person ID")
            {
                int personID = Convert.ToInt32(txtBFilterValue.Text.Trim());
                if (ctrlPersonInformation1.LoadPersonInfo(personID))
                    OnPersonSelected?.Invoke(this, personID);
            }
            else if (cmboBFilters.Text == "National No.")
            {
                int? personID = Person.GetPerson(txtBFilterValue.Text.Trim())?.PersonID;
                if (personID is null) return;
                if (ctrlPersonInformation1.LoadPersonInfo((int)personID))
                    OnPersonSelected?.Invoke(this, (int)personID);
            }
        }

        internal void Clear()
        {
            cmboBFilters.SelectedIndex = -1;
            txtBFilterValue.Clear();
            ctrlPersonInformation1.Clear();
        }
    }
}