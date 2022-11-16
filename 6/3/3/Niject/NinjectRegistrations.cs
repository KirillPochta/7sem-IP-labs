using Ninject.Modules;
using Ninject.Web.Common;
//using PhoneBookLibJson;
using PhoneRepositorySql;

namespace _3.Niject
{
    class NinjectRegistrations : NinjectModule
    {
        public override void Load()
        {
            Bind<IPhoneDictionary<Phone>>().To<PhoneDictionary>();
            //Bind<IPhoneDictionary<Phone>>().To<PhoneDictionary>().InThreadScope();
            //Bind<IPhoneDictionary<Phone>>().To<PhoneDictionary>().InRequestScope();
        }
    }
}