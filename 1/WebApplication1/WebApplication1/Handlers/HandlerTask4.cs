using Amazon.Runtime.Internal;
using System;
using System.Web;
using HttpRequest = System.Web.HttpRequest;

namespace WebApplication1.Handlers
{
    public class HandlerTask4 : IHttpHandler
    {
        /// <summary>
        /// Вам потребуется настроить этот обработчик в файле Web.config вашего 
        /// веб-сайта и зарегистрировать его с помощью IIS, чтобы затем воспользоваться им.
        /// см. на этой странице: https://go.microsoft.com/?linkid=8101007
        /// </summary>
        //https://localhost:44379/Html/Task4.html

        public bool IsReusable
        {
            // Верните значение false в том случае, если ваш управляемый обработчик не может быть повторно использован для другого запроса.
            // Обычно значение false соответствует случаю, когда некоторые данные о состоянии сохранены по запросу.
            get { return true; }
        }

        public void ProcessRequest(HttpContext context)
        {
            //разместите здесь вашу реализацию обработчика.
            HttpResponse response = context.Response;

            int x = Convert.ToInt16(context.Request.Form.Get("X"));
            int y = Convert.ToInt16(context.Request.Form.Get("Y"));
            int sum = x + y;
            response.Write(sum);
        }

    }
}
