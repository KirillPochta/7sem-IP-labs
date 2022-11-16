using Amazon.Runtime.Internal;
using System;
using System.Web;
using HttpRequest = System.Web.HttpRequest;

namespace WebApplication1.Handlers
{
    public class HandlerTask2 : IHttpHandler
    {
        /// <summary>
        /// Вам потребуется настроить этот обработчик в файле Web.config вашего 
        /// веб-сайта и зарегистрировать его с помощью IIS, чтобы затем воспользоваться им.
        /// см. на этой странице: https://go.microsoft.com/?linkid=8101007
        /// </summary>
        //https://localhost:44379/PKA2/?ParmA=aa&ParmB=bbb

        public bool IsReusable
        {
            // Верните значение false в том случае, если ваш управляемый обработчик не может быть повторно использован для другого запроса.
            // Обычно значение false соответствует случаю, когда некоторые данные о состоянии сохранены по запросу.
            get { return true; }
        }

        public void ProcessRequest(HttpContext context)
        {
            //разместите здесь вашу реализацию обработчика.
            HttpRequest request = context.Request; 
            HttpResponse response = context.Response;

            string ParmA = request.Params.Get("ParmA");
            string ParmB = request.Params.Get("ParmB");

            response.Write("POST-HTTP-PKA: ParmA = " + ParmA + ", " + "ParmB = " + ParmB);
        }

    }
}
