using System.Collections.Generic;
using System.Data.Entity;
using System.IO;
using System.Linq;
using System.Web.Hosting;

using System.Text.Json;

namespace _3.Models
{
    public class PhoneDbInitializer
    {
        private static List<Phone> phonesList = new List<Phone>();

        private static readonly string _filePath = HostingEnvironment.MapPath("/Files/phones.json");

       
        public static List<Phone> GetCollection()
        {
            phonesList = DeserializePhones();
            return phonesList;
        }
        public static Phone GetElement(int id)
        {
            return phonesList.FirstOrDefault(i => i.Id == id);
        }

        public static void AddPhone(Phone phone)
        {
             if (phonesList.Count() == 0)
                    phone.Id = 1;
             else
            phone.Id = phonesList.ToList()[phonesList.Count() - 1].Id+ 1;

            
            phonesList.Add(phone);
        }
        public static void DeleteElement(int id)
        {
            phonesList.Remove(phonesList.FirstOrDefault(i => i.Id == id));
        }
        public static void UpdateElement(Phone phone)
        {
            Phone updphone = phonesList.FirstOrDefault(i => i.Id == phone.Id);
            if (updphone != null)
            {
                updphone.Name = phone.Name;
                updphone.Number = phone.Number;
            }
        }
        public static void SaveCollection()
        {
            SerializePhone(phonesList);
        }
        public static void SerializePhone(List<Phone> phonesList)
        {
            string json = JsonSerializer.Serialize(phonesList);
  
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
                    phoneRecords = JsonSerializer.Deserialize<List<Phone>>(fileData);
                else
                    phoneRecords = new List<Phone>();
            }
            return phonesList;
           
        }
    }
}