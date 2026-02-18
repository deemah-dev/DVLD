using Microsoft.Data.SqlClient;
using System.Data;

namespace DVLD.DAL
{
    public static class DetainedLicenseRepo
    {
        public static int Create(int licenseID, DateTime detaineDate, decimal fineFees, int createdByUserID, bool isReleased)
        {
            string storedProcedureName = "SP_AddNewDetainedDrivingLicense";

            SqlParameter licenseIDParameter = new SqlParameter("@LicenseID", SqlDbType.Int) { Value = licenseID };
            SqlParameter detaineDateParameter = new SqlParameter("@DetainDate", SqlDbType.DateTime) { Value = detaineDate };
            SqlParameter fineFeesParameter = new SqlParameter("@FineFees", SqlDbType.Decimal) { Value = fineFees };
            SqlParameter createdByUserIDParameter = new SqlParameter("@CreatedByUserID", SqlDbType.Int) { Value = createdByUserID };

             return CommonRepos.ReturnValue(storedProcedureName, licenseIDParameter, detaineDateParameter,
                fineFeesParameter, createdByUserIDParameter);
        }

        public static bool Read(int licenseID, ref int detainID, ref DateTime detaineDate, ref decimal fineFees,
            ref int createdByUserID, ref bool isReleased, ref DateTime releaseDate, ref int releasedByUserID, ref int releaseApplicationID)
        {
            string storedProcedureName = "SP_FindDetainedDrivingLicense";

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

                            detainID = reader.GetInt32(reader.GetOrdinal("DetainID"));
                            detaineDate = reader.GetDateTime(reader.GetOrdinal("DetainDate"));
                            fineFees = reader.GetDecimal(reader.GetOrdinal("FineFees"));
                            createdByUserID = reader.GetInt32(reader.GetOrdinal("CreatedByUserID"));
                            isReleased = reader.GetBoolean(reader.GetOrdinal("IsReleased"));
                            releaseDate = reader.IsDBNull(reader.GetOrdinal("ReleaseDate"))? DateTime.MinValue : reader.GetDateTime(reader.GetOrdinal("ReleaseDate"));

                            releasedByUserID = reader.IsDBNull(reader.GetOrdinal("ReleasedByUserID"))? -1 : reader.GetInt32(reader.GetOrdinal("ReleasedByUserID"));

                            releaseApplicationID = reader.IsDBNull(reader.GetOrdinal("ReleaseApplicationID"))? -1 : reader.GetInt32(reader.GetOrdinal("ReleaseApplicationID"));




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

        public static bool Release(int detainID, bool isReleased, DateTime realeaseDate, int releasedByUserID, int releaseApplicationID)
        {
            string storedProcedureName = "SP_ReleaseDetainedDrivingLicense";

            SqlParameter detainIDParameter = new SqlParameter("@DetainID", SqlDbType.Int) { Value = detainID };
            SqlParameter isReleasedParameter = new SqlParameter("@IsReleased", SqlDbType.Bit) { Value = isReleased };
            SqlParameter releaseDateParameter = new SqlParameter("@ReleaseDate", SqlDbType.DateTime) { Value = realeaseDate };
            SqlParameter releasedByUserIDParameter = new SqlParameter("@ReleasedByUserID", SqlDbType.Int) { Value = releasedByUserID };
            SqlParameter releaseApplicationIDParameter = new SqlParameter("@ReleaseApplicationID", SqlDbType.Int) { Value = releaseApplicationID };

            return CommonRepos.ExecuteNonQuery(storedProcedureName, detainIDParameter,
                isReleasedParameter, releaseDateParameter, releasedByUserIDParameter, releaseApplicationIDParameter);
        }

        public static bool IsExist(int licenseID)
        {
            string storedProcedureName = "SP_ChackDetainedDrivingLicenseExists";

            SqlParameter licenseIDParameter = new SqlParameter("@LicenseID", SqlDbType.Int) { Value = licenseID };

            return CommonRepos.CheckTruefalse(storedProcedureName, licenseIDParameter);
        }

    }
}