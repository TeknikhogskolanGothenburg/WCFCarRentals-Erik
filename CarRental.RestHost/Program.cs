using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.ServiceModel.Description;
using System.ServiceModel.Web;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.RestHost
{
    public class Program
    {
        static void Main(string[] args)
        {
            WebServiceHost restHost = new WebServiceHost(typeof(Service.CarRentalRestService),
               new Uri("http://localhost:8082"));

            ServiceEndpoint ep = restHost.AddServiceEndpoint(typeof(Service.ICarRentalRestService), new WebHttpBinding(), "");

            restHost.Description.Endpoints[0].Behaviors.Add(new WebHttpBehavior { HelpEnabled = true });

            ServiceDebugBehavior sdb = restHost.Description.Behaviors.Find<ServiceDebugBehavior>();
            sdb.IncludeExceptionDetailInFaults = true;

            restHost.Open();
            Console.WriteLine("Rest host started @ " + DateTime.Now.ToString());
            Console.ReadLine();
            restHost.Close();
        }
    }
}
