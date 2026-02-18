
using DVLD.DAL;

namespace DVLD.BLL
{
    public class Test
    {
        public Test()
        {
            TestID = -1;
            TestAppointmentID = -1;
            TestResult = 0;
            Notes = "";
            CreatedByUserID = -1;
        }

        public int TestID { get; private set; }
        public int TestAppointmentID { get; set; }
        public TestResult TestResult { get; set; }
        public string Notes { get; set; }
        public int CreatedByUserID { get; set; }
        public TestAppointment? TestAppointment { get => TestAppointment.GetAppointment(TestAppointmentID); }

        public bool Save()
        {
            this.TestID = TestRepo.Create(this.TestAppointmentID, Convert.ToBoolean(this.TestResult), this.Notes, this.CreatedByUserID);

            return (this.TestID != -1 && TestAppointment.LockAppointment(this.TestAppointmentID));
        }
    }
}
