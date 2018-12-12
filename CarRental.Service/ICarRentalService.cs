using System;
using System.Collections.Generic;
using System.ServiceModel;
using CarRental.Service.Model;
using CarRental.EF.Model;

namespace CarRental.Service
{
    [ServiceContract]
    public interface ICarRentalService
    {
        [OperationContract]
        BookingInfo GetBooking(BookingRequest request);
       

        [OperationContract]
        void SaveBooking(BookingInfo bookingInfo);

        [OperationContract]
        void DeleteBooking(int id);

        [OperationContract]
        void ReturnCar(int bookingId);

        [OperationContract]
        void AddCar(CarInfo car);

        [OperationContract]
        Car GetCar(int id);

        [OperationContract]
        ICollection<Car> GetAvailableCars(DateTime startDate, DateTime endDate);

        [OperationContract]
        void DeleteCar(int id);

        [OperationContract]
        Customer GetCustomer(int id);

        [OperationContract]
        ICollection<Customer> GetCustomers();

        [OperationContract]
        void AddCustomer(CustomerInfo customerInfo);

        [OperationContract]
        void UpdateCustomer(CustomerInfo customerInfo);

        [OperationContract]
        void DeleteCustomer(int id);
        



        
    }
}
