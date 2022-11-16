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
        private static List<Phone> phonesList = new List<Phone>();

        private static readonly string _filePath = HostingEnvironment.MapPath("/Files/phones.json");

        protected override void Seed(PhoneContext db)
        {
            phonesList = DeserializePhones();
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
            phonesList.Add(phone);
        }
        public static void DeleteElement(int idDeleted)
        {
            db.Phones.Remove(db.Phones.Find(idDeleted));
            phonesList.Remove(db.Phones.FirstOrDefault(i => i.Id == idDeleted));           
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
            SerializePhone(phonesList);
        }
        public static void SerializePhone(List<Phone> phonesList)
        {
            string json = JsonConvert.SerializeObject(phonesList);
  
            using (StreamWriter streamWriter = new StreamWriter(_filePath))
            { 
                
                streamWriter.WriteLine(json);
            }
        }
        public static List<Phone> DeserializePhones()
        {
            if (!File.Exists(_filePath))
            {
                using (StreamWriter streamWriter = new StreamWriter(_filePath))
                {
                    streamWriter.Write("");
                }
            }
            List<Phone> phoneRecords;
            using (StreamReader streamReader = new StreamReader(_filePath))
            {
                string fileData = streamReader.ReadToEnd();
                if (!string.IsNullOrEmpty(fileData))
                    phoneRecords = System.Text.Json.JsonSerializer.Deserialize<List<Phone>>(fileData);
                else
                    phoneRecords = new List<Phone>();
            }
            return phonesList;
           
        }
    }
}