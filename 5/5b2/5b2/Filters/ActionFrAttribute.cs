using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace _5b2.Filters
{
    public class ActionFrAttribute : FilterAttribute, IActionFilter
    {
        public void OnActionExecuted(ActionExecutedContext filterContext)
        {
            filterContext.HttpContext.Response.Write("<p> ActionFr:OnActionExecuted</p>");
        }

        public void OnActionExecuting(ActionExecutingContext filterContext)
        {
            filterContext.HttpContext.Response.Write("<p> ActionFr:OnActionExecuting</p>");
        }
    }
    public class ResultFr : FilterAttribute, IResultFilter
    {
        public void OnResultExecuted(ResultExecutedContext filterContext)
        {
            filterContext.HttpContext.Response.Write("<p>ResultFr:OnResultExecuted</p>");
        }

        public void OnResultExecuting(ResultExecutingContext filterContext)
        {
            filterContext.HttpContext.Response.Write("<p>ResultFr:OnResultExecuting</p>");
        }
        public class ExeptionFr : FilterAttribute, IExceptionFilter
        {
            public void OnException(ExceptionContext filterContext)
            {
                filterContext.HttpContext.Response.Write("<p>ExeptionFr:OnException</p>");
                ViewResult vr = new ViewResult();
                vr.ViewName = "Error";
                filterContext.Result = vr;
                filterContext.ExceptionHandled = true;
            }
        }
    }
}