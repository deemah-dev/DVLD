using Microsoft.Data.SqlClient;
using System.Data;
using System.Net;
using System.Numerics;
using System.Reflection;

namespace DVLD.DAL
{
    public static class ApplicationRepo
    {
        public static int Create(int applicantPersonID, DateTime applicationDate, int applicationTypeID, int applicationStatus, DateTime lastStatusDate, decimal paidFees, int createdByUserID)
        {
            string storedProcedureName = "SP_AddNewApplication";

            SqlParameter applicantPersonIDParameter = new SqlParameter("@ApplicantPersonID", SqlDbType.Int) { Value = applicantPersonID };
            SqlParameter applicationDateParameter = new SqlParameter("@ApplicationDate", SqlDbType.DateTime) { Value = applicationDate };
            SqlParameter applicationTypeIDParameter = new SqlParameter("@ApplicationTypeID", SqlDbType.Int) { Value = applicationTypeID };
            SqlParameter statusParameter = new SqlParameter("@ApplicationStatus", SqlDbType.TinyInt) { Value = applicationStatus };
            SqlParameter lastStatusDateParameter = new SqlParameter("@LastStatusDate", SqlDbType.DateTime) { Value = lastStatusDate };
            SqlParameter paidFeesParameter = new SqlParameter("@PaidFees", SqlDbType.Decimal) { Value = paidFees };
            SqlParameter createdByUserIDParameter = new SqlParameter("@CreatedByUserID", SqlDbType.Int) { Value = createdByUserID };

            return CommonRepos.ReturnValue(storedProcedureName, applicantPersonIDParameter,
                applicationDateParameter, applicationTypeIDParameter, statusParameter,
                lastStatusDateParameter, paidFeesParameter, createdByUserIDParameter);
        }

        public static bool Delete(int applicationID)
        {
            string storedProcedureName = "SP_DeleteApplication";

            SqlParameter applicationIDParameter = new SqlParameter("@ApplicationID", SqlDbType.Int) { Value = applicationID };

            return CommonRepos.ExecuteNonQuery(storedProcedureName, applicationIDParameter);
        }

        public static bool Read(int applicationID, ref int applicantPersonID, ref DateTime applicationDate, ref int applicationTypeID,
            ref int applicationStatus, ref DateTime lastStatusDate, ref decimal paidFees, ref int createdByUserID)
        {
            string storedProcedureName = "SP_FindApplication";

            SqlParameter applicationIDParameter = new SqlParameter("@ApplicationID", SqlDbType.Int) { Value = applicationID };

          

            using (SqlConnection connection = new SqlConnection(DbHelper.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(storedProcedureName, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(applicationIDParameter);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (!reader.Read())
                                return false;

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

        public static bool UpdateApplicationStatus(int applicationID, int status)
        {
            string storedProcedureName = "SP_UpdateApplicationStatus";

            SqlParameter applicationIDParameter = new SqlParameter("@ApplicationID", SqlDbType.Int) { Value = applicationID };
            SqlParameter statusParameter = new SqlParameter("@ApplicationStatus", SqlDbType.TinyInt) { Value = status };

            return CommonRepos.ExecuteNonQuery(storedProcedureName, applicationIDParameter, statusParameter);
        }

    }
}
