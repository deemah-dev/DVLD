using Microsoft.Data.SqlClient;
using System.Data;

namespace DVLD.DAL
{
    public static class TestTypeRepo
    {
        public static DataTable? GetAll()
        {
            string storedProcedureName = "SP_GetTestTypesTable";


            return CommonRepos.GetAll(storedProcedureName);
        }

        public static bool Update(int testTypeID, string testTypeTitle, string testTypeDescription, decimal testTypeFees)
        {
            string storedProcedureName = "SP_UpdateTestType";

            SqlParameter testTypeIDParameter = new SqlParameter("@TestTypeID", SqlDbType.Int) { Value = testTypeID };
            SqlParameter testTypeTitleParameter = new SqlParameter("@TestTypeTitle", SqlDbType.NVarChar) { Value = testTypeTitle };
            SqlParameter testTypeDescriptionParameter = new SqlParameter("@TestTypeDescription", SqlDbType.NVarChar) { Value = testTypeDescription };
            SqlParameter testTypeFeesParameter = new SqlParameter("@TestTypeFees", SqlDbType.Decimal) { Value = testTypeFees };

            return CommonRepos.ExecuteNonQuery(storedProcedureName, testTypeIDParameter, testTypeTitleParameter, testTypeDescriptionParameter, testTypeFeesParameter);
        }

        public static bool Read(int testTypeID, ref string testTypeTitle, ref string testTypeDescription, ref decimal testTypeFees)
        {
            string storedProcedureName = "SP_FindTestType";

            SqlParameter testTypeIDParameter = new SqlParameter("@TestTypeID", SqlDbType.Int) { Value = testTypeID };

           

            using (SqlConnection connection = new SqlConnection(DbHelper.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(storedProcedureName, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(testTypeIDParameter);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (!reader.Read())
                                return false;

                            testTypeTitle = reader.GetString(reader.GetOrdinal("TestTypeTitle"));
                            testTypeDescription = reader.GetString(reader.GetOrdinal("TestTypeDescription"));
                            testTypeFees = reader.GetDecimal(reader.GetOrdinal("TestTypeFees"));


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