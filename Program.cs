using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AttCommunicationsManager.Classes;
using System.Net;

namespace SimpleWebServer
{
    class Program
    {
        private static WebServer _webServer;

        static void Main(string[] args)
        {
            StartWebServer();
        }

        private static void StartWebServer()
        {
            if (_webServer == null)
            {
                _webServer = new WebServer(SendResponse, "http://localhost:2468/auth/callback/");
            }

            _webServer.Run();

            Console.ReadKey();
        }

        private static void StopWebServer()
        {
            _webServer.Stop();
        }

        private static String SendResponse(HttpListenerRequest request)
        {
            return "<HTML><BODY>derp</BODY></HTML>";
        }
    }
}
