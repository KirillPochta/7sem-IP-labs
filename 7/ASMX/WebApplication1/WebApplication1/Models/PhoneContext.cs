using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication1.Models
{
    public class PhoneContext
    {
        public List<Phone> phonesList = new List<Phone>();

        public PhoneContext() =>
            phonesList = FileManager.DeserializePhones();

        public void AddPhone(Phone phone)
        {
            if (phonesList.Count == 0)
                phone.Id = 1;
            else
                phone.Id = phonesList[phonesList.Count - 1].Id + 1;
            phonesList.Add(phone);
            FileManager.SerializePhone(phonesList);
        }

        public void DeleteElement(int idDeleted)
        {
            phonesList.Remove(phonesList.FirstOrDefault(i => i.Id == idDeleted));
            FileManager.SerializePhone(phonesList);
        }

        public List<Phone> GetCollection()
        {
            return phonesList;
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
            FileManager.SerializePhone(phonesList);
        }
    }
}