using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using WcfServiceLibrary;
namespace Host
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(Phone)))
            {
                host.Open();
                Console.WriteLine($"Host start");
                Console.WriteLine("Press any button to stop the service.");
                Console.ReadLine();
                host.Close();
                Console.WriteLine("Service stoped.");
            }
        }
    }
}
