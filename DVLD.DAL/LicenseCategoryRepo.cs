using Microsoft.Data.SqlClient;
using System.Data;

namespace DVLD.DAL
{
    public static class LicenseCategoryRepo
    {
        public static int GetID(string categoryName)
        {
            string storedProcedureName = "SP_GetLicenseClassID";

            SqlParameter categoryNameParameter = new SqlParameter("@ClassName", SqlDbType.NVarChar) { Value = categoryName };

            return CommonRepos.ReturnValue(storedProcedureName, categoryNameParameter);
        }

        public static DataTable? GetAll()
        {
            string storedProcedureName = "SP_GetLicenseClassesTable";

            return CommonRepos.GetAll(storedProcedureName);
        }

        public static bool Read(int licenseCategoryID, ref string categoryName,
            ref string categoryDescription, ref int minimumAllowedAge,
            ref int validityLength, ref decimal categoryFees)
        {
            string storedProcedureName = "SP_FindLicenseClass";

            SqlParameter licenseCategoryIDParameter = new SqlParameter("@LicenseClassID", SqlDbType.Int) { Value = licenseCategoryID };

            

            using (SqlConnection connection = new SqlConnection(DbHelper.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(storedProcedureName, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(licenseCategoryIDParameter);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (!reader.Read())
                                return false;

                            categoryName = reader.GetString(reader.GetOrdinal("ClassName"));
                            categoryDescription = reader.GetString(reader.GetOrdinal("ClassDescription"));
                            minimumAllowedAge = reader.GetByte(reader.GetOrdinal("MinimumAllowedAge"));
                            validityLength = reader.GetByte(reader.GetOrdinal("DefaultValidityLength"));
                            categoryFees = reader.GetDecimal(reader.GetOrdinal("ClassFees"));



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

        public static bool Read(string licenseCategoryName, ref int licenseCategoryID, ref string categoryDescription, ref int minimumAllowedAge, ref int validityLength, ref decimal categoryFees)
        {
            string storedProcedureName = "SP_FindLicenseClassByClassName";

            SqlParameter licenseCategoryNameParameter = new SqlParameter("@ClassName", SqlDbType.NVarChar, 50) { Value = licenseCategoryName };



            using (SqlConnection connection = new SqlConnection(DbHelper.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(storedProcedureName, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(licenseCategoryNameParameter);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                licenseCategoryID = reader.GetInt32(reader.GetOrdinal("LicenseClassID"));
                                categoryDescription = reader.GetString(reader.GetOrdinal("ClassDescription"));
                                minimumAllowedAge = reader.GetByte(reader.GetOrdinal("MinimumAllowedAge"));
                                validityLength = reader.GetByte(reader.GetOrdinal("DefaultValidityLength"));
                                categoryFees = reader.GetDecimal(reader.GetOrdinal("ClassFees"));
                                return true;
                            }


                            return false;



                        }
                    }
                    catch(Exception ex)
                    {
                        string message = ex.Message;
                        return false;
                    }
                }
            }
        }
    }
}
