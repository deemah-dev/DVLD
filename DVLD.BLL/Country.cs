using DVLD.DAL;
using System.Data;

namespace DVLD.BLL
{
    public class Country
    {
        public static List<string>? GetNames()
        {
            DataTable? countriesdataTable = CountryRepo.GetAll();
            if (countriesdataTable is null) return null;
            List<string> countriesNames = new List<string>();
            foreach (DataRow country in countriesdataTable.Rows)
            {
                countriesNames.Add(country["CountryName"].ToString());
            }
            return countriesNames;
        }

        public static int GetID(string countyName)
        {
            int countryID = -1;
            countryID = CountryRepo.GetCountryByName(countyName, ref countryID);
            return countryID;
        }
    }
}
