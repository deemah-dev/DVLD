
using DVLD.DAL;
using System.Data;

namespace DVLD.BLL
{
    public class LocalDrivingLicenseApplication : Application
    {
        public LocalDrivingLicenseApplication() : base()
        {
            LocalDrivingLicenseApplicationID = -1;
            ApplicationID = -1;
            LicenseCategoryID = -1;
        }
        private LocalDrivingLicenseApplication(int localDrivingLicenseApplicationID,
            int applicationID, int licenseCategoryID, int applicantPersonID, DateTime applicationDate, int applicationTypeID,
            ApplicationStatus applicationStatus, DateTime lastStatusDate, decimal paidFees, int createdByUserID) : base(applicationID, applicantPersonID,
                applicationDate, applicationTypeID,
             applicationStatus, lastStatusDate, paidFees, createdByUserID)
        {
            LocalDrivingLicenseApplicationID = localDrivingLicenseApplicationID;
            ApplicationID = applicationID;
            LicenseCategoryID = licenseCategoryID;
        }

        public int LocalDrivingLicenseApplicationID { get; private set; }
        public int LicenseCategoryID { get; set; }
        public int PassedTestsNumber { get => LocalDrivingLicenseApplicationRepo.PassedTestsNumber(LocalDrivingLicenseApplicationID); }
       
        public LicenseCategory? LicenseCategory { get => LicenseCategory.GetCategory(LicenseCategoryID); }

        public static DataTable? GetAll()
        {
            return LocalDrivingLicenseApplicationRepo.GetAll();
        }

        private bool AddNew()
        {
            this.LocalDrivingLicenseApplicationID = LocalDrivingLicenseApplicationRepo.Create(base.ApplicationID, this.LicenseCategoryID);
            return this.LocalDrivingLicenseApplicationID != -1;
        }

        public override bool Save()
        {
            bool save = false;
            save = base.Save();
            if (save)
            {
                save = AddNew();
            }
            return save;
        }

        public static bool HaveNewApplication(int applicantPersonID, int licenseCategoryID)
        {
            return LocalDrivingLicenseApplicationRepo.HaveApplicationWithStatus(applicantPersonID, licenseCategoryID, Convert.ToInt16(ApplicationStatus.New));
        }

        public static bool HaveCompletedApplication(int applicantPersonID, int licenseCategoryID)
        {
            return LocalDrivingLicenseApplicationRepo.HaveApplicationWithStatus(applicantPersonID, licenseCategoryID, Convert.ToInt16(ApplicationStatus.Completed));
        }

        public new static LocalDrivingLicenseApplication? GetApplication(int LocalDrivingLicenseApplicationID)
        {
            int applicationID = -1, LicenseCategoryID = -1, ApplicantPersonID = -1, ApplicationTypeID = -1, CreatedByUserID = -1;
            DateTime ApplicationDate = DateTime.MinValue;
            int ApplicationStatus = -1;
            DateTime LastStatusDate = DateTime.MinValue;
            decimal PaidFees = -1;

            bool IsFound = LocalDrivingLicenseApplicationRepo.Read(LocalDrivingLicenseApplicationID, ref applicationID,
                ref LicenseCategoryID, ref ApplicantPersonID, ref ApplicationDate, ref ApplicationTypeID,
                ref ApplicationStatus, ref LastStatusDate, ref PaidFees, ref CreatedByUserID);

            if (IsFound)
            {
                return new LocalDrivingLicenseApplication(LocalDrivingLicenseApplicationID, applicationID, LicenseCategoryID
                    , ApplicantPersonID, ApplicationDate, ApplicationTypeID, (ApplicationStatus)ApplicationStatus,
                    LastStatusDate, PaidFees, CreatedByUserID);
            }
            return null;
        }

        public int FailedTestTrials(TestTypes type)
        {
            return LocalDrivingLicenseApplicationRepo.FailedTestTrials(this.LocalDrivingLicenseApplicationID, (int)type);
        }

        public new static bool DeleteApplication(int lDLApplicationID)
        {
            LocalDrivingLicenseApplication? application = GetApplication(lDLApplicationID);
            if (application is null) return false;

            return LocalDrivingLicenseApplicationRepo.Delete(lDLApplicationID) && Application.DeleteApplication(application.ApplicationID);
        }

        public bool HavePassedTest(TestTypes type)
        {
            return LocalDrivingLicenseApplicationRepo.HavePassedTest(this.LocalDrivingLicenseApplicationID, (int)type);
        }

        public bool HaveFailedTest(TestTypes type)
        {
            return LocalDrivingLicenseApplicationRepo.HaveFailedTest(this.LocalDrivingLicenseApplicationID, (int)type);
        }
    }
}
