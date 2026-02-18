using Microsoft.Data.SqlClient;
using System.Data;

namespace DVLD.DAL
{
    public static class TestRepo
    {
        public static int Create(int testAppointmentID, bool testResult, string notes, int createdByUserID)
        {
            string storedProdedureName = "SP_AddNewTest";

            SqlParameter testAppointmentIDParameter = new SqlParameter("@TestAppointmentID", SqlDbType.Int) { Value = testAppointmentID };
            SqlParameter testResultParameter = new SqlParameter("@TestResult", SqlDbType.Bit) { Value = testResult };
            SqlParameter notesParameter = new SqlParameter("@Notes", SqlDbType.NVarChar) { Value = notes };
            SqlParameter createdByUserIDParameter = new SqlParameter("@CreatedByUserID", SqlDbType.Int) { Value = createdByUserID };

            return CommonRepos.ReturnValue(storedProdedureName, testAppointmentIDParameter, testResultParameter, notesParameter, createdByUserIDParameter);
        }

    }
}
