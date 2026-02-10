using DVLD.DAL;
using System.Data;
using System.Diagnostics.Metrics;

namespace DVLD.BLL
{
    public class Person
    {
        private Mode mode;
        public Person()
        {
            PersonID = -1;
            NationalNo = "";
            FirstName = "";
            SecondName = "";
            ThirdName = "";
            LastName = "";
            DateOfBirth = DateTime.MinValue;
            Gender = Gender.Female;
            Address = "";
            Phone = "";
            Email = "";
            ImagePath = "";
            NationalityName = "";

            mode = Mode.AddNew;
        }

        private Person(int personID, string nationalNo, string firstName, string secondName, string thirdName,
            string lastName, DateTime dateOfBirth, Gender gender, string address, string phone,
            string email, string nationalityName, string imagePath)
        {
            PersonID = personID;
            NationalNo = nationalNo;
            FirstName = firstName;
            SecondName = secondName;
            ThirdName = thirdName;
            LastName = lastName;
            DateOfBirth = dateOfBirth;
            Gender = gender;
            Address = address;
            Phone = phone;
            Email = email;
            ImagePath = imagePath;
            NationalityName = nationalityName;

            mode = Mode.Update;
        }

        public int PersonID { get; private set; }
        public string NationalNo { get; set; }
        public string FirstName { get; set; }
        public string SecondName { get; set; }
        public string ThirdName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public Gender Gender { get; set; }
        public string Address { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public int NationalityCountryID { get { return Country.GetID(NationalityName); } }
        public string ImagePath { get; set; }
        public string NationalityName { get; set; }
        public string FullName { get { return $"{FirstName} {SecondName} {LastName}"; } }

        private bool AddNew()
        {

            this.PersonID = PersonRepo.Create(this.NationalNo, this.FirstName, this.SecondName, this.ThirdName, this.LastName,
                this.DateOfBirth, Convert.ToInt32(this.Gender), this.Address, this.Phone, this.Email, this.NationalityCountryID, this.ImagePath);

            return this.PersonID != -1;
        }

        private bool UpdateInformation()
        {
            if (PersonRepo.IsExist(this.PersonID))
            {
                return PersonRepo.Update(this.PersonID, this.Address, this.Phone, this.Email, this.ImagePath);
            }
            return false;
        }

        public bool Save()
        {
            bool save = false;
            switch (mode)
            {
                case Mode.AddNew:
                    save = AddNew();
                    break;
                case Mode.Update:
                    save = UpdateInformation();
                    break;
            }
            return save;
        }

        public static Person? GetPerson(int ID)
        {
            string NationalNo = "";
            string FirstName = "";
            string SecondName = "";
            string ThirdName = "";
            string LastName = "";
            DateTime DateOfBirth = DateTime.Now;
            short Gender = -1;
            string Address = "";
            string Phone = "";
            string Email = "";
            int NationalityCountryID = -1;
            string ImagePath = "";
            string NationalityName = "";

            bool isFound = PersonRepo.Read(ID, ref NationalNo, ref FirstName, ref SecondName, ref ThirdName, ref LastName, ref DateOfBirth, ref Gender, ref Address, ref Phone, ref Email, ref NationalityCountryID, ref NationalityName, ref ImagePath);

            if (isFound)
                return new Person(ID, NationalNo, FirstName, SecondName, ThirdName, LastName, DateOfBirth, (Gender)Gender, Address, Phone, Email, NationalityName, ImagePath);
            return null;
        }

        public static Person? GetPerson(string nationalNo)
        {
            int PersonID = -1;
            string FirstName = "";
            string SecondName = "";
            string ThirdName = "";
            string LastName = "";
            DateTime DateOfBirth = DateTime.Now;
            int Gender = -1;
            string Address = "";
            string Phone = "";
            string Email = "";
            int NationalityCountryID = -1;
            string ImagePath = "";
            string NationalityName = "";

            bool isFound = PersonRepo.Read(nationalNo, ref PersonID, ref FirstName, ref SecondName, ref ThirdName, ref LastName, ref DateOfBirth, ref Gender, ref Address, ref Phone, ref Email, ref NationalityCountryID, ref NationalityName, ref ImagePath);

            if (isFound)
                return new Person(PersonID, nationalNo, FirstName, SecondName, ThirdName, LastName, DateOfBirth, (Gender)Gender, Address, Phone, Email, NationalityName, ImagePath);
            return null;
        }

        public static DataTable GetAll()
        {
            return PersonRepo.GetAll();
        }

        public static bool Delete(int personID)
        {
            return PersonRepo.Delete(personID);
        }
    }
}