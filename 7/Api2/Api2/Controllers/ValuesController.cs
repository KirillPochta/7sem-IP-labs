using Api2.Models;
using System.Collections.Generic;
using System.Web.Http;


namespace Api2.Controllers
{
    public class ValuesController : ApiController
    {
        PhoneContext phoneContext = new PhoneContext();

        // GET api/values
        [HttpGet]
        public IEnumerable<Phone> GetPhones()
        {
            return phoneContext.GetCollection();
        }

        [HttpGet]
        public Phone GetPhone(int id)
        {
            return phoneContext.GetElement(id);
        }

        [HttpPost]
        public void PostPhone([FromBody] Phone phone)
        {
            phoneContext.AddPhone(phone);
        }
        
        [HttpPut]
        public void PutPhone(int id, [FromBody] Phone phone)
        {
            if (id == phone.Id)
            {
                phoneContext.UpdateElement(phone);
            }
        }
        [HttpDelete]
        public void DeletePhone(int id)
        {
            phoneContext.DeleteElement(id);
        }
    }
}