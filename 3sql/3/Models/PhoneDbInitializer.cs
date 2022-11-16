using DocumentFormat.OpenXml.Bibliography;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Web;
using System.Text.Json;
using System.Web.Hosting;

using JsonSerializer = Newtonsoft.Json.JsonSerializer;
using System.Runtime.Serialization.Json;

namespace _3.Models
{
    public class PhoneDbInitializer : DropCreateDatabaseAlways<PhoneContext>
    {
        private static PhoneContext db = new PhoneContext();
        protected override void Seed(PhoneContext db)
        {
            base.Seed(db);
        }
        public static List<Phone> GetCollection()
        {
            db.Database.CreateIfNotExists();
            return new List<Phone>(db.Phones);
        }
        public static Phone GetElement(int id)
        {
            return db.Phones.FirstOrDefault(i => i.Id == id);
        }

        public static void AddPhone(Phone phone)
        {
             if (db.Phones.Count() == 0)
                    phone.Id = 1;
             else
            phone.Id = db.Phones.ToList()[db.Phones.Count() - 1].Id+ 1;

            
            db.Phones.Add(phone);
        }
        public static void DeleteElement(int idDeleted)
        {
            db.Phones.Remove(db.Phones.FirstOrDefault(i => i.Id == idDeleted));
        }
        public static void UpdateElement(Phone phone)
        {
            Phone updphone = db.Phones.FirstOrDefault(i => i.Id == phone.Id);
            if (updphone != null)
            {
                updphone.Name = phone.Name;
                updphone.Number = phone.Number;
            }
        }
        public static void SaveCollection()
        {
            db.SaveChanges();
        }
    }
}