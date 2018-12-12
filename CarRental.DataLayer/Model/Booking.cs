using System;
using System.Runtime.Serialization;

namespace CarRental.EF.Model
{
    [DataContract]
    public class Booking
    {
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        public DateTime StartDateTime { get; set; }
        [DataMember]
        public DateTime EndDateTime { get; set; }
        [DataMember]
        public Customer Customer { get; set; }
        [DataMember]
        public int CustomerId { get; set; }
        [DataMember]
        public Car Car { get; set; }
        [DataMember]
        public int CarId { get; set; }
        [DataMember]
        public DateTime? CarReturnedDate { get; set; }

    }
    
}
