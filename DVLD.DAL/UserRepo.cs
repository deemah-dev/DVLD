using System.Data;
using Microsoft.Data.SqlClient;

namespace DVLD.DAL
{
    public static class UserRepo
    {
        public static int Create(int personID, string username, string passwordHash, bool isActive)
        {
            SqlParameter[] parameters =
            {
                new SqlParameter("@PersonID", SqlDbType.Int) { Value = personID },
                new SqlParameter("@Username", SqlDbType.NVarChar) { Value = username },
                new SqlParameter("@PasswordHash", SqlDbType.NVarChar) { Value = passwordHash },
                new SqlParameter("@IsActive", SqlDbType.Bit) { Value = isActive }
            };

            return CommonRepos.ReturnValue("SP_AddNewUser", parameters);
        }

        public static bool Delete(int userID)
        {
            SqlParameter userIDParameters = new SqlParameter("@UserID", SqlDbType.Int) { Value = userID };

            return CommonRepos.ExecuteNonQuery("SP_DeleteUser", userIDParameters);
        }

        public static DataTable? GetAll()
        {
            return CommonRepos.GetAll("SP_GetAllUsers");
        }

        public static bool IsExist(int personID)
        {
            SqlParameter personIDParameter = new SqlParameter("@PersonID", SqlDbType.Int) { Value = personID };
            return CommonRepos.CheckTruefalse("SP_CheckUserExistsByPersonID", personIDParameter);
        }

        public static bool IsExist(string username)
        {
            SqlParameter usernameParameter = new SqlParameter("@Username", SqlDbType.NVarChar) { Value = username };
            return CommonRepos.CheckTruefalse("SP_CheckUserExistsByUsername", usernameParameter);
        }

        public static bool Read(string username, string passwordHash, ref int userID, ref int personID, ref bool isActive)
        {
            using (SqlConnection connection = new SqlConnection(DbHelper.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_FindUserByCredentials", connection) { CommandType = CommandType.StoredProcedure })
                {
                    SqlParameter[] parameters =
                    {
                        new SqlParameter("@Username", SqlDbType.NVarChar) { Value = username },
                        new SqlParameter("@PasswordHash", SqlDbType.NVarChar) { Value = passwordHash }
                    };
                    command.Parameters.AddRange(parameters);

                    connection.Open();
                    try
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                userID = reader.GetInt32("UserID");
                                personID = reader.GetInt32("PersonID");
                                isActive = reader.GetBoolean("IsActive");
                                return true;
                            }
                        }
                    }
                    catch
                    {

                    }
                   
                }
            }
            return false;
        }

        public static bool Read(int userID, ref string username, ref string passwordHash, ref int personID, ref bool isActive)
        {
            using (SqlConnection connection = new SqlConnection(DbHelper.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand("SP_FindUserByUserID", connection) { CommandType = CommandType.StoredProcedure })
                {
                    SqlParameter[] parameters =
                    {
                        new SqlParameter("@UserID", SqlDbType.Int) { Value = userID }
                    };
                    command.Parameters.AddRange(parameters);

                    connection.Open();
                    try
                    {
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                username = reader.GetString("Username");
                                passwordHash = reader.GetString("PasswordHash");
                                personID = reader.GetInt32("PersonID");
                                isActive = reader.GetBoolean("IsActive");
                                return true;
                            }
                        }
                    }
                    catch
                    {

                    }
                }
            }
            return false;
        }

        public static bool UpdateActivation(int userID, bool isActive)
        {
            SqlParameter[] parameters =
            {
                new SqlParameter("@UserID", SqlDbType.Int) { Value = userID },
                new SqlParameter("@IsActive", SqlDbType.Bit) { Value = isActive }
            };

            return CommonRepos.ExecuteNonQuery("SP_UpdateUserActivation", parameters);
        }

        public static bool UpdatePassword(int userID, string newPasswordHash)
        {
            SqlParameter[] parameters =
            {
                new SqlParameter("@UserID", SqlDbType.Int) { Value = userID },
                new SqlParameter("@PasswordHash", SqlDbType.NVarChar) { Value = newPasswordHash }
            };

            return CommonRepos.ExecuteNonQuery("SP_UpdateUserPassword", parameters);
        }
    }
}