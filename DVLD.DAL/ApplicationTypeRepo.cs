
using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;
using System.Data;

namespace DVLD.DAL
{
    public static class ApplicationTypeRepo
    {
        public static DataTable? GetAll()
        {
            string storedProcedureName = "SP_GetApplicationTypesTable";
            return CommonRepos.GetAll(storedProcedureName);
        }

        public static bool Read(int applicationTypeID, ref string applicationTypeTitle, ref decimal applicationFees)
        {
            string storedProcedureName = "SP_FindApplicationType";

            SqlParameter applicationTypeIDParameter = new SqlParameter("@ApplicationTypeID", SqlDbType.Int) { Value = applicationTypeID };

           

            using (SqlConnection connection = new SqlConnection(DbHelper.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(storedProcedureName, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(applicationTypeIDParameter);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (!reader.Read())
                                return false;

                            applicationTypeTitle = reader.GetString(reader.GetOrdinal("ApplicationTypeTitle"));
                            applicationFees = reader.GetDecimal(reader.GetOrdinal("ApplicationFees"));




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

        public static bool Update(int applicationTypeID, string applicationTypeTitle, decimal applicationFees)
        {
            string storedProcedureName = "SP_UpdateApplicationType";

            SqlParameter applicationTypeIDParameter = new SqlParameter("@ApplicationTypeID", SqlDbType.Int) { Value = applicationTypeID };
            SqlParameter applicationTypeTitleParameter = new SqlParameter("@ApplicationTypeTitle", SqlDbType.NVarChar) { Value = applicationTypeTitle };
            SqlParameter applicationFeesParameter = new SqlParameter("@ApplicationFees", SqlDbType.Decimal) { Value = applicationFees };

            return CommonRepos.ExecuteNonQuery(storedProcedureName, applicationTypeIDParameter, applicationTypeTitleParameter, applicationFeesParameter);
        }

    }
}
