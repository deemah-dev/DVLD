using DVLD.BLL;
using ReaLTaiizor.Controls;

namespace DVLD.UI
{
    public partial class CtrlPersonInformation : UserControl
    {
        public CtrlPersonInformation()
        {
            InitializeComponent();
        }
        private Person? _person;
        private bool _loadPersonInfo()
        {
            if (_person is not null)
            {
                lblID.Text = _person.PersonID.ToString();
                lblFullName.Text = _person.FullName;
                lblNationalNo.Text = _person.NationalNo;
                lblGender.Text = _person.Gender.ToString();
                lblEmail.Text = _person.Email.ToString();
                lblAddress.Text = _person.Address;
                lblBirthDate.Text = _person.DateOfBirth.ToShortDateString();
                lblPhone.Text = _person.Phone;
                lblNationality.Text = _person.NationalityName;
                if (_person.ImagePath != "") SetImageToPicturBox(_person.ImagePath);
                return true;
            }
            return false;
            
        }

        private void SetImageToPicturBox(string selectedFilePath)
        {
            using (var fs = new FileStream(selectedFilePath, FileMode.Open, FileAccess.Read))
            {
                picBImage.Image = Image.FromStream(fs);
            }
        }
        public bool LoadPersonInfo(int personID)
        {
            _person = Person.GetPerson(personID);
            return _loadPersonInfo();
        }
        public bool LoadPersonInfo(string nationalNo)
        {
           _person = Person.GetPerson(nationalNo);
            return _loadPersonInfo();
        }

        public void Clear()
        {
            lblID.Text = "???";
            lblNationalNo.Text = "";
            lblFullName.Text = "";
            lblBirthDate.Text = "";
            lblGender.Text = "";
            lblEmail.Text = "";
            lblPhone.Text = "";
            lblNationalNo.Text = "";
            lblAddress.Text = "";
        }

        public int GetPersonID()
        {
            return Convert.ToInt32(lblID.Text.Trim());
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_person is null) return;
            Form form = new AddEditPersonForm(_person.PersonID);
            form.ShowDialog();
            LoadPersonInfo(_person.PersonID);
        }
    }
}
