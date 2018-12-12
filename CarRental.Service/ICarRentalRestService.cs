using CarRental.EF.Model;
using System.Collections.Generic;
using System.ServiceModel;
using System.ServiceModel.Web;

namespace CarRental.Service
{
    [ServiceContract]
    public interface ICarRentalRestService
    {
        [OperationContract]
        [WebInvoke(Method = "POST",
             UriTemplate = "GetCar",
          RequestFormat = WebMessageFormat.Json,
          ResponseFormat = WebMessageFormat.Json,
          BodyStyle = WebMessageBodyStyle.WrappedRequest)]
        Car GetCar(int id);

        [OperationContract]
        [WebGet(UriTemplate = "GetCustomers",
         RequestFormat = WebMessageFormat.Json,
         ResponseFormat = WebMessageFormat.Json,
        BodyStyle = WebMessageBodyStyle.WrappedRequest)]
        List<Customer> GetCustomers();

        [OperationContract]
        [WebInvoke(Method = "PUT",
         UriTemplate = "ReturnCar",
         RequestFormat = WebMessageFormat.Json,
         ResponseFormat = WebMessageFormat.Json,
         BodyStyle = WebMessageBodyStyle.Wrapped)]
        void ReturnCar(int bookingId);


    }
}
