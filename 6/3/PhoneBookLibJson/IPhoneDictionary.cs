using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PhoneBookLibJson
{
    public interface IPhoneDictionary<T> where T : class
    {
        List<T> GetCollection();
        T GetElement(int id);
        void AddPhone(T phone);
        void DeleteElement(int idDeleted);
        void UpdateElement(T phone);
        void SaveCollection();

    }
}
