using CarRental.EF.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace CarRental.Service.Model
{
    [MessageContract(IsWrapped = true,
        WrapperName = "CarInfoObject",
        WrapperNamespace = "http://wcfcarrentals.dev/Car")]
    public class CarInfo
    {
        public CarInfo() {}
        public CarInfo(Car car)
        {
            this.Id = car.Id;
            this.RegistrationNo = car.RegistrationNo;
            this.Year = car.Year;
            this.Brand = car.Brand;
            this.Model = car.Model;
            this.IsDeleted = car.IsDeleted;
        }
        [MessageBodyMember(Order = 1, Namespace = "http://wcfcarrentals.dev/Car")]
        public int? Id { get; set; }
        [MessageBodyMember(Order = 2, Namespace = "http://wcfcarrentals.dev/Car")]
        public string RegistrationNo { get; set; }
        [MessageBodyMember(Order = 3, Namespace = "http://wcfcarrentals.dev/Car")]
        public DateTime Year { get; set; }
        [MessageBodyMember(Order = 4, Namespace = "http://wcfcarrentals.dev/Car")]
        public string Brand { get; set; }
        [MessageBodyMember(Order = 5, Namespace = "http://wcfcarrentals.dev/Car")]
        public string Model { get; set; }
        [MessageBodyMember(Order = 6, Namespace = "http://wcfcarrentals.dev/Car")]
        public bool IsDeleted { get; set; }
        
    }
}
