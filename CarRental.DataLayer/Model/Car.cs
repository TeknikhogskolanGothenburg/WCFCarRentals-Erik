using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace CarRental.EF.Model
{
    [DataContract]
    public class Car
    {
        public Car() { }
        [DataMember]
        public int Id { get; set; }
        [DataMember]
        [Index(IsUnique=true)]
        [MaxLength(6)]
        public string RegistrationNo { get; set; }
        [DataMember]
        public DateTime Year { get; set; }
        [DataMember]
        public string Brand { get; set; }
        [DataMember]
        public string Model { get; set; }
        [DataMember]
        public bool IsDeleted { get; set; }        

    }
}
