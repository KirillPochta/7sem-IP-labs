using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public class PhoneContext : DbContext, IPhoneDictionary
    {
        public PhoneContext(DbContextOptions options)
            : base(options)
        {
            Database.EnsureCreated();
        }
        public DbSet<Phone> Phones { get; set; }

        public List<Phone> GetCollection()
        {
            return new List<Phone>(Phones);
        }
        public Phone GetElement(int id)
        {
            return Phones.FirstOrDefault(i => i.Id == id);
        }

        public void AddPhone(Phone phone)
        {
            if (Phones.Count() == 0)
                phone.Id = 1;
            else
                phone.Id = Phones.ToList()[Phones.Count() - 1].Id + 1;
            Phones.Add(phone);
            SaveCollection();
        }
        public void DeleteElement(int? id)
        {
            Phones.Remove(Phones.FirstOrDefault(i => i.Id == id));
            SaveCollection();
        }
        public void UpdateElement(Phone phone)
        {
            Phone updphone = Phones.FirstOrDefault(i => i.Id == phone.Id);
            if (updphone != null)
            {
                updphone.Name = phone.Name;
                updphone.Number = phone.Number;
            }
            SaveCollection();
        }
        public void SaveCollection()
        {
            Database.ExecuteSqlRaw("set IDENTITY_INSERT F411212PKA3.dbo.Phones ON;");
            SaveChanges();
        }
    }
}
