using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using CarRental.BusinessLogic;
using CarRental.Service.Model;
using CarRental.EF.Model;

namespace CarRental.Service
{
    public class CarRentalService : ICarRentalService
    {
        public void AddCar(CarInfo carInfo)
        {
            
            var car = new Car
            {
                Brand = carInfo.Brand,
                Model = carInfo.Model,
                RegistrationNo = carInfo.RegistrationNo,
                Year = carInfo.Year
            };
            RentalOperations.AddCar(car);
        }

        public void AddCustomer(CustomerInfo customerInfo)
        {
            var customer = new Customer
            {
                FirstName = customerInfo.FirstName,
                LastName = customerInfo.LastName,
                Email = customerInfo.Email,
                PhoneNo = customerInfo.PhoneNo
            };
            RentalOperations.AddCustomer(customer);
        }

        public void DeleteBooking(int id)
        {
            RentalOperations.DeleteBooking(id);
        }

        public void DeleteCar(int id)
        {
            RentalOperations.DeleteCar(id);

        }

        public void DeleteCustomer(int id)
        {
            RentalOperations.DeleteCustomer(id);
        }

        public BookingInfo GetBooking(BookingRequest request)
        {
            if(request.Key != "secretKey")
            {
                throw new FaultException("Wrong credentials");
            }
            var booking = RentalOperations.GetBooking(request.BookingId);
            if(booking == null)
            {
                throw new FaultException("No booking found");
            }
            return new BookingInfo(booking);
        }

        
        public Car GetCar(int id)
        {
            var car = RentalOperations.GetCar(id);
            if (car == null)
            {
                throw new FaultException("No car is found");
            }
            return car;
        }

        public ICollection<Car> GetAvailableCars(DateTime startDate, DateTime endDate)
        {
            var cars = RentalOperations.GetAvailableCars(startDate, endDate);
            if (cars == null || !cars.Any())
            {
                throw new FaultException("No available cars found");
            }
            return cars;
        }

        public void ReturnCar(int bookingId)
        {
            RentalOperations.ReturnCar(bookingId);
        }

        public void SaveBooking(BookingInfo bookingInfo)
        {
            var booking = new Booking
            {
                CustomerId = bookingInfo.CustomerId,
                CarId = bookingInfo.CarId,
                StartDateTime = bookingInfo.StartDate,
                EndDateTime = bookingInfo.EndDate
            };
            RentalOperations.SaveBooking(booking);
            
        }

        public void UpdateCustomer(CustomerInfo customerInfo)
        {
            var customer = new Customer
            {
                Id = (int)customerInfo.Id,
                FirstName = customerInfo.FirstName,
                LastName = customerInfo.LastName,
                Email = customerInfo.Email,
                PhoneNo = customerInfo.PhoneNo
            };
            RentalOperations.UpdateCustomer(customer);
        }

        public Customer GetCustomer(int id)
        {
            var customer = RentalOperations.GetCustomer(id);
            if(customer == null)
            {
                throw new FaultException("No customer found");
            }
            return customer;
        }

        public ICollection<Customer> GetCustomers()
        {
            var customers = RentalOperations.GetCustomers();
            if(customers == null || !customers.Any())
            {
                throw new FaultException("No customers found");
            }
            return customers;
        }
        
    }
}
