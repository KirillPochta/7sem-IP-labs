using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;
using System.Web;
using System.Web.Mvc;

namespace _5b1.Controllers
{
    [RoutePrefix("it")]
    public class MResearchController : Controller
    {
        // GET: MResearch
        [Route("{id:int}/{str}")]
        [AcceptVerbs(HttpVerbs.Get)]
        public string M01(int id, string str)
        {
            return "GET:M01 id- " + id.ToString() + " str - " + str;
        }
        [Route("{b:bool}/{letters:alpha}")]
        [AcceptVerbs(HttpVerbs.Post)]
        public string M02(bool b, string letters)
        {
            return Request.HttpMethod + ":M02  b - " + b.ToString() + " letters - " + letters;
        }
        [Route("{f:float}/{str:length(2,5)}")]
        [AcceptVerbs(HttpVerbs.Delete | HttpVerbs.Get)]
        public string M03(float f, string str)
        {
            return Request.HttpMethod + ":M03  f - " + f.ToString() + " str - " + str;
        }
        [Route("{letters:length(3,4)}/{n:range(100,200)}")]
        [AcceptVerbs(HttpVerbs.Put)]
        public string M04(int n, string letters)
        {
            return Request.HttpMethod + ":M04  letters - " + letters + " n - " + n.ToString();
        }
        [Route("{mail:regex(^\\S+@\\S+\\.\\S+$)}")]
        [AcceptVerbs(HttpVerbs.Post)]
        public string M05(string mail)
        {
            return Request.HttpMethod + " mail " + mail;
        }
    }
}