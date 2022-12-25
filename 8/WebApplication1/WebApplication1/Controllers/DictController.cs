using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication1.Models;

namespace WebApplication1.Controllers
{
    public class DictController: Controller
    {
        private IPhoneDictionary phoneDictionary;
        public DictController(IPhoneDictionary _phoneDictionary) =>
            phoneDictionary = _phoneDictionary;

        public IActionResult Index()
        {
            return View(phoneDictionary.GetCollection());
        }

        public IActionResult Add()
        {
            return View(phoneDictionary.GetCollection());
        }

        [HttpPost]
        public IActionResult Add(Phone phone)
        {
            phoneDictionary.AddPhone(phone);
            return RedirectToAction("Index");
        }

        public IActionResult Update()
        {
            return View(phoneDictionary.GetCollection());
        }

        [HttpPost]
        public IActionResult Update(Phone phone)
        {
            phoneDictionary.UpdateElement(phone);
            return RedirectToAction("Index");
        }

        public IActionResult Delete()
        {
            return View(phoneDictionary.GetCollection());
        }

        [HttpPost]
        public IActionResult Delete(int id)
        {
            phoneDictionary.DeleteElement(id);
            return RedirectToAction("Index");
        }
    }
}
