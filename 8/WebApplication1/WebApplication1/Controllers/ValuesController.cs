using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    [Produces("application/json")]
    [ApiController]
    [Route("api/[controller]")]
    public class ValuesController: ControllerBase
    {
        private IPhoneDictionary phoneDictionary;
        public ValuesController(IPhoneDictionary _phoneDictionary) =>
            phoneDictionary = _phoneDictionary;

        // GET api/
        [HttpGet]
        public ActionResult Get()
        {
            var telephones = phoneDictionary.GetCollection();
            if (telephones == null)
            {
                return NoContent();
            }
            return Ok(telephones);
        }

        // GET api/5
        [HttpGet("{id:int}")]
        public ActionResult Get(int id)
        {
            var telephones = phoneDictionary.GetElement(id);
            if (telephones == null)
            {
                return NoContent();
            }
            return Ok(telephones);
        }

        // POST api/
        [HttpPost]
        public ActionResult Post(Phone telephone)
        {
            phoneDictionary.AddPhone(telephone);
            return Ok(telephone);
        }

        // PUT api/
        [HttpPut]
        public ActionResult Put(Phone telephone)
        {
            if (telephone != null)
            {
                phoneDictionary.UpdateElement(telephone);
                return Ok(telephone);
            }
            else
                return NoContent();
        }

        // DELETE api/5
        [HttpDelete("{id:int}")]
        public ActionResult Delete(int id)
        {
                phoneDictionary.DeleteElement(id);
                return Ok();
        }
    }
}
