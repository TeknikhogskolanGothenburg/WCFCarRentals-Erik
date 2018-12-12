using CarRental.EF.Model;
using System.ServiceModel;

namespace CarRental.Service.Model
{
    [MessageContract(IsWrapped = true,
        WrapperName = "CustomerInfoObject",
        WrapperNamespace = "http://wcfcarrentals.dev/Customer")]
    public class CustomerInfo
    {
        public CustomerInfo() { }
        public CustomerInfo(Customer customer)
        {
            this.Id = customer.Id;
            this.FirstName = customer.FirstName;
            this.LastName = customer.LastName;
            this.PhoneNo = customer.PhoneNo;
            this.Email = customer.Email;            
        }

        [MessageBodyMember(Order = 1, Namespace = "http://wcfcarrentals.dev/Customer")]
        public int? Id { get; set; }
        [MessageBodyMember(Order = 2, Namespace = "http://wcfcarrentals.dev/Customer")]
        public string FirstName { get; set; }
        [MessageBodyMember(Order = 3, Namespace = "http://wcfcarrentals.dev/Customer")]
        public string LastName { get; set; }
        [MessageBodyMember(Order = 4, Namespace = "http://wcfcarrentals.dev/Customer")]
        public string PhoneNo { get; set; }
        [MessageBodyMember(Order = 5, Namespace = "http://wcfcarrentals.dev/Customer")]
        public string Email { get; set; }
    }
}
