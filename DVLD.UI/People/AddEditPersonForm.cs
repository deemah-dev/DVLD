using DVLD.BLL;

namespace DVLD.UI
{
    public partial class AddEditPersonForm : BaseForm
    {
        private Mode mode;
        public event EventHandler<int>? PersonIDBack; 
        public AddEditPersonForm()
        {
            InitializeComponent();
            LoadCountriesComboBox();
            AddMode();
        }
        private string _sourceImageFile = "";
        private Person? _person;
        public AddEditPersonForm(int personID)
        {
            InitializeComponent();
            LoadCountriesComboBox();
            _person = Person.GetPerson(personID);
            LoadPersonInformation();
            UpdateMode();
        }

        private void LoadCountriesComboBox()
        {
            cmboBNationalityNames.DataSource = Country.GetNames();
        }

        private void SaveNewPerson()
        {
            Person person = new()
            {
                NationalNo = txtBNationalNo.Text.Trim(),
                FirstName = txtBFirstName.Text.Trim(),
                SecondName = txtBSecondName.Text.Trim(),
                ThirdName = txtBThirdName.Text.Trim(),
                LastName = txtBLastName.Text.Trim(),
                Address = txtBAddress.Text.Trim(),
                Gender = rbtnFemale.Checked ? Gender.Female : Gender.Male,
                DateOfBirth = DtpkrBirthDate.Value,
                Email = txtBEmail.Text.Trim(),
                NationalityName = cmboBNationalityNames.Text.Trim(),
                Phone = txtBPhone.Text.Trim(),
                ImagePath = _sourceImageFile
            };
            if (person.Save())
            {
                MessageBox.Show("Person Information Saved Successfully", "Add Person");
                PersonIDBack?.Invoke(this, person.PersonID);
            }
            else
            {
                MessageBox.Show("Something Went Wrong\nFailed To Save Person Information", "Add Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void SaveUpdatePerson()
        {
            if (_person is not null)
            {
                _person.Address = txtBAddress.Text.Trim();
                _person.Email = txtBEmail.Text.Trim();
                _person.Phone = txtBPhone.Text.Trim();
                _person.ImagePath = _sourceImageFile;
                if (_person.Save())
                {
                    MessageBox.Show("Person Information Saved Successfully", "Update Person");
                    return;
                }
                else
                {
                    MessageBox.Show("Something Went Wrong\nFailed To Save Person Information", "Update Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                MessageBox.Show("Something Went Wrong\nPerson Not Found", "Update Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void AddMode()
        {
            mode = Mode.AddNew;
            DtpkrBirthDate.MaxDate = DateTime.Now.AddYears(-18);
            DtpkrBirthDate.MinDate = DateTime.Now.AddYears(-60);
            cmboBNationalityNames.SelectedIndex = cmboBNationalityNames.FindString("Jordan");
            lblMainLabel.Text = "Add New Person";
            txtBFirstName.ReadOnly = false;
            txtBLastName.ReadOnly = false;
            txtBSecondName.ReadOnly = false;
            txtBThirdName.ReadOnly = false;
            txtBNationalNo.ReadOnly = false;
            DtpkrBirthDate.Enabled = true;
            rbtnFemale.Enabled = true;
            rbtnMale.Enabled = true;
        }

        public void UpdateMode()
        {
            mode = Mode.Update;
            lblMainLabel.Text = "Update Person Info";
            txtBFirstName.ReadOnly = true;
            txtBLastName.ReadOnly = true;
            txtBSecondName.ReadOnly = true;
            txtBThirdName.ReadOnly = true;
            txtBNationalNo.ReadOnly = true;
            DtpkrBirthDate.Enabled = false;
            rbtnFemale.Enabled = false;
            rbtnMale.Enabled = false;
            cmboBNationalityNames.Enabled = false;
        }

        private void LoadPersonInformation()
        {
            if (_person is not null)
            {
                txtBFirstName.Text = _person.FirstName;
                txtBSecondName.Text = _person.SecondName;
                txtBThirdName.Text = _person.ThirdName;
                txtBLastName.Text = _person.LastName;
                txtBNationalNo.Text = _person.NationalNo;
                DtpkrBirthDate.Value = _person.DateOfBirth;
                txtBPhone.Text = _person.Phone;
                cmboBNationalityNames.SelectedIndex = cmboBNationalityNames.FindString(_person.NationalityName);
                txtBEmail.Text = _person.Email;
                txtBAddress.Text = _person.Address;
                if(_person.ImagePath != "")
                    ctrlUploadImage1.LoadImage(_person.ImagePath);

                if (_person.Gender == Gender.Female)
                {
                    rbtnFemale.Checked = true;
                    //pBPersonalPic.Image = Properties.Resources.FemaleIcon;
                }
                else if (_person.Gender == Gender.Male)
                {
                    rbtnMale.Checked = true;
                    //pBPersonalPic.Image = Properties.Resources.MaleIcon;
                }
            }
            else
            {
                MessageBox.Show("Somthing Went Wrong\nPerson With ID {(personID)} Is Not Exist", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Clear()
        {
            //lblPersonID.Text = "[???]";
            txtBFirstName.Clear();
            txtBLastName.Clear();
            txtBSecondName.Clear();
            txtBThirdName.Clear();
            txtBNationalNo.Clear();
            DtpkrBirthDate.Value = DtpkrBirthDate.MinDate;
            rbtnMale.Checked = true;
            txtBPhone.Clear();
            txtBEmail.Clear();
            cmboBNationalityNames.SelectedIndex = -1;
            txtBAddress.Clear();
        }

        private bool HandlePersonImage()
        {
            if (ctrlUploadImage1.ImageLocation is null) return true;
            if (ctrlUploadImage1.ImageLocation == _person?.ImagePath) return true;
            if (ctrlUploadImage1.ImageLocation != "")
            {
                if (_person is not null && _person.ImagePath != "")
                {
                    File.Delete(_person.ImagePath);
                }
                _sourceImageFile = ctrlUploadImage1.ImageLocation.ToString();
                if (Util.CopyImageToProjectImagesFolder(ref _sourceImageFile, "C:\\Users\\ASUS\\source\\repos\\DVLD\\DVLD.UI\\People\\PeopleImages\\"))
                {
                    return true;
                }
                else
                {
                    MessageBox.Show("Error Copying Image File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return false;
                }
            }
            else
            {
                if (_person is not null)
                {
                    File.Delete(_person.ImagePath);
                    _sourceImageFile = "";
                }
            }
            return true;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
                return;
            if (!HandlePersonImage())
                return;

            switch (mode)
            {
                case Mode.AddNew:
                    SaveNewPerson();
                    Clear();
                    break;
                case Mode.Update:
                    SaveUpdatePerson();
                    break;
            }
        }
    }
}