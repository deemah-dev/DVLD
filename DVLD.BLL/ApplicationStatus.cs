namespace DVLD.BLL
{
    public enum ApplicationStatus
    {
        New = 1,
        Cancled = 2,
        Completed  = 3
    }

    public enum IssueLicenseReson
    {
        FirstTime = 1,
        Renew = 2,
        ReplacingDamagedLicense = 3,
        ReplacingLosedLicense = 4
    }

    public enum Gender
    {
        Male = 0,
        Female = 1
    }

    public enum TestResult
    {
        Failed = 0,
        Passed = 1
    }

    public enum Mode
    { 
        AddNew,
        Update
    };

    public enum PassedTests
    {
        None = 0,
        Vision = 1,
        Written = 2,
        All = 3
    }

    public enum TestTypes
    {
        Vision = 1,
        Writtin  =2,
        Street  =3
    }

    public enum ApplicationTypes
    {
        NewLocalDrivingLicenseService = 1,
        RenewDrivingLicenseService = 2,
        ReplacementforaLostDrivingLicense = 3,
        ReplacementforaDamagedDrivingLicense = 4,
        ReleaseDetainedDrivingLicsense = 5,
        NewInternationalLicense = 6,
        RetakeTest = 7
    }

    public enum LicenseCategories
    {
        SmallMotorcycle = 1,
        HeavyMotorcycleLicense = 2,
        OrdinaryDrivingLicense = 3,
        Commercial = 4,
        Agricultural = 5,
        SmallAndMediumBus = 6,
        TruckAndHeavyVehicle = 7
    }

    public enum ReplacementLicneseReason
    {
        DamagedLicense,
        LostLicense
    }
}