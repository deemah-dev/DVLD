
using DVLD.DAL;

namespace DVLD.BLL
{
    public class LocalLicense
    {
        public LocalLicense()
        {
            LicenseID = -1;
            ApplicationID = -1;
            DriverID = -1;
            LicenseCategoryID = -1;
            Notes = "";
            IssueDate = DateTime.Now;
            ExpirationDate = DateTime.MinValue;
            PaidFees = -1;
            IsActive = true;
            IssueReason = IssueLicenseReson.FirstTime;
            CreatedByUserID = -1;
        }

        private LocalLicense(int licenseID, int applicationID, int driverID, int licenseCategoryID, string notes,
            DateTime issueDate,DateTime expirationDate, decimal paidFees, bool isActive,
            IssueLicenseReson issueReason, int createdByUserID)
        {
            LicenseID = licenseID;
            ApplicationID = applicationID;
            DriverID = driverID;
            LicenseCategoryID = licenseCategoryID;
            Notes = notes;
            IssueDate = issueDate;
            ExpirationDate = expirationDate;
            PaidFees = paidFees;
            IsActive = isActive;
            IssueReason = issueReason;
            CreatedByUserID = createdByUserID;
        }

        public int LicenseID { get; private set; }
        public int ApplicationID { get; set; }
        public int DriverID { get; set; }
        public int LicenseCategoryID { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpirationDate { get; private set; }
        public string Notes { get; set; }
        public decimal PaidFees { get; private set; }
        public bool IsActive { get; set; }
        public IssueLicenseReson IssueReason { get; set; }
        public int CreatedByUserID { get; set; }

        public bool IsDetaind { get { return IsDetaindLicense(LicenseID); } }

        public Application? Application { get => Application.GetApplication(this.ApplicationID); }

        public Driver? Driver { get => Driver.GetDriver(DriverID); private set; }

        public LicenseCategory? LicenseCategory { get => LicenseCategory.GetCategory(this.LicenseCategoryID); }
        private bool AddNew()
        {
            if (Application is null) return false;
            if (Driver is null)
            {
                Driver driver = new();
                driver.PersonID = Application.ApplicantPersonID;
                driver.CreatedByUserID = Application.CreatedByUserID;
                driver.CreatedDate = DateTime.Now;
                if (!driver.Save()) return false;
                Driver = driver;
            }

            if (LicenseCategory?.CategoryFees == -1) return false;

            DateTime expirationDate = this.IssueDate.AddYears(Convert.ToInt32(LicenseCategory.GetCategory(LicenseCategoryID)?.ValidityLength));

            this.LicenseID = LocalLicenseRepo.Create(this.ApplicationID, Driver.DriverID, this.LicenseCategoryID,
                this.IssueDate, expirationDate, this.Notes, LicenseCategory.CategoryFees, this.IsActive, Convert.ToInt16(this.IssueReason), this.CreatedByUserID);

            return (this.LicenseID != -1 && this.Application.CompleteApplication());
        }

        public bool Save()
        {
            return AddNew();
        }

        public static LocalLicense? GetLicenseByApplicationID(int applicationID)
        {
            int LicenseID = -1, DriverID = -1, LicenseCategoryID = -1;
            DateTime IssueDate = DateTime.MinValue;
            DateTime ExpirationDate = DateTime.MinValue;
            string Notes = "";
            decimal PaidFees = -1;
            bool IsActive = false;
            short IssueReason = -1;
            int CreatedByUserID = -1;

            bool isFound = LocalLicenseRepo.ReadByApplicationID(applicationID, ref LicenseID, ref DriverID,
                ref LicenseCategoryID, ref IssueDate, ref ExpirationDate, ref Notes,
                ref PaidFees, ref IsActive, ref IssueReason, ref CreatedByUserID);

            if (isFound)
                return new LocalLicense(LicenseID, applicationID, DriverID, LicenseCategoryID,
                    Notes, IssueDate, ExpirationDate, PaidFees, IsActive, (IssueLicenseReson)IssueReason, CreatedByUserID);

            return null;

        }

        public static LocalLicense? GetLicense(int licenseID)
        {
            int ApplicationID = -1, DriverID = -1, LicenseCategoryID = -1;
            DateTime IssueDate = DateTime.MinValue;
            DateTime ExpirationDate = DateTime.MinValue;
            string Notes = "";
            decimal PaidFees = -1;
            bool IsActive = false;
            short IssueReason = -1;
            int CreatedByUserID = -1;

            bool isFound = LocalLicenseRepo.Read(licenseID, ref ApplicationID, ref DriverID,
                ref LicenseCategoryID, ref IssueDate, ref ExpirationDate, ref Notes,
                ref PaidFees, ref IsActive, ref IssueReason, ref CreatedByUserID);

            if (isFound)
                return new LocalLicense(licenseID, ApplicationID, DriverID, LicenseCategoryID,
                    Notes, IssueDate, ExpirationDate, PaidFees, IsActive, (IssueLicenseReson)IssueReason, CreatedByUserID);

            return null;

        }

        private static bool IsDetaindLicense(int licenseID)
        {
            return DetainedLicenseRepo.IsExist(licenseID);
        }

        public static LocalLicense? RenewLicense(LocalLicense oldLicense, int applicationID, DateTime issueDate, string notes, int createdByUserID, out int licenseID)
        {
            DateTime expirationDate = oldLicense.IssueDate.AddYears(Convert.ToInt32(LicenseCategory.GetCategory(oldLicense.LicenseCategoryID)?.ValidityLength));

            licenseID = LocalLicenseRepo.Create(applicationID, oldLicense.DriverID, oldLicense.LicenseCategoryID,
                issueDate, expirationDate, notes, oldLicense.PaidFees, oldLicense.IsActive,
                Convert.ToInt16(IssueLicenseReson.Renew), createdByUserID);

            if (licenseID != -1 && oldLicense.Deactivate())
            {
                return GetLicense(licenseID);
            }
            return null;
        }

        private bool Deactivate()
        {
            return LocalLicenseRepo.DeactivateLicense(this.LicenseID);
        }

        public static LocalLicense? ReplaceLicense(LocalLicense oldLicense, ReplacementLicneseReason replacementReason,
            int applicationID, string notes, int createdByUserID, out int licenseID)
        {
            short issueReason = -1;
            switch (replacementReason)
            {
                case ReplacementLicneseReason.LostLicense:
                    issueReason = Convert.ToInt16(IssueLicenseReson.ReplacingLosedLicense);
                    break;
                case ReplacementLicneseReason.DamagedLicense:
                    issueReason = Convert.ToInt16(IssueLicenseReson.ReplacingDamagedLicense);
                    break;
            }

            licenseID = LocalLicenseRepo.Create(applicationID, oldLicense.DriverID, oldLicense.LicenseCategoryID,
                oldLicense.IssueDate, oldLicense.ExpirationDate, notes, oldLicense.PaidFees, oldLicense.IsActive, issueReason, createdByUserID);

            if(licenseID != -1 && oldLicense.Deactivate())
            {
                return GetLicense(licenseID);
            }
            return null;
        }
    }
}