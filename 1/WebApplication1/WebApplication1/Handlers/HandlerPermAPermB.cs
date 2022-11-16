using Amazon.Runtime.Internal;
using System;
using System.Web;
using HttpRequest = System.Web.HttpRequest;

namespace WebApplication1.Handlers
{
    public class HandlerPermAPermB : IHttpHandler
    {
        

        public bool IsReusable
        {
          get { return true; }
        }

        public void ProcessRequest(HttpContext context)
        {
            HttpRequest request = context.Request; 
            HttpResponse response = context.Response;

            string ParmA = request.Params.Get("ParmA");
            string ParmB = request.Params.Get("ParmB");

            response.Write("GET-HTTP-PKA: ParmA = " + ParmA + ", " + "ParmB = " + ParmB);
        }

    }
}
