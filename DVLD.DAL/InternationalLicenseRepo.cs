using Microsoft.Data.SqlClient;
using System.Data;

namespace DVLD.DAL
{
    public static class InternationalLicenseRepo
    {
        public static int Create(int applicationID, int driverID, int issuedUsingLocalLicenseID, DateTime issueDate, DateTime expirationDate, bool isActive, int createdByUserID)
        {
            string storedProcedureName = "SP_AddNewInternationalDrivingLicense";

            SqlParameter applicationIDParameter = new SqlParameter("@ApplicationID", SqlDbType.Int) { Value = applicationID };
            SqlParameter driverIDParameter = new SqlParameter("@DriverID", SqlDbType.Int) { Value = driverID };
            SqlParameter issuedUsingLocalLicenseIDParameter = new SqlParameter("@IssuedUsingLocalLicenseID", SqlDbType.Int) { Value = issuedUsingLocalLicenseID };
            SqlParameter issueDateParameter = new SqlParameter("@IssueDate", SqlDbType.DateTime) { Value = issueDate };
            SqlParameter expirationDateParameter = new SqlParameter("@ExpirationDate", SqlDbType.DateTime) { Value = expirationDate };
            SqlParameter isActiveParameter = new SqlParameter("@IsActive", SqlDbType.Bit) { Value = isActive };
            SqlParameter createdByUserIDParameter = new SqlParameter("@CreatedByUserID", SqlDbType.Int) { Value = createdByUserID };

            return CommonRepos.ReturnValue(storedProcedureName, applicationIDParameter, driverIDParameter,
                issuedUsingLocalLicenseIDParameter, issueDateParameter, expirationDateParameter, isActiveParameter, createdByUserIDParameter);
        }

        public static bool IsExist(int localLicenseID)
        {
            string storedProcedureName = "SP_ChackInternationalDrivingLicenseExists";

            SqlParameter localLicenseIDParameter = new SqlParameter("@IssuedUsingLocalLicenseID", SqlDbType.Int) { Value = localLicenseID };

            return CommonRepos.CheckTruefalse(storedProcedureName, localLicenseIDParameter);
        }

    }
}
