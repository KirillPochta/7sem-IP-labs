using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneRepositorySql
{
    public class PhoneDictionary : IPhoneDictionary<Phone>
    {
        public static List<Phone> phonesList = new List<Phone>();
        PhoneContext db = new PhoneContext();
        public void AddPhone(Phone phone)
        {
            if (db.Phones.Count() == 0)
                phone.Id = 1;
            else
                phone.Id = db.Phones.ToList()[db.Phones.Count() - 1].Id + 1;
            db.Phones.Add(phone);
        }

        public void DeleteElement(int id)
        {
            db.Phones.Remove(db.Phones.FirstOrDefault(i => i.Id == id));
        }

        public List<Phone> GetCollection()
        {
            db.Database.CreateIfNotExists();
            return new List<Phone>(db.Phones);
        }

        public Phone GetElement(int id)
        {
            return db.Phones.FirstOrDefault(i => i.Id == id);
        }

        public void SaveCollection()
        {
            db.SaveChanges();
        }

        public void UpdateElement(Phone phone)
        {
            Phone updphone = db.Phones.FirstOrDefault(i => i.Id == phone.Id);
            if (updphone != null)
            {
                updphone.Name = phone.Name;
                updphone.Number = phone.Number;
            }
        }
    }
}
