using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Hosting;
using System.Web.Mvc;
using System.Web.UI;

namespace _5b3.Controllers
{
    public class CHResearchController : Controller
    {
        // GET: CHResearch
        [AcceptVerbs(HttpVerbs.Get)]
        [OutputCache(Duration = 5, Location = OutputCacheLocation.Any)]
        public ActionResult AD()
        {
            return Content("AD:GET" + DateTime.Now.ToString());
        }
        [AcceptVerbs(HttpVerbs.Post)]
        [OutputCache(Duration = 15, Location = OutputCacheLocation.Any, VaryByParam ="x")]
        public ActionResult AP(int x, int y)
        {

            return Content("AP:POST" + DateTime.Now.ToString() + "| x:" + x + "y:" + y);
        }
    }
}//что можно кешировать