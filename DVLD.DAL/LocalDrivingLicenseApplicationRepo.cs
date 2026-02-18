using Microsoft.Data.SqlClient;
using System.Data;
using static Azure.Core.HttpHeader;

namespace DVLD.DAL
{
    public static class LocalDrivingLicenseApplicationRepo
    {
        public static int Create(int applicationID, int licenseCategoryID)
        {
            string storedProcedureName = "SP_AddNewLocalDrivingLicenseApplication";

            SqlParameter applicationIDParameter = new SqlParameter("@ApplicationID", SqlDbType.Int) { Value = applicationID };
            SqlParameter licenseCategoryIDParameter = new SqlParameter("@LicenseClassID", SqlDbType.Int) { Value = licenseCategoryID };

            return CommonRepos.ReturnValue(storedProcedureName, applicationIDParameter, licenseCategoryIDParameter);
        }

        public static bool Delete(int lDLApplicationID)
        {
            string storedProcedureName = "SP_DeleteLocalDrivingLicenseApplication";

            SqlParameter lDLApplicationIDParameter = new SqlParameter("@LocalDrivingLicenseApplicationID", SqlDbType.Int) { Value = lDLApplicationID };

            return CommonRepos.ExecuteNonQuery(storedProcedureName, lDLApplicationIDParameter);
        }

        public static int FailedTestTrials(int localDrivingLicenseApplicationID, int testType)
        {
            string storedProcedureName = "SP_GetFailedTestTrialsForLocalDrivingLicenseApplication";

            SqlParameter localDrivingLicenseApplicationIDParameter = new SqlParameter("@LocalDrivingLicenseApplicationID", SqlDbType.Int) { Value = localDrivingLicenseApplicationID };
            SqlParameter testTypeParameter = new SqlParameter("@TestTypeID", SqlDbType.Int) { Value = testType };

            return CommonRepos.ReturnValue(storedProcedureName, localDrivingLicenseApplicationIDParameter, testTypeParameter);
        }

        public static DataTable? GetAll()
        {
            string storedProcedureName = "SP_GetLocalDrivingLicenseApplicationTable";

            return CommonRepos.GetAll(storedProcedureName);
        }

        public static bool HaveApplicationWithStatus(int applicantPersonID, int licenseCategoryID, short applicationStatus)
        {
            string storedProcedureName = "SP_CheckLocalDrivingApplicationExistsWithStatus";

            SqlParameter applicantPersonIDParameter = new SqlParameter("@ApplicantPersonID", SqlDbType.Int) { Value = applicantPersonID };
            SqlParameter licenseCategoryIDParameter = new SqlParameter("@LicenseClassID", SqlDbType.Int) { Value = licenseCategoryID };
            SqlParameter applicationStatusParameter = new SqlParameter("@ApplicationStatus", SqlDbType.TinyInt) { Value = applicationStatus };

            return CommonRepos.CheckTruefalse(storedProcedureName, applicantPersonIDParameter, licenseCategoryIDParameter, applicationStatusParameter);
        }

        public static bool HaveFailedTest(int localDrivingLicenseApplicationID, int testTypeID)
        {
            string storedProcedureName = "SP_ChackFailedTest";

            SqlParameter localDrivingLicenseApplicationIDParameter = new SqlParameter("@LocalDrivingLicenseApplicationID", SqlDbType.Int) { Value = localDrivingLicenseApplicationID };
            SqlParameter typeParameter = new SqlParameter("@TestTypeID", SqlDbType.Int) { Value = testTypeID };

            return CommonRepos.CheckTruefalse(storedProcedureName, localDrivingLicenseApplicationIDParameter, typeParameter);
        }

        public static bool HavePassedTest(int localDrivingLicenseApplicationID, int testTypeID)
        {
            string storedProcedureName = "SP_ChackPassedTest";

            SqlParameter localDrivingLicenseApplicationIDParameter = new SqlParameter("@LocalDrivingLicenseApplicationID", SqlDbType.Int) { Value = localDrivingLicenseApplicationID };
            SqlParameter typeParameter = new SqlParameter("@TestTypeID", SqlDbType.Int) { Value = testTypeID };

            return CommonRepos.CheckTruefalse(storedProcedureName, localDrivingLicenseApplicationIDParameter, typeParameter);
        }

        public static int PassedTestsNumber(int localDrivingLicenseApplicationID)
        {
            string storedProcedureName = "SP_GetPassedTestsNumber";

            SqlParameter localDrivingLicenseApplicationIDParameter = new SqlParameter("@LocalDrivingLicenseApplicationID", SqlDbType.Int) { Value = localDrivingLicenseApplicationID };

            return CommonRepos.ReturnValue(storedProcedureName, localDrivingLicenseApplicationIDParameter);
        }

        public static bool Read(int localDrivingLicenseApplicationID, ref int applicationID, ref int licenseCategoryID,
            ref int applicantPersonID, ref DateTime applicationDate, ref int applicationTypeID, ref int applicationStatus,
            ref DateTime lastStatusDate, ref decimal paidFees, ref int createdByUserID)
        {
            string storedProcedureName = "SP_FindLocalDrivingLicenseByLDLAppID";

            SqlParameter localDrivingLicenseApplicationIDParameter = new SqlParameter("@LocalDrivingLicenseApplicationID", SqlDbType.Int) { Value = localDrivingLicenseApplicationID };

            

            using (SqlConnection connection = new SqlConnection(DbHelper.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(storedProcedureName, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(localDrivingLicenseApplicationIDParameter);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (!reader.Read())
                                return false;

                            applicationID = reader.GetInt32(reader.GetOrdinal("ApplicationID"));
                            licenseCategoryID = reader.GetInt32(reader.GetOrdinal("LicenseClassID"));
                            applicantPersonID = reader.GetInt32(reader.GetOrdinal("ApplicantPersonID"));
                            applicationDate = reader.GetDateTime(reader.GetOrdinal("ApplicationDate"));
                            applicationTypeID = reader.GetInt32(reader.GetOrdinal("ApplicationTypeID"));
                            applicationStatus = reader.GetByte(reader.GetOrdinal("ApplicationStatus"));
                            lastStatusDate = reader.GetDateTime(reader.GetOrdinal("LastStatusDate"));
                            paidFees = reader.GetDecimal(reader.GetOrdinal("PaidFees"));
                            createdByUserID = reader.GetInt32(reader.GetOrdinal("CreatedByUserID"));






                            return true;
                        }
                    }
                    catch
                    {
                        return false;
                    }
                }
            }
        }

    }
}
