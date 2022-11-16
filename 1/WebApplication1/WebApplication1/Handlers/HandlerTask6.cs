using Amazon.Runtime.Internal;
using DevExpress.Utils.About;
using System;
using System.Web;
using HttpRequest = System.Web.HttpRequest;

namespace WebApplication1.Handlers
{
    public class HandlerTask6 : IHttpHandler
    {
       
        //https://localhost:44379/PKA?ParmA=aaa&ParmB=bbb

        public bool IsReusable
        {
            // Верните значение false в том случае, если ваш управляемый обработчик не может быть повторно использован для другого запроса.
            // Обычно значение false соответствует случаю, когда некоторые данные о состоянии сохранены по запросу.
            get { return true; }
        }

        public void ProcessRequest(HttpContext context)
        {
            //разместите здесь вашу реализацию обработчика.
            if (context.Request.HttpMethod == "GET") context.Response.WriteFile("Html/Task6.html");
            if (context.Request.HttpMethod == "POST") 
            {

                int x = Convert.ToInt16(context.Request.Form.Get("X"));
                int y = Convert.ToInt16(context.Request.Form.Get("Y"));
                int mul = x * y;
                context.Response.Write(mul);
            }
        }

    }
}
