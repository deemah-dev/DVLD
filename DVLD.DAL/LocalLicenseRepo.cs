using Microsoft.Data.SqlClient;
using System.Data;

namespace DVLD.DAL
{
    public static class LocalLicenseRepo
    {
        public static int Create(int applicationID, int driverID, int licenseCategoryID, DateTime issueDate, DateTime expirationDate, string notes, decimal paidFees, bool isActive, short issueReason, int createdByUserID)
        {
            string storedProcedureName = "SP_AddNewLocalDrivingLicense";

            SqlParameter applicationIDParameter = new SqlParameter("@ApplicationID", SqlDbType.Int) { Value = applicationID };
            SqlParameter driverIDParameter = new SqlParameter("@DriverID", SqlDbType.Int) { Value = driverID };
            SqlParameter licenseCategoryIDParameter = new SqlParameter("@LicenseClassID", SqlDbType.Int) { Value = licenseCategoryID };
            SqlParameter issueDateParameter = new SqlParameter("@IssueDate", SqlDbType.DateTime) { Value = issueDate };
            SqlParameter expirationDateParameter = new SqlParameter("@ExpirationDate", SqlDbType.DateTime) { Value = expirationDate };
            SqlParameter notesParameter = new SqlParameter("@Notes", SqlDbType.NVarChar) { Value = notes };
            SqlParameter paidFeesParameter = new SqlParameter("@PaidFees", SqlDbType.Decimal) { Value = paidFees };
            SqlParameter isActiveParameter = new SqlParameter("@IsActive", SqlDbType.Bit) { Value = isActive };
            SqlParameter issueReasonParameter = new SqlParameter("@IssueReason", SqlDbType.TinyInt) { Value = issueReason };
            SqlParameter createdByUserIDParameter = new SqlParameter("@CreatedByUserID", SqlDbType.Int) { Value = createdByUserID };

            return CommonRepos.ReturnValue(storedProcedureName, applicationIDParameter, driverIDParameter,
                licenseCategoryIDParameter, issueDateParameter, expirationDateParameter, notesParameter,
                paidFeesParameter, isActiveParameter, issueReasonParameter, createdByUserIDParameter);
        }

        public static bool ReadByApplicationID(int applicationID, ref int licenseID, ref int driverID, ref int licenseCategoryID,
            ref DateTime issueDate, ref DateTime expirationDate, ref string notes, ref decimal paidFees, ref bool isActive, ref short issueReason, ref int createdByUserID)
        {
            string storedProcedureName = "SP_FindLocalDrivingLicenseByApplicationID";

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

                            licenseID = reader.GetInt32(reader.GetOrdinal("LicenseID"));
                            driverID = reader.GetInt32(reader.GetOrdinal("DriverID"));
                            licenseCategoryID = reader.GetInt32(reader.GetOrdinal("LicenseClass"));
                            issueDate = reader.GetDateTime(reader.GetOrdinal("IssueDate"));
                            expirationDate = reader.GetDateTime(reader.GetOrdinal("ExpirationDate"));
                            notes = reader.GetString(reader.GetOrdinal("Notes"));
                            paidFees = reader.GetDecimal(reader.GetOrdinal("PaidFees"));
                            isActive = reader.GetBoolean(reader.GetOrdinal("IsActive"));
                            issueReason = reader.GetByte(reader.GetOrdinal("IssueReason"));
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

        public static bool Read(int licenseID, ref int applicationID, ref int driverID, ref int licenseCategoryID, ref DateTime issueDate, ref DateTime expirationDate, ref string notes, ref decimal paidFees, ref bool isActive, ref short issueReason, ref int createdByUserID)
        {
            string storedProcedureName = "SP_FindLocalDrivingLicenseByLicenseID";

            SqlParameter licenseIDParameter = new SqlParameter("@LicenseID", SqlDbType.Int) { Value = licenseID };

            
            using (SqlConnection connection = new SqlConnection(DbHelper.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(storedProcedureName, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(licenseIDParameter);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (!reader.Read())
                                return false;

                            applicationID = reader.GetInt32(reader.GetOrdinal("ApplicationID"));
                            driverID = reader.GetInt32(reader.GetOrdinal("DriverID"));
                            licenseCategoryID = reader.GetInt32(reader.GetOrdinal("LicenseClass"));
                            issueDate = reader.GetDateTime(reader.GetOrdinal("IssueDate"));
                            expirationDate = reader.GetDateTime(reader.GetOrdinal("ExpirationDate"));
                            notes = reader.GetString(reader.GetOrdinal("Notes"));
                            paidFees = reader.GetDecimal(reader.GetOrdinal("PaidFees"));
                            isActive = reader.GetBoolean(reader.GetOrdinal("IsActive"));
                            issueReason = reader.GetByte(reader.GetOrdinal("IssueReason"));
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

        public static bool DeactivateLicense(int licenseID)
        {
            string storedProcedureName = "SP_DeactivateLocalDrivingLicense";

            SqlParameter licenseIDParameter = new SqlParameter("@LicenseID", SqlDbType.Int) { Value = licenseID };

            return CommonRepos.ExecuteNonQuery(storedProcedureName, licenseIDParameter);
        }
    }
}
