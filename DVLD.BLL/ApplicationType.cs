using DVLD.DAL;
using System.Data;

namespace DVLD.BLL
{
    public class ApplicationType
    {
        private ApplicationType(int applicationTypeID, string applicationTypeTitle, decimal applicationFees)
        {
            ApplicationTypeID = applicationTypeID;
            ApplicationTypeTitle = applicationTypeTitle;
            ApplicationFees = applicationFees;
        }

        public int ApplicationTypeID { get; }

        public string ApplicationTypeTitle { get; set; }

        public decimal ApplicationFees { get; set; }

        public static DataTable? GetAll()
        {
            return ApplicationTypeRepo.GetAll();
        }

        public static ApplicationType? GetApplicationType(int applicationTypeID)
        {
            string applicationTypeTitle = ""; decimal applicationTypeFees = -1;
            bool isFound = ApplicationTypeRepo.Read(applicationTypeID, ref applicationTypeTitle, ref applicationTypeFees);

            if (isFound)
                return new ApplicationType(applicationTypeID, applicationTypeTitle, applicationTypeFees);
            return null;
        }

        public bool Save()
        {
            return ApplicationTypeRepo.Update(this.ApplicationTypeID, this.ApplicationTypeTitle, this.ApplicationFees);
        }
    }
}
