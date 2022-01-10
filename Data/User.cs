using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace CRUDAPI.Data
{
    public class User
    {
        public int id { get; set; }
        public string name { get; set; }

        public string login { get; set; }
        public string password { get; set; }
        public string email { get; set; }
        public string telephone { get; set; }
        public DateTime? birth_date { get; set; }
        public string mother_name { get; set; }
        public bool status { get; set; }
        public DateTime? created_at { get; set; }
        public DateTime? updated_at { get; set; }
        
        //Constructor
        public User()
        {
            this.created_at = DateTime.UtcNow;
            this.status = true;
            this.updated_at = DateTime.UtcNow;
        }
    }
}