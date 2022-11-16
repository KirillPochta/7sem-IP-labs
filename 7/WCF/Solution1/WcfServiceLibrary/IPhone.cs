using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace WcfServiceLibrary
{
    [ServiceContract]
    public interface IPhone
    {
        [OperationContract]
        List<Phone> GetPhones();

        [OperationContract]
        void UpdatePhone(Phone phone);
        
        [OperationContract]
        void DeletePhone(int id);
        
        [OperationContract]
        void AddPhone(Phone phone);

        // TODO: Добавьте здесь операции служб
    }

    [DataContract]
    public class Phone
    {
        [DataMember]
        public int Id { get; set; }

        [DataMember]
        public string Name { get; set; }
    
        [DataMember]
        public int Number { get; set; }
    }
}
