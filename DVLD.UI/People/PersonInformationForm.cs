using DVLD.BLL;

namespace DVLD.UI
{
    public partial class PersonInformationForm : BaseForm
    {
        public PersonInformationForm(int personID)
        {
            InitializeComponent();
            _personID = personID;
            LoadPersonInformation();
        }

        private void LoadPersonInformation()
        {
            if (!ctrlPersonInformation1.LoadPersonInfo(_personID))
            {
                MessageBox.Show("Something Went Wrong\nPerson Not Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private int _personID;
    }
}
