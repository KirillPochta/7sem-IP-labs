using _3.Models;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using System.Web.Mvc;
using System.IO;
namespace _3.Controllers
{
    public class DictController : Controller
    {
        public IEnumerable<Phone> phonesCollection = PhoneDbInitializer.GetCollection().OrderBy(i => i.Name);

        // создаем контекст данных
        [HttpGet]
        public ActionResult Index()
        {
            ViewBag.Phones = phonesCollection;
            // возвращаем представление
            return View();
        }
        [HttpGet]
        public ActionResult Add()
        {
            return View("AddPhone");
        }
        [HttpPost]
        public ActionResult AddSave(Phone phone)
        {
            PhoneDbInitializer.AddPhone(phone);
            PhoneDbInitializer.SaveCollection();
            return RedirectToAction("Index");
        }
        public ActionResult DeleteSave(int id)
        {
            PhoneDbInitializer.DeleteElement(id);
            PhoneDbInitializer.SaveCollection();
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
            Phone updPhone = PhoneDbInitializer.GetElement(id);
            ViewBag.Name = updPhone.Name;
            ViewBag.Number = updPhone.Number;
            return View();
        }
        [HttpPost]
        public ActionResult UpdateSave(Phone phone)
        {
            PhoneDbInitializer.UpdateElement(phone);
            PhoneDbInitializer.SaveCollection();
            return RedirectToAction("Index");
        }
    }
}