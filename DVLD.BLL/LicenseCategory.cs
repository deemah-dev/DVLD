using DVLD.DAL;
using System.Data;

namespace DVLD.BLL
{
    public class LicenseCategory
    {
        private LicenseCategory(int licenseCategoryID, string categoryName, string categoryDescription,
            int minimumAllowedAge, int validityLength, decimal categoryFees)
        {
            LicenseCategoryID = licenseCategoryID;
            CategoryName = categoryName;
            CategoryDescription = categoryDescription;
            MinimumAllowedAge = minimumAllowedAge;
            ValidityLength = validityLength;
            CategoryFees = categoryFees;
        }

        public int LicenseCategoryID { get; private set; }
        public string CategoryName { get; set; }
        public string CategoryDescription { get; set; }
        public int MinimumAllowedAge { get; set; }
        public int ValidityLength { get; set; }
        public decimal CategoryFees { get; set; }

        public static List<string>? GetNames()
        {
            DataTable? categoriesTable = LicenseCategoryRepo.GetAll();
            if (categoriesTable is null) return null;
            List<string> categoriesNames = new ();
            foreach (DataRow row in categoriesTable.Rows)
            {
                categoriesNames.Add(row["ClassName"].ToString());
            }
            return categoriesNames;
        }

        public static int GetID(string categoryName)
        {
            return LicenseCategoryRepo.GetID(categoryName);
        }

        public static LicenseCategory? GetCategory(int licenseCategoryID)
        {
            string CategoryName = "";
            string CategoryDescription = "";
            int MinimumAllowedAge = -1;
            int ValidityLength = -1;
            decimal CategoryFees = -1;

            bool isFound = LicenseCategoryRepo.Read(licenseCategoryID, ref CategoryName,
                ref CategoryDescription, ref MinimumAllowedAge,
                ref ValidityLength, ref CategoryFees);

            if (isFound)
                return new LicenseCategory(licenseCategoryID, CategoryName, CategoryDescription,
                    MinimumAllowedAge, ValidityLength, CategoryFees);

            return null;
        }
        public static LicenseCategory? GetCategory(string licenseCategoryName)
        {
            int licenseCategoryID = -1;
            string CategoryDescription = "";
            int MinimumAllowedAge = -1;
            int ValidityLength = -1;
            decimal CategoryFees = -1;

            bool isFound = LicenseCategoryRepo.Read(licenseCategoryName, ref licenseCategoryID,
                ref CategoryDescription, ref MinimumAllowedAge,
                ref ValidityLength, ref CategoryFees);

            if (isFound)
                return new LicenseCategory(licenseCategoryID, licenseCategoryName, CategoryDescription,
                    MinimumAllowedAge, ValidityLength, CategoryFees);

            return null;
        }
    }
}
