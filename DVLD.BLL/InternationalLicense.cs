using DVLD.DAL;

namespace DVLD.BLL
{
    public class InternationalLicense : Application
    {
        public InternationalLicense()
        {
            InternationalLicenseID = -1;
            ApplicationID = -1;
            DriverID = -1;
            IssuedUsingLocalLicenseID = -1;
            IssueDate = DateTime.MinValue ;
            IsActive = true ;
            CreatedByUserID = -1;
        }

        public int InternationalLicenseID { get; private set; }
        public int ApplicationID { get; set; }
        public int DriverID { get; set; }
        public int IssuedUsingLocalLicenseID { get; set; }
        public DateTime IssueDate { get; set; }
        public DateTime ExpirationDate { get { return CalculateExpirationDate(); }}
        public bool IsActive { get; set; }
        public int CreatedByUserID { get; set; }

        private DateTime CalculateExpirationDate()
        {
            int licenseCategoryID = Convert.ToInt32(LicenseCategories.OrdinaryDrivingLicense);
            int validityLength = Convert.ToInt32(LicenseCategory.GetCategory(licenseCategoryID)?.ValidityLength);
            return this.IssueDate.AddYears(validityLength);
        }

        private bool AddNew()
        {
            this.InternationalLicenseID = InternationalLicenseRepo.Create(this.ApplicationID, this.DriverID,
                this.IssuedUsingLocalLicenseID, this.IssueDate, this.ExpirationDate, this.IsActive, this.CreatedByUserID);

            return this.InternationalLicenseID != -1;
        }

        public static bool IsExist(int localLicenseID)
        {
            return InternationalLicenseRepo.IsExist(localLicenseID);
        }

        public bool Save()
        {
            return AddNew();
        }
    }
}
