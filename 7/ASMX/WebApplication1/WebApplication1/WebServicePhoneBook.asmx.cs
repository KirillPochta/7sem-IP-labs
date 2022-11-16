using System.Collections.Generic;
using System.Web.Services;
using WebApplication1.Models;

namespace WebApplication1
{
    /// <summary>
    /// Сводное описание для WebService1
    /// </summary>
    [WebService(Namespace = "http://PKA.by/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Чтобы разрешить вызывать веб-службу из скрипта с помощью ASP.NET AJAX, раскомментируйте следующую строку. 
    // [System.Web.Script.Services.ScriptService]
    public class WebServicePhoneBook : System.Web.Services.WebService
    {
        PhoneContext phoneContext = new PhoneContext();

        [WebMethod]
        public List<Phone> GetDict()
        {
            return phoneContext.GetCollection();
        }
        
        [WebMethod]
        public void AddDict(Phone phone)
        {
            phoneContext.AddPhone(phone);
        }
        
        [WebMethod]
        public void UpdDict(Phone phone)
        {
            phoneContext.UpdateElement(phone);
        }
        
        [WebMethod]
        public void DelDict(int id)
        {
            phoneContext.DeleteElement(id);
        }
    }
}
