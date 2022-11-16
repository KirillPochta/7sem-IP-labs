using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace PhoneBookLibJson
{
    public class PhoneDictionary : IPhoneDictionary<Phone>
    {
        public static List<Phone> phonesList = new List<Phone>();
       
        public void AddPhone(Phone phone)
        {
            if (phonesList.Count == 0)
                phone.Id = 1;
            else
                phone.Id = phonesList[phonesList.Count - 1].Id + 1;
            phonesList.Add(phone);
        }

        public void DeleteElement(int idDeleted)
        {
            phonesList.Remove(phonesList.FirstOrDefault(i => i.Id == idDeleted));
        }

        public List<Phone> GetCollection()
        {
            phonesList = FileManager.DeserializePhones();
            return new List<Phone>(phonesList);
        }

        public Phone GetElement(int id)
        {
            return phonesList.FirstOrDefault(i => i.Id == id);
        }

        public void SaveCollection()
        {
            FileManager.SerializePhone(phonesList);
        }

        public void UpdateElement(Phone phone)
        {
            Phone updphone = phonesList.FirstOrDefault(i => i.Id == phone.Id);
            if (updphone != null)
            {
                updphone.Name = phone.Name;
                updphone.Number = phone.Number;
            }
        }
    }
}