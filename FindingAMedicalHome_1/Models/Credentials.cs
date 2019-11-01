using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using Newtonsoft.Json;

namespace FindingAMedicalHome_1.Models
{
    public class Credentials
    {
        public int ID { get; set; }
        public string Password { get; set; }
        public string UserName { get; set; }
    }

    
    public class LoginContext : DbContext
    {
        public DbSet<Credentials> Credentials { get; set; }
    }
}