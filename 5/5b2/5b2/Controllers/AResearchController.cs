using _5b2.Filters;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using static _5b2.Filters.ResultFr;

namespace _5b2.Controllers
{
    public class AResearchController : Controller
    {
        // GET: AResearch
        [ActionFr]
        public ActionResult AA()
        {
            return Content("AA test\n");
        }

        [ResultFr]
        public ActionResult AR()
        {
            return Content("AR test\n");
        }

        [ExeptionFr]
        public ActionResult AE()
        {
            throw new Exception("From AE");
        }
    }
}