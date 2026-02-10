using Microsoft.Extensions.Configuration;
namespace DVLD.DAL
{
    internal static class DbHelper
    {
        private static readonly IConfiguration _configuration = new ConfigurationBuilder().AddJsonFile("appsettings.json").Build();
        public static string ConnectionString => _configuration.GetSection("DefaultConnection").Value.ToString();
    }
}
