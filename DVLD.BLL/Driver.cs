using DVLD.DAL;
using System.Data;

namespace DVLD.BLL
{
    public class Driver
    {
        public Driver()
        {
            DriverID = -1;
            PersonID = -1;
            CreatedByUserID = -1;
            CreatedDate = DateTime.MinValue;
        }

        private Driver(int driverID, int personID, int createdByUserID, DateTime createdDate)
        {
            DriverID = driverID;
            PersonID = personID;
            CreatedByUserID = createdByUserID;
            CreatedDate = createdDate;
        }

        public int DriverID { get; private set; }
        public int PersonID { get; set; }
        public int CreatedByUserID { get; set; }
        public DateTime CreatedDate { get; set; }

        public Person? Person { get => Person.GetPerson(PersonID); }

        public static DataTable? GetAll()
        {
            return DriverRepo.GetAll();
        }

        public static Driver? GetDriver(int driverID)
        {
            int PersonID = -1, CreatedByUserID = -1;
            DateTime CreatedDate = DateTime.MinValue;


            bool isFound = DriverRepo.Read(driverID, ref PersonID, ref CreatedByUserID, ref CreatedDate);

            if (isFound)
                return new Driver(driverID, PersonID, CreatedByUserID, CreatedDate);
            return null;

        }

        private bool AddNew()
        {
            this.DriverID = DriverRepo.Create(this.PersonID, this.CreatedByUserID, this.CreatedDate);

            return this.DriverID != -1;
        }

        internal bool Save()
        {
            return AddNew();
        }

        public DataTable? GetLocalLicensesHistory()
        {
            return DriverRepo.GetLocalLicensesHistory(this.DriverID);
        }

        public DataTable? GetInternationalLicensesHistory()
        {
            return DriverRepo.GetInternationalLicensesHistory(this.DriverID);
        }

        public static Driver? GetDriverByPersonID(int personID)
        {
            int driverID = -1, CreatedByUserID = -1;
            DateTime CreatedDate = DateTime.MinValue;


            bool isFound = DriverRepo.ReadByPersonID(personID, ref driverID, ref CreatedByUserID, ref CreatedDate);

            if (isFound)
                return new Driver(driverID, personID, CreatedByUserID, CreatedDate);
            return null;
        }
    }
}