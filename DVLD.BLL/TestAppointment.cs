using DVLD.DAL;
using System.Data;

namespace DVLD.BLL
{
    public class TestAppointment
    {
        private Mode mode;
        public TestAppointment()
        {
            TestAppointmentID = -1;
            TestType = 0;
            LocalDrivingLicenseApplicationID = -1;
            AppointmentDate = DateTime.MinValue;
            PaidFees = -1;
            CreatedByUserID = -1;
            IsLocked = true;

            mode = Mode.AddNew;
        }

        private TestAppointment(int testAppointmentID, TestTypes testTypeID, int localDrivingLicenseApplicationID,
            DateTime appointmentDate, decimal paidFees, int createdByUserID, bool isLocked, int retakeTestApplicationID)
        {
            TestAppointmentID = testAppointmentID;
            TestType = testTypeID;
            LocalDrivingLicenseApplicationID = localDrivingLicenseApplicationID;
            AppointmentDate = appointmentDate;
            PaidFees = paidFees;
            CreatedByUserID = createdByUserID;
            IsLocked = isLocked;
            RetakeTestApplicationID = retakeTestApplicationID;


            mode = Mode.Update;
        }

        public int TestAppointmentID { get; private set; }
        public TestTypes TestType { get; set; }
        public int LocalDrivingLicenseApplicationID { get; set; }
        public DateTime AppointmentDate { get; set; }
        public decimal PaidFees { get; set; }
        public int CreatedByUserID { get; set; }
        public bool IsLocked { get; set; }
        public int RetakeTestApplicationID { get; set; }
        public Application? RetakeTestApplication { get => Application.GetApplication(RetakeTestApplicationID); }
        public LicenseCategory? LicenseCategory { get => LocalDrivingLicenseApplication.GetApplication(LocalDrivingLicenseApplicationID)?.LicenseCategory; }
        public Person? Person  { get => LocalDrivingLicenseApplication.GetApplication(LocalDrivingLicenseApplicationID)?.Person; }
        public int Trial { get => LocalDrivingLicenseApplication.GetApplication(LocalDrivingLicenseApplicationID).FailedTestTrials(this.TestType) +1; }

        public static DataTable? GetApplicationAppointments(int localDrivingLicenseApplicationID, TestTypes type)
        {
            return TestAppointmentRepo.GetApplicationAppointments(localDrivingLicenseApplicationID, (Int32)type);
        }

        public bool Save()
        {
            bool save = false;
            switch (mode)
            {
                case Mode.AddNew:
                    save = AddNew();
                    if (save) mode = Mode.Update;
                    break;
                case Mode.Update:
                    save = UpdateAppointmentDate();
                    if (save) mode = Mode.AddNew;
                    break;
            }
            return save;
        }

        private bool UpdateAppointmentDate()
        {
            TestAppointment? appointment = GetAppointment(this.TestAppointmentID);
            if (appointment is not null)
                return TestAppointmentRepo.UpdateDate(appointment.TestAppointmentID, this.AppointmentDate);
            return false;
        }

        private bool AddNew()
        {
            this.TestAppointmentID = TestAppointmentRepo.Create((int)this.TestType, this.LocalDrivingLicenseApplicationID,
                this.AppointmentDate, this.PaidFees, this.CreatedByUserID, false);

            return this.TestAppointmentID != -1;
        }

        internal static bool LockAppointment(int appointmentID)
        {
            return TestAppointmentRepo.LockAppointment(appointmentID);
        }

        public static TestAppointment? GetAppointment(int appointmentID)
        {
            int TestTypeID = -1;
            int LocalDrivingLicenseApplicationID = -1;
            DateTime AppointmentDate = DateTime.MinValue;
            decimal PaidFees = -1;
            int CreatedByUserID = -1;
            bool IsLocked = true;
            int retakeTestApplicationID = -1;

            bool isFound = TestAppointmentRepo.Read(appointmentID, ref TestTypeID, ref LocalDrivingLicenseApplicationID,
                ref AppointmentDate, ref PaidFees, ref CreatedByUserID, ref IsLocked, ref retakeTestApplicationID);

            if (isFound)
                return new TestAppointment(appointmentID, (TestTypes)TestTypeID, LocalDrivingLicenseApplicationID,
                    AppointmentDate, PaidFees, CreatedByUserID, IsLocked, retakeTestApplicationID);

            return null;
        }
    }
}