using CarRental.EF;
using CarRental.EF.Model;
using System;
using System.Collections.Generic;
using System.Linq;

namespace CarRental.BusinessLogic
{
    public static class RentalOperations
    {
        public static void AddCar(Car car)
        {
            var repository = new Repository();
            var carInfo = new Car
            {
                Brand = car.Brand,
                Model = car.Model,
                RegistrationNo = car.RegistrationNo,
                Year = car.Year
            };
            repository.Add(carInfo);
            repository.SaveChanges();
        }

        public static void AddCustomer(Customer customer)
        {
            var repository = new Repository();
            var customerInfo = new Customer
            {
                FirstName = customer.FirstName,
                LastName = customer.LastName,
                Email = customer.Email,
                PhoneNo = customer.PhoneNo
            };
            repository.Add(customerInfo);
            repository.SaveChanges();
        }

        public static void DeleteBooking(int id)
        {
            var repository = new Repository();
            var booking = repository.DataSet<Customer>().Where(x => x.Id == id).SingleOrDefault();
            if (booking != null)
            {
                repository.Remove(booking);
                repository.SaveChanges();
            }   
        }

        public static void DeleteCar(int id)
        {
            var repository = new Repository();
            var car = GetCar(id);
            if (car != null)
            {
                repository.Remove(car);
                repository.SaveChanges();
            }
        }

        public static void DeleteCustomer(int id)
        {
            var repository = new Repository();
            var customer = repository.DataSet<Customer>().Where(x => x.Id == id).SingleOrDefault();
            if(customer != null)
            {
                repository.Remove(customer);
                repository.SaveChanges();
            }   
        }

        public static Booking GetBooking(int Id)
        {
            throw new NotImplementedException();
        }

        public static Car GetCar(int id)
        {
            var repository = new Repository();
            return repository.DataSet<Car>().Where(x => x.Id == id).SingleOrDefault();
        }

        public static ICollection<Car> GetAvailableCars(DateTime startDate, DateTime endDate)
        {
            var repository = new Repository();
            var cars = repository.DataSet<Car>();
            var bookings = repository.DataSet<Booking>().Where(x => x.StartDateTime <= endDate && x.EndDateTime >= startDate);
            cars = cars.Where(x => !bookings.Select(b => b.CarId).Contains(x.Id));
            return cars.ToList();
        }

        public static void ReturnCar(int bookingId)
        {
            var repository = new Repository();
            var booking = repository.DataSet<Booking>().Where(x => x.Id == bookingId).SingleOrDefault();
            if(booking != null)
            {
                booking.CarReturnedDate = DateTime.Now;
                repository.SaveChanges();
            }
        }

        public static void SaveBooking(Booking booking)
        {
            var repository = new Repository();
            repository.Add(booking);
            repository.SaveChanges();
        }

        public static void UpdateCustomer(Customer customer)
        {
            var repository = new Repository();
            var cust = repository.DataSet<Customer>().Where(x => x.Id == customer.Id).SingleOrDefault();
            if(cust != null)
            {
                cust.FirstName = customer.FirstName;
                cust.LastName = customer.LastName;
                cust.Email = customer.Email;
                cust.PhoneNo = customer.PhoneNo;
                repository.Update(cust);
                repository.SaveChanges();
            }            
        }
        public static Customer GetCustomer(int id)
        {
            var repository = new Repository();
            return repository.DataSet<Customer>().Where(x => x.Id == id).SingleOrDefault();
        }

        public static ICollection<Customer> GetCustomers()
        {
            var repository = new Repository();
            return repository.DataSet<Customer>().ToList();
        }

    }
}
