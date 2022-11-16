using System;
using System.Collections.Generic;
using System.Web;
using System.Data.Entity;

namespace _3.Models
{
    public class PhoneContext : DbContext
    {
        public PhoneContext()
            : base("PhoneContext")
        { }
        public DbSet<Phone> Phones { get; set; }

     
    }
}