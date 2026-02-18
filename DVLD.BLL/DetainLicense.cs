using DVLD.DAL;

namespace DVLD.BLL
{
    public class DetainLicense
    {
        public DetainLicense()
        {
            DetainID = -1;
            LicenseID = -1;
            DetaineDate = DateTime.MinValue;
            FineFees = -1;
            CreatedByUserID = -1;
            IsReleased = false;
            ReleaseDate = DateTime.MinValue;
            ReleasedByUserID = -1;
            ReleaseApplicationID = -1;
        }

        private DetainLicense(int detaineID, int licenseID, DateTime detaineDate, decimal fineFees,
            int createdByUserID, bool isReleased, DateTime releaseDate, int releasedByUserID, int releaseApplicationID)
        {
            DetainID = detaineID;
            LicenseID = licenseID;
            DetaineDate = detaineDate;
            FineFees = fineFees;
            CreatedByUserID = createdByUserID;
            IsReleased = isReleased;
            ReleaseDate = releaseDate;
            ReleasedByUserID = releasedByUserID;
            ReleaseApplicationID = releaseApplicationID;
        }

        public int DetainID { get; private set; }
        public int LicenseID { get; set; }
        public DateTime DetaineDate { get; set; }
        public decimal FineFees { get; set; }
        public int CreatedByUserID { get; set; }
        public bool IsReleased { get; private set; }
        public DateTime ReleaseDate { get; set; }
        public int ReleasedByUserID { get; set; }
        public int ReleaseApplicationID { get; set; }

        public static DetainLicense? GetDetainInfo(int licenseID)
        {
            int DetaineID = -1;
            DateTime DetaineDate = DateTime.MinValue;
            decimal FineFees = -1;
            int CreatedByUserID = -1;
            bool IsReleased = false;
            DateTime ReleaseDate = DateTime.MaxValue;
            int ReleasedByUserID = -1;
            int ReleaseApplicationID = -1;

            bool isFound = DetainedLicenseRepo.Read(licenseID, ref DetaineID, ref DetaineDate, ref FineFees,
                ref CreatedByUserID, ref IsReleased, ref ReleaseDate, ref ReleasedByUserID, ref ReleaseApplicationID);

            if (isFound)
                return new DetainLicense(DetaineID, licenseID, DetaineDate, FineFees, CreatedByUserID,
                    IsReleased, ReleaseDate, ReleasedByUserID, ReleaseApplicationID);

            return null;
        }

        public bool Detain()
        {
            this.DetainID = DetainedLicenseRepo.Create(this.LicenseID, this.DetaineDate, this.FineFees,
                this.CreatedByUserID, this.IsReleased);

            return this.DetainID != -1;
        }

        public bool Release()
        {
            this.IsReleased = true;
            return DetainedLicenseRepo.Release(this.DetainID, this.IsReleased, this.ReleaseDate, this.ReleasedByUserID, this.ReleaseApplicationID);
        }
    }
}
