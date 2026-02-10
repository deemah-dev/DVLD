using Microsoft.Data.SqlClient;
using System.Data;

namespace DVLD.DAL
{
    public static class CountryRepo
    {
        public static DataTable? GetAll()
        {
            return CommonRepos.GetAll("SP_GetAllCountries");
        }

        public static int GetCountryByName(string countryName, ref int countryID)
        {
            SqlParameter countryNameParameter = new SqlParameter("@CountryName", SqlDbType.NVarChar) { Value = countryName };
            return CommonRepos.ReturnValue("SP_GetCountyByName", countryNameParameter);
        }
    }
}
