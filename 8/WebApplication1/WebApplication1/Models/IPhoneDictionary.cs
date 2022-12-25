using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Models
{
    public interface IPhoneDictionary
    {
        List<Phone> GetCollection();
        Phone GetElement(int id);
        void AddPhone(Phone phone);
        void UpdateElement(Phone phone);
        void DeleteElement(int? id);
    }
}
