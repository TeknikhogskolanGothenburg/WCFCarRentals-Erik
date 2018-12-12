using System;
using System.Runtime.Serialization;

namespace CarRental.EF.Model
{
    [DataContract]
    public class Customer
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public string FirstName { get; set; }
        [DataMember]
        public string LastName { get; set; }
        [DataMember]
        public string PhoneNo { get; set; }
        [DataMember]
        public string Email { get; set; }
        
    }
}
