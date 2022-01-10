using System;

namespace CRUD_API_ASPNET_DOTNET_5.Controllers
{
    public class UserQueryController
    {
        public UserQueryController(){
            birthDayInitial = DateTime.MinValue;
            birthDayLast = DateTime.UtcNow;
            firstRegistration = DateTime.MinValue;
            lastRegistration = DateTime.UtcNow;
            initialUpdate = DateTime.MinValue;
            lastUpdate = DateTime.UtcNow;
        }
        public string user { get; set; }
        public string login { get; set; }
        public int status { get; set; }
        public DateTime birthDayInitial { get; set; }
        public DateTime birthDayLast { get; set; }
        public DateTime firstRegistration { get; set; }
        public DateTime lastRegistration { get; set; }
        public DateTime initialUpdate { get; set; }
        public DateTime lastUpdate { get; set; }
        public int ageGroup { get; set; }
    }
}