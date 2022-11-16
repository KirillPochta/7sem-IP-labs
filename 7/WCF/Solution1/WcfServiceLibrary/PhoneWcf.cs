using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using System.Web.Hosting;

namespace WcfServiceLibrary
{
    // ПРИМЕЧАНИЕ. Команду "Переименовать" в меню "Рефакторинг" можно использовать для одновременного изменения имени класса "Service1" в коде и файле конфигурации.
    public class PhoneWcf : IPhone
    {
        private static readonly string _filePath = "D:\\important\\7sem\\InternetProgramming\\labs\\7\\WCF\\Solution1\\WcfServiceLibrary\\Files\\phones.json";


        public  List<Phone> phonesList;
        public  void SerializePhone(List<Phone> phonesList)
        {
            string json = JsonConvert.SerializeObject(phonesList);

            using (StreamWriter streamWriter = new StreamWriter(_filePath))
            {
                streamWriter.WriteLine(json);
            }
        }
        public  List<Phone> DeserializePhones()
        {
            using (StreamReader fs = new StreamReader(_filePath))
            {
                JsonTextReader jsonTextReader = new JsonTextReader(fs);
                JsonSerializer jsonSerializer = new JsonSerializer();
                var listCheck = jsonSerializer.Deserialize<List<Phone>>(jsonTextReader);
                if (listCheck != null)
                {
                    phonesList = listCheck;
                    phonesList.OrderBy(i => i.Name);
                }
                return phonesList;
            }
        }

        public void AddPhone(Phone phone)
        {
            DeserializePhones();
            if (phonesList.Count == 0)
                phone.Id = 1;
            else
                phone.Id = phonesList[phonesList.Count - 1].Id + 1;
            phonesList.Add(phone);
            SerializePhone(phonesList);
        }

        public void DeletePhone(int id)
        {
            DeserializePhones();
            phonesList.Remove(phonesList.FirstOrDefault(i => i.Id == id));
            SerializePhone(phonesList);
        }

        public List<Phone> GetPhones()
        {
            DeserializePhones();
            return phonesList;
        }

        public void UpdatePhone(Phone phone)
        {
            DeserializePhones();
            Phone updphone = phonesList.FirstOrDefault(i => i.Id == phone.Id);
            if (updphone != null)
            {
                updphone.Name = phone.Name;
                updphone.Number = phone.Number;
            }
            SerializePhone(phonesList);
        }
    }
}
