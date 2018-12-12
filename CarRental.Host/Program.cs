using System;
using System.ServiceModel;

namespace CarRental.Host
{
    class Program
    {
        static void Main(string[] args)
        {
            using (ServiceHost host = new ServiceHost(typeof(CarRental.Service.CarRentalService)))
            {
                host.Open();
                Console.WriteLine("Host started @ " + DateTime.Now.ToString());
                Console.ReadLine();
                host.Close();                
            }
        }
    }
}
