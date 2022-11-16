using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication25b.Controllers
{
    public class CResearchController : Controller
    {
        // GET: CResearch
        public ActionResult Index()
        {
            return View();
        }
        [ActionName("C01")]
        [AcceptVerbs("get", "post")]
        public ActionResult C01()
        {
            ViewBag.Request = Request;
            ViewBag.Params = Request;

            ViewBag.Method = "Method: " + Request.HttpMethod == "GET" ? ViewBag.Method = "Get" : ViewBag.Method = "Post";
          //  ViewBag.Params =  Request.Params.Count == 0 ? ViewBag.Params = "No Params" : ViewBag.Params = Request.Params;

            return View("");
        }
        [ActionName("C02")]
        [AcceptVerbs("get", "post")]
        public ActionResult C02()
        {
            ViewBag.Request = Request;
            ViewBag.Response = Response;

            
            return View("C02");
        }


    }
}