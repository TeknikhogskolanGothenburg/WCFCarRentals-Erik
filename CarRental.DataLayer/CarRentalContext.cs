using CarRental.EF.Model;
using System.Data.Entity;

namespace CarRental.EF
{
    public class CarRentalContext : DbContext
    {
        public CarRentalContext()
            : base("name=CarRentalContext")
        {
        }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Booking> Bookings { get; set; }
        public DbSet<Car> Cars { get; set; }
        
    }
}
