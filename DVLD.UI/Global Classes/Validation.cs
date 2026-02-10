using System.Text.RegularExpressions;

namespace DVLD.UI
{
    public static class Validation
    {
        /// <include file="Validation.xml" path='docs/members[@name="Validation"]/Empty/*'/>
        public static bool Empty(string text)
        {
            return string.IsNullOrWhiteSpace(text) || string.IsNullOrEmpty(text);
        }

        /// <include file="Validation.xml" path='docs/members[@name="Validation"]/HasNumbers/*'/>
        public static bool HasNumbers(string text)
        {
            return !Regex.IsMatch(text, @"^[^\d]+$");
        }

        /// <include file="Validation.xml" path='docs/members[@name="Validation"]/ValidateInteger/*'/>
        public static bool ValidateInteger(string Number)
        {
            return Regex.IsMatch(Number, @"^[0-9]*$");
        }

        /// <include file="Validation.xml" path='docs/members[@name="Validation"]/ValidateFloat/*'/>
        public static bool ValidateFloat(string Number)
        {
            return Regex.IsMatch(Number, @"^[0-9]*(?:\.[0-9]*)?$");
        }

        /// <include file="Validation.xml" path='docs/members[@name="Validation"]/IsNumber/*'/>
        public static bool IsNumber(string Number)
        {
            return (ValidateInteger(Number) || ValidateFloat(Number));
        }

        /// <include file="Validation.xml" path='docs/members[@name="Validation"]/IsValidPassword/*'/>
        public static bool IsValidPassword(string password)
        {
            return Regex.IsMatch(password, @"^(?=.*[a-z])(?=.*[A-Z])(?=.*\d).{8,}$");
        }

        /// <include file="Validation.xml" path='docs/members[@name="Validation"]/IsValidEmail/*'/>
        public static bool IsValidEmail(string email)
        {
            return Regex.IsMatch(email, @"^[a-zA-Z0-9.!#$%&'*+-/=?^_`{|}~]+@[a-zA-Z0-9-]+(?:\.[a-zA-Z0-9-]+)*$");
        }
    }
}
