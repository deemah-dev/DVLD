using DVLD.DAL;
using System.Data;

namespace DVLD.BLL
{
    public class TestType
    {
        private TestType(TestTypes testTypeID, string testTypeTitle, string testTypeDescription, decimal testTypeFees)
        {
            Type = testTypeID;
            TestTypeTitle = testTypeTitle;
            TestTypeDescription = testTypeDescription;
            TestTypeFees = testTypeFees;
        }

        public TestTypes Type { get; private set; }
        public string TestTypeTitle { get; set; }
        public string TestTypeDescription { get; set; }
        public decimal TestTypeFees { get; set; }

        public static DataTable? GetAll()
        {
            return TestTypeRepo.GetAll();
        }

        public static TestType? GetTestType(TestTypes type)
        {
            string TestTypeTitle = "", TestTypeDescription = "";
            decimal TestTypeFees = -1;

            bool isFound = TestTypeRepo.Read((int)type, ref TestTypeTitle, ref TestTypeDescription, ref TestTypeFees);

            if (isFound)
                return new TestType(type, TestTypeTitle, TestTypeDescription, TestTypeFees);
            return null;
        }

        public bool Save()
        {
            return TestTypeRepo.Update((int)this.Type, this.TestTypeTitle, this.TestTypeDescription, this.TestTypeFees);
        }
    }
}
