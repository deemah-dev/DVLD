using Microsoft.Data.SqlClient;
using System.Data;

namespace DVLD.DAL
{
    public static class PersonRepo
    {
        public static int Create(string nationalNo, string firstName, string secondName, string thirdName,
                                 string lastName, DateTime dateOfBirth, int gender, string address,
                                 string phone, string email, int nationalityCountryID, string imagePath)
        {
            string storedProcedureName = "SP_AddNewPerson";

            SqlParameter[] parameters =
            {
                new SqlParameter("@NationalNo", SqlDbType.NVarChar) { Value = nationalNo },
                new SqlParameter("@FirstName", SqlDbType.NVarChar) { Value = firstName },
                new SqlParameter("@SecondName", SqlDbType.NVarChar) { Value = secondName },
                new SqlParameter("@ThirdName", SqlDbType.NVarChar) { Value = thirdName },
                new SqlParameter("@LastName", SqlDbType.NVarChar) { Value = lastName },
                new SqlParameter("@DateOfBirth", SqlDbType.Date) { Value = dateOfBirth },
                new SqlParameter("@Gender", SqlDbType.Int) { Value = gender },
                new SqlParameter("@Address", SqlDbType.NVarChar) { Value = address },
                new SqlParameter("@Phone", SqlDbType.NVarChar) { Value = phone },
                new SqlParameter("@Email", SqlDbType.NVarChar) { Value = email },
                new SqlParameter("@NationalityCountryID", SqlDbType.Int) { Value = nationalityCountryID },
                new SqlParameter("@ImagePath", SqlDbType.NVarChar) { Value = imagePath }
            };

            return CommonRepos.ReturnValue(storedProcedureName, parameters);
        }

        public static bool Delete(int personID)
        {
            return CommonRepos.ExecuteNonQuery(
                "SP_DeletePerson",
                new SqlParameter("@PersonID", SqlDbType.Int) { Value = personID }
            );
        }

        public static DataTable? GetAll()
        {
            return CommonRepos.GetAll("SP_GetAllPeople");
        }

        public static bool IsExist(int personID)
        {
            return CommonRepos.CheckTruefalse(
                "SP_CheckPersonExists",
                new SqlParameter("@PersonID", SqlDbType.Int) { Value = personID }
            );
        }

        public static bool Read(int personID, ref string nationalNo, ref string firstName,
                        ref string secondName, ref string thirdName, ref string lastName,
                        ref DateTime dateOfBirth, ref short gender, ref string address,
                        ref string phone, ref string email, ref int nationalityCountryID,
                        ref string nationalityName, ref string imagePath)
        {
            string storedProcedureName = "SP_FindPersonByID";

            using (SqlConnection connection = new SqlConnection(DbHelper.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(storedProcedureName, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(new SqlParameter("@PersonID", SqlDbType.Int) { Value = personID });

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (!reader.Read())
                                return false;

                            nationalNo = reader.GetString("NationalNo");
                            firstName = reader.GetString("FirstName");
                            secondName = reader.GetString("SecondName");

                            if (reader["ThirdName"] == DBNull.Value) thirdName = "";
                            else thirdName = reader.GetString("ThirdName");

                            lastName = reader.GetString("LastName");
                            dateOfBirth = reader.GetDateTime("DateOfBirth");
                            gender = reader.GetByte("Gender");
                            address = reader.GetString("Address");
                            phone = reader.GetString("Phone");

                            if (reader["Email"] == DBNull.Value) email = "";
                            else email = reader.GetString("Email");

                            nationalityCountryID = reader.GetInt32("NationalityCountryID");
                            nationalityName = reader.GetString("NationalityName");

                            if (reader["ImagePath"] == DBNull.Value) imagePath = "";
                            else imagePath = reader.GetString("ImagePath");

                                return true;
                        }
                    }
                    catch (Exception ex)
                    {
                        string error = ex.Message;
                        return false;
                    }
                }
            }
        }


        public static bool Read(string nationalNo, ref int personID, ref string firstName,
                        ref string secondName, ref string thirdName, ref string lastName,
                        ref DateTime dateOfBirth, ref int gender, ref string address,
                        ref string phone, ref string email, ref int nationalityCountryID,
                        ref string nationalityName, ref string imagePath)
        {
            string storedProcedureName = "SP_FindPersonByNationalNo";

            using (SqlConnection connection = new SqlConnection(DbHelper.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(storedProcedureName, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(new SqlParameter("@NationalNo", SqlDbType.NVarChar) { Value = nationalNo });

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (!reader.Read())
                                return false;

                            personID = reader.GetInt32("PersonID");
                            firstName = reader.GetString("FirstName");
                            secondName = reader.GetString("SecondName");

                            if (reader["ThirdName"] == DBNull.Value) thirdName = "";
                            else thirdName = reader.GetString("ThirdName");

                            lastName = reader.GetString("LastName");
                            dateOfBirth = reader.GetDateTime("DateOfBirth");
                            gender = reader.GetByte("Gender");
                            address = reader.GetString("Address");
                            phone = reader.GetString("Phone");

                            if (reader["Email"] == DBNull.Value) email = "";
                            else email = reader.GetString("Email");

                            nationalityCountryID = reader.GetInt32("NationalityCountryID");
                            nationalityName = reader.GetString("NationalityName");

                            if (reader["ImagePath"] == DBNull.Value) imagePath = "";
                            else imagePath = reader.GetString("ImagePath");

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


        public static bool Update(int personID, string address, string phone, string email, string imagePath)
        {
            string storedProcedureName = "SP_UpdatePersonInfo";

            SqlParameter[] parameters =
            {
                new SqlParameter("@PersonID", SqlDbType.Int) { Value = personID },
                new SqlParameter("@Address", SqlDbType.NVarChar) { Value = address },
                new SqlParameter("@Phone", SqlDbType.NVarChar) { Value = phone },
                new SqlParameter("@Email", SqlDbType.NVarChar) { Value = email },
                new SqlParameter("@ImagePath", SqlDbType.NVarChar) { Value = imagePath }
            };

            return CommonRepos.ExecuteNonQuery(storedProcedureName, parameters);
        }
    }
}
