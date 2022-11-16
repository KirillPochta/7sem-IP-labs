using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication1.Controllers
{
    public class MResearchController : Controller
    {
        // GET: MResearch
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public string MO1()
        {
            return "GET:MO1";
        }

        [HttpGet]
        public string MO2()
        {
            return "GET:MO2";
        }

        [HttpGet]
        public string MO3()
        {
            return "GET:MO3";
        }

        [HttpGet]
        public string MXX()
        {
            return "GET:MXX";
        }
    }
}