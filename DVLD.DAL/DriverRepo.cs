using Microsoft.Data.SqlClient;
using System.Data;

namespace DVLD.DAL
{
    public class DriverRepo
    {
        public static int Create(int personID, int createdByUserID, DateTime createdDate)
        {
            string storedProcedureName = "SP_AddNewDriver";

            SqlParameter personIDParameter = new SqlParameter("@PersonID", SqlDbType.Int) { Value = personID };
            SqlParameter createdByUserIDParameter = new SqlParameter("@CreatedByUserID", SqlDbType.Int) { Value = createdByUserID };
            SqlParameter createdDateParameter = new SqlParameter("@CreatedDate", SqlDbType.DateTime) { Value = createdDate };

            return CommonRepos.ReturnValue(storedProcedureName, personIDParameter, createdByUserIDParameter, createdDateParameter);
        }

        public static DataTable? GetAll()
        {
            string storedProcedureName = "SP_GetDriversTable";

            return CommonRepos.GetAll(storedProcedureName);
        }

        public static DataTable? GetInternationalLicensesHistory(int driverID)
        {
            string storedProcedureName = "SP_GetInternationalLicensesHistory";

            SqlParameter driverIDParameter = new SqlParameter("@DriverID", SqlDbType.Int) { Value = driverID };

            return CommonRepos.GetAll(storedProcedureName, driverIDParameter);
        }

        public static DataTable? GetLocalLicensesHistory(int driverID)
        {
            string storedProcedureName = "SP_GetLocalLicensesHistory";

            SqlParameter driverIDParameter = new SqlParameter("@DriverID", SqlDbType.Int) { Value = driverID };

            return CommonRepos.GetAll(storedProcedureName, driverIDParameter);
        }

        public static bool Read(int driverID, ref int personID, ref int createdByUserID, ref DateTime createdDate)
        {
            string storedProcedureName = "SP_FindDriver";

            SqlParameter driverIDParameter = new SqlParameter("@DriverID", SqlDbType.Int) { Value = driverID };

           

            using (SqlConnection connection = new SqlConnection(DbHelper.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(storedProcedureName, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(driverIDParameter);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (!reader.Read())
                                return false;

                            personID = reader.GetInt32(reader.GetOrdinal("PersonID"));
                            createdByUserID = reader.GetInt32(reader.GetOrdinal("CreatedByUserID"));
                            createdDate = reader.GetDateTime(reader.GetOrdinal("CreatedDate"));




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

        public static bool ReadByPersonID(int personID, ref int driverID, ref int createdByUserID, ref DateTime createdDate)
        {
            string storedProcedureName = "SP_FindDriverByPersonID";

            SqlParameter driverIDParameter = new SqlParameter("@PersonID", SqlDbType.Int) { Value = personID };



            using (SqlConnection connection = new SqlConnection(DbHelper.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(storedProcedureName, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(driverIDParameter);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (!reader.Read())
                                return false;

                            driverID = reader.GetInt32(reader.GetOrdinal("DriverID"));
                            createdByUserID = reader.GetInt32(reader.GetOrdinal("CreatedByUserID"));
                            createdDate = reader.GetDateTime(reader.GetOrdinal("CreatedDate"));




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
