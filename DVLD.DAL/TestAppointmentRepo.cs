using Microsoft.Data.SqlClient;
using Microsoft.Identity.Client;
using System.Data;

namespace DVLD.DAL
{
    public static class TestAppointmentRepo
    {
        public static int Create(int testTypeID, int localDrivingLicenseApplicationID,
            DateTime appointmentDate, decimal paidFees, int createdByUserID, bool isLocked)
        {
            string storedProcedureName = "SP_AddNewTestAppoinment";

            SqlParameter testTypeIDParameter = new SqlParameter("@TestTypeID", SqlDbType.Int) { Value = testTypeID };
            SqlParameter localDrivingLicenseApplicationIDParameter = new SqlParameter("@LocalDrivingLicenseApplicationID", SqlDbType.Int) { Value = localDrivingLicenseApplicationID };
            SqlParameter appointmentDateParameter = new SqlParameter("@AppointmentDate", SqlDbType.DateTime) { Value = appointmentDate };
            SqlParameter paidFeesParameter = new SqlParameter("@PaidFees", SqlDbType.Decimal) { Value = paidFees };
            SqlParameter createdByUserIDParameter = new SqlParameter("@CreatedByUserID", SqlDbType.Int) { Value = createdByUserID };
            SqlParameter isLockedParameter = new SqlParameter("@IsLocked", SqlDbType.Bit) { Value = isLocked };

            return CommonRepos.ReturnValue(storedProcedureName, testTypeIDParameter, localDrivingLicenseApplicationIDParameter, appointmentDateParameter, paidFeesParameter, createdByUserIDParameter, isLockedParameter);
        }

        public static DataTable? GetApplicationAppointments(int localDrivingLicenseApplicationID, int testTypeID)
        {
            string storedProcedureName = "SP_GetApplicationAppoinmentsTable";

            SqlParameter localDrivingLicenseApplicationIDParameter = new SqlParameter("@LocalDrivingLicenseApplicationID", SqlDbType.Int) { Value = localDrivingLicenseApplicationID };
            SqlParameter testTypeIDParameter = new SqlParameter("@TestTypeID", SqlDbType.Int) { Value = testTypeID };

            return CommonRepos.GetAll(storedProcedureName, localDrivingLicenseApplicationIDParameter, testTypeIDParameter);
        }

        public static bool LockAppointment(int appointmentID)
        {
            string storedProcedureName = "SP_LockTestAppoinment";

            SqlParameter appointmentIDParameter = new SqlParameter("@TestAppointmentID", SqlDbType.Int) { Value = appointmentID };

            return CommonRepos.ExecuteNonQuery(storedProcedureName, appointmentIDParameter);
        }

        public static bool Read(int appointmentID, ref int testTypeID, ref int localDrivingLicenseApplicationID,
            ref DateTime appointmentDate, ref decimal paidFees, ref int createdByUserID, ref bool isLocked, ref int retakeTestApplicationID)
        {
            string storedProcedureName = "SP_FindTestAppoinment";

            SqlParameter appointmentIDParameter = new SqlParameter("@TestAppointmentID", SqlDbType.Int) { Value = appointmentID };


            using (SqlConnection connection = new SqlConnection(DbHelper.ConnectionString))
            {
                using (SqlCommand command = new SqlCommand(storedProcedureName, connection))
                {
                    command.CommandType = CommandType.StoredProcedure;
                    command.Parameters.Add(appointmentIDParameter);

                    try
                    {
                        connection.Open();
                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            if (!reader.Read())
                                return false;

                            testTypeID = reader.GetInt32(reader.GetOrdinal("TestTypeID"));
                            localDrivingLicenseApplicationID = reader.GetInt32(reader.GetOrdinal("LocalDrivingLicenseApplicationID"));
                            appointmentDate = reader.GetDateTime(reader.GetOrdinal("AppointmentDate"));
                            paidFees = reader.GetDecimal(reader.GetOrdinal("PaidFees"));
                            createdByUserID = reader.GetInt32(reader.GetOrdinal("CreatedByUserID"));
                            isLocked = reader.GetBoolean(reader.GetOrdinal("IsLocked"));
                            if (reader.IsDBNull(reader.GetOrdinal("RetakeTestApplicationID"))) retakeTestApplicationID = -1;
                            else retakeTestApplicationID = reader.GetInt32(reader.GetOrdinal("RetakeTestApplicationID"));



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

        public static bool UpdateDate(int testAppointmentID, DateTime newDateTime)
        {
            string storedProcedureName = "SP_UpdateTestAppoinmentDate";

            SqlParameter idParameter = new SqlParameter("@TestAppointmentID", SqlDbType.Int) { Value = testAppointmentID };
            SqlParameter newDateTimeParameter = new SqlParameter("@AppointmentDate", SqlDbType.DateTime) { Value = newDateTime };

            return CommonRepos.ExecuteNonQuery(storedProcedureName, idParameter, newDateTimeParameter);
        }

    }
}