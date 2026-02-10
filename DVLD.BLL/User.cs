
using DVLD.DAL;
using System.Data;
using System.Security.Cryptography;
using System.Text;

namespace DVLD.BLL
{
    public class User
    {
        public User()
        {
            UserID = -1;
            PersonID = -1;
            Username = "";
            PasswordHash = "";
            Password = "";
            IsActive = false;
        }

        private User(int userID, int personID, string username, string password, bool isActive)
        {
            UserID = userID;
            PersonID = personID;
            Username = username;
            PasswordHash = password;
            IsActive = isActive;
            Password = "";
        }

        public int UserID { get; private set; }
        public int PersonID { get; set; }
        public string Username { get; set; }
        public string PasswordHash { get; private set; }
        public string Password { private get; set; }
        public bool IsActive { get; set; }

        public Person? Person { get => Person.GetPerson(PersonID);}

        private static string ComputeHash(string input)
        {
            //SHA is Secutred Hash Algorithm.
            // Create an instance of the SHA-256 algorithm
            using (SHA256 sha256 = SHA256.Create())
            {
                // Compute the hash value from the UTF-8 encoded input string
                byte[] hashBytes = sha256.ComputeHash(Encoding.UTF8.GetBytes(input));


                // Convert the byte array to a lowercase hexadecimal string
                return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
            }
        }

        public static User? Login(string username, string password)
        {
            password = ComputeHash(password);
            int UserID = -1, PersonID = -1;
            bool IsActive = false;
            bool isFound = UserRepo.Read(username, password, ref UserID, ref PersonID, ref IsActive);
            if (isFound)
                return new User(UserID, PersonID, username, password, IsActive);
            return null;
        }

        public static User? GetUser(int userID)
        {
            int PersonID = -1;
            bool IsActive = false;
            string Username = "", Password = "";
            bool isFound = UserRepo.Read(userID, ref Username, ref Password, ref PersonID, ref IsActive);
            if (isFound)
                return new User(userID, PersonID, Username, Password, IsActive);
            return null;
        }

        public bool Save()
        {
            this.PasswordHash = ComputeHash(this.Password);
            this.UserID = UserRepo.Create(this.PersonID, this.Username, this.PasswordHash, this.IsActive);
            return this.UserID != -1; ;
        }

        public static bool UpdateActivation(int? ID, bool isActive)
        {
            if (ID is null) return false;
            int id = (int)ID;
            return UserRepo.UpdateActivation(id, isActive);
        }

        public static bool UpdatePassword(int? ID, string oldPassword, string newPassword)
        {
            if (ID is null) return false;
            int id = (int)ID;
            User? user = GetUser(id);
            if (user is not null && user.PasswordHash == ComputeHash(oldPassword))
                return UserRepo.UpdatePassword(id, ComputeHash(newPassword));
            return false;
        }

        public static bool Delete(int ID)
        {
            return UserRepo.Delete(ID);
        }

        public static DataTable? GetAll()
        {
            return UserRepo.GetAll();
        }

        public static bool ValidatePassword(string? passwordHash, string newPassword)
        {
            return passwordHash == ComputeHash(newPassword);
        }

        public static bool IsExist(int personID)
        {
            return UserRepo.IsExist(personID);
        }
        public static bool IsExist(string username)
        {
            return UserRepo.IsExist(username);
        }
    }
}
