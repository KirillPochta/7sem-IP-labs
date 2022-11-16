using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.IO;
//using PhoneBookLibJson;
using PhoneRepositorySql;

namespace _3.Controllers
{
    public class DictController : Controller
    {
        // создаем контекст данных
        //PhoneContext db = new PhoneContext();
        IPhoneDictionary<Phone> phones = null;
        public DictController(IPhoneDictionary<Phone> phones)
        {
            this.phones = phones;
        }
        [HttpGet]
        public ActionResult Index()
        {
            ViewBag.Phones = phones.GetCollection() != null ? ViewBag.Phones = phones.GetCollection() : ViewBag.Phones = null;
            // возвращаем представление
            return View(phones.GetCollection());
        }
        [HttpGet]
        public ActionResult Add()
        {
            return View("AddPhone");
        }
        [HttpPost]
        public ActionResult AddSave(Phone phone)
        {
            phones.AddPhone(phone);
            phones.SaveCollection();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteSave(int id)
        {
            phones.DeleteElement(id);
            phones.SaveCollection();
            return RedirectToAction("Index");
        }
        public ActionResult Delete(int id)
        {
            ViewBag.Id = id;
            return View();
        }
     
        [HttpGet]
        public ActionResult Update(int id)
        {
            ViewBag.Id = id;
            Phone updPhone = phones.GetElement(id);
            ViewBag.Name = updPhone.Name;
            ViewBag.Number = updPhone.Number;
            return View();
        }
        [HttpPost]
        public ActionResult UpdateSave(Phone phone)
        {
            phones.UpdateElement(phone);
            phones.SaveCollection();
            return RedirectToAction("Index");
        }
    }
}