using DVLD.DAL;

namespace DVLD.BLL
{
    public class Application
    {
        public Application()
        {
            ApplicationID = -1;
            ApplicantPersonID = -1;
            ApplicationDate = DateTime.MinValue;
            ApplicationTypeID = -1;
            ApplicationStatus = ApplicationStatus.Cancled;
            LastStatusDate = DateTime.MinValue;
            PaidFees = -1;
            CreatedByUserID = -1;
        }

        protected Application(int applicationID, int applicantPersonID, DateTime applicationDate, int applicationTypeID,
            ApplicationStatus applicationStatus, DateTime lastStatusDate, decimal paidFees, int createdByUserID)
        {
            ApplicationID = applicationID;
            ApplicantPersonID = applicantPersonID;
            ApplicationDate = applicationDate;
            ApplicationTypeID = applicationTypeID;
            ApplicationStatus = applicationStatus;
            LastStatusDate = lastStatusDate;
            PaidFees = paidFees;
            CreatedByUserID = createdByUserID;
        }

        public int ApplicationID { get; set; }
        public int ApplicantPersonID { get; set; }
        public DateTime ApplicationDate { get; set; }
        public int ApplicationTypeID { get; set; }
        public ApplicationStatus ApplicationStatus { get; set; }
        public DateTime LastStatusDate { get; set; }
        public decimal PaidFees { get; set; }
        public int CreatedByUserID { get; set; }
        public User? CreatedByUser { get => User.GetUser(CreatedByUserID); }
        public Person? Person { get => Person.GetPerson(ApplicantPersonID); }
        public ApplicationType? Type { get => ApplicationType.GetApplicationType(ApplicationTypeID); }

        private bool AddNew()
        {
            this.ApplicationID =  ApplicationRepo.Create(this.ApplicantPersonID, this.ApplicationDate, this.ApplicationTypeID,  Convert.ToInt32(this.ApplicationStatus),
                this.LastStatusDate, this.PaidFees, this.CreatedByUserID);

            return (this.ApplicationID != -1);
        }

        public virtual bool CancelApplication()
        {
            return ApplicationRepo.UpdateApplicationStatus(this.ApplicationID, (int)ApplicationStatus.Cancled);
        }
        public virtual bool CompleteApplication()
        {
            return ApplicationRepo.UpdateApplicationStatus(this.ApplicationID, (int)ApplicationStatus.Completed);
        }

        public static Application? GetApplication(int applicationID)
        {
            int ApplicantPersonID = -1;
            DateTime ApplicationDate = DateTime.MinValue;
            int ApplicationTypeID = -1;
            int ApplicationStatus = 0;
            DateTime LastStatusDate = DateTime.MinValue;
            decimal PaidFees = -1;
            int CreatedByUserID = -1;

            bool isFound = ApplicationRepo.Read(applicationID, ref ApplicantPersonID,
                ref ApplicationDate, ref ApplicationTypeID, ref ApplicationStatus,
                ref LastStatusDate, ref PaidFees, ref CreatedByUserID);

            if (isFound)
                return new Application(applicationID, ApplicantPersonID,
                    ApplicationDate, ApplicationTypeID, (ApplicationStatus)ApplicationStatus,
                    LastStatusDate, PaidFees, CreatedByUserID);

            return null;
        }

        public virtual bool Save()
        {
            bool save = false;
            save = AddNew();
            return save;
        }

        protected static bool DeleteApplication(int applicationID)
        {
            return ApplicationRepo.Delete(applicationID);
        }
    }
}