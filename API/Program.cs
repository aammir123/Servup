using Microsoft.Owin.Hosting;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace API
{
    class Program
    {
        static void Main(string[] args)
        {
            string baseUri = ConfigurationManager.AppSettings["APIServer"];

            Console.WriteLine("Starting ServupApiPlatform...");
            using (WebApp.Start<Startup>(baseUri))
            {
                Console.WriteLine("Api Server for Mobile Application is running at {0} - press Enter to quit. ", baseUri);
                var fullUrl = baseUri.Replace("*", "localhost");
                LaunchDocumentation(fullUrl);
                Console.ReadLine();
            }
        }

        static void LaunchDocumentation(string url)
        {
            try
            {
                Process.Start("chrome.exe", string.Format("--incognito {0}", url + "/swagger/ui/index"));
            }
            catch { }
        }
    }
}
