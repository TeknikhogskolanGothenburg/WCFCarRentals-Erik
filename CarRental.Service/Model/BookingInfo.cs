using CarRental.EF.Model;
using System;
using System.ServiceModel;


namespace CarRental.Service.Model
{
    [MessageContract(IsWrapped = true,
        WrapperName = "BookingRequestObject",
        WrapperNamespace = "http://wcfcarrentals.dev/Booking")]
    public class BookingRequest
    {
        [MessageHeader(Namespace = "http://wcfcarrentals.dev/Booking")]
        public string Key { get; set; }
        [MessageBodyMember(Namespace = "http://wcfcarrentals.dev/Booking")]
        public int CustomerId { get; set; }
        [MessageBodyMember(Namespace = "http://wcfcarrentals.dev/Booking")]
        public int BookingId { get; set; }
    }

    [MessageContract(IsWrapped = true,
        WrapperName = "BookingInfoObject",
        WrapperNamespace = "http://wcfcarrentals.dev/Booking")]
    public class BookingInfo
    {
        public BookingInfo() { }
        public BookingInfo(Booking booking)
        {
            this.Id = booking.Id;
            this.CustomerId = booking.Customer.Id;
            this.CustomerName = booking.Customer.FirstName + " " + booking.Customer.LastName;
            this.StartDate = booking.StartDateTime;
            this.EndDate = booking.EndDateTime;
            this.CarId = booking.Car.Id;
            this.CarRegNo = booking.Car.RegistrationNo;
            this.CarBrand = booking.Car.Brand;
            this.CarModel = booking.Car.Model;
            this.CarYear = booking.Car.Year;
        }

        [MessageBodyMember(Order = 1, Namespace = "http://wcfcarrentals.dev/Booking")]
        public int? Id { get; set; }
        [MessageBodyMember(Order = 2, Namespace = "http://wcfcarrentals.dev/Booking")]
        public int CustomerId { get; set; }
        [MessageBodyMember(Order = 3, Namespace = "http://wcfcarrentals.dev/Booking")]
        public string CustomerName { get; set; }
        [MessageBodyMember(Order = 4, Namespace = "http://wcfcarrentals.dev/Booking")]
        public DateTime StartDate { get; set; }
        [MessageBodyMember(Order = 5, Namespace = "http://wcfcarrentals.dev/Booking")]
        public DateTime EndDate { get; set; }
        [MessageBodyMember(Order = 6, Namespace = "http://wcfcarrentals.dev/Booking")]
        public int CarId { get; set; }
        [MessageBodyMember(Order = 7, Namespace = "http://wcfcarrentals.dev/Booking")]
        public string CarRegNo { get; set; }
        [MessageBodyMember(Order = 8, Namespace = "http://wcfcarrentals.dev/Booking")]
        public string CarBrand { get; set; }
        [MessageBodyMember(Order = 9, Namespace = "http://wcfcarrentals.dev/Booking")]
        public string CarModel { get; set; }
        [MessageBodyMember(Order = 10, Namespace = "http://wcfcarrentals.dev/Booking")]
        public DateTime CarYear { get; set; }
        

    }
}
