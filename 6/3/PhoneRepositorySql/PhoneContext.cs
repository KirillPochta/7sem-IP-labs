using Ninject;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneRepositorySql
{
    public class PhoneContext : DbContext

    {
        [Inject]
        public PhoneContext()
               : base("PhoneContextConnection")
        { }
        public DbSet<Phone> Phones { get; set; }
    }
}
