using Amazon.Runtime.Internal;
using DevExpress.Utils.About;
using System;
using System.Net.WebSockets;
using System.Threading.Tasks;
using System.Threading;
using System.Web;
using System.Web.WebSockets;
using HttpRequest = System.Web.HttpRequest;

namespace WebApplication1.Handlers
{
    public class HandlerTask7 : IHttpHandler
    {

        //https://localhost:44379/PKA?ParmA=aaa&ParmB=bbb
        WebSocket socket;

        public bool IsReusable
        {

            get { return true; }
        }

        public void ProcessRequest(HttpContext context)
        {
            if (context.IsWebSocketRequest)
            {
                context.AcceptWebSocketRequest(WebSocketRequest);
            }
        }
        private async Task WebSocketRequest(AspNetWebSocketContext context)
        {
            socket = context.WebSocket;
            string s = await Receive();
            await Send(s);

            Thread thread = new Thread(new ThreadStart(CloseSocket));
            thread.Start();

            while (socket.State == WebSocketState.Open)
            {
                Thread.Sleep(2000);
                await Send("[" + DateTime.Now.ToString("HH:mm:ss") + "]");
            }


        }

        private async Task<string> Receive()
        {
            string rc = null;
            var buffer = new ArraySegment<byte>(new byte[512]);
            var result = await socket.ReceiveAsync(buffer, CancellationToken.None);
            rc = System.Text.Encoding.UTF8.GetString(buffer.Array, 0, result.Count);
            return rc;
        }

        private async Task Send(string s)
        {
            var sendbuffer = new ArraySegment<byte>(System.Text.Encoding.UTF8.GetBytes("Ответ:" + s));
            await socket.SendAsync(sendbuffer, System.Net.WebSockets.WebSocketMessageType.Text,
            true, CancellationToken.None);
        }

        private async void CloseSocket()
        {
            string rc = null;

            do
            {
                var buffer = new ArraySegment<byte>(new byte[512]);
                var result = await socket.ReceiveAsync(buffer, CancellationToken.None);
                rc = System.Text.Encoding.UTF8.GetString(buffer.Array, 0, result.Count);



                if (rc.Equals("stop"))
                {

                    _ = socket.CloseAsync(WebSocketCloseStatus.NormalClosure, "socket closed", CancellationToken.None);
                    return;
                }


            } while (rc == null || rc.Equals("stop"));
        }

    }
}
