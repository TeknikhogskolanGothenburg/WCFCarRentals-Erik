using CarRental.BusinessLogic;
using CarRental.EF.Model;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;

namespace CarRental.Service
{
    public class CarRentalRestService : ICarRentalRestService
    {
        public Car GetCar(int id)
        {
            var car = RentalOperations.GetCar(id);
            return car;
        }

        public List<Customer> GetCustomers()
        {
            var customers = RentalOperations.GetCustomers();
            return customers.ToList();
            
        }

        public void ReturnCar(int bookingId)
        {
            RentalOperations.ReturnCar(bookingId);
        }
        
    }
}
