using Microsoft.EntityFrameworkCore;
using SmartCity.API.Models;

namespace SmartCity.API.Data
{
    public class SmartCityDbContext : DbContext
    {
        public SmartCityDbContext(DbContextOptions<SmartCityDbContext> options)
            : base(options)
        {
        }

        public DbSet<Department> Departments { get; set; }
        public DbSet<CityZone> CityZones { get; set; }
        public DbSet<Citizen> Citizens { get; set; }
        public DbSet<Employee> Employees { get; set; }
        public DbSet<Service> Services { get; set; }
        public DbSet<ServiceRequest> ServiceRequests { get; set; }
        public DbSet<Complaint> Complaints { get; set; }
        public DbSet<UtilityBill> UtilityBills { get; set; }
        public DbSet<Notification> Notifications { get; set; }
    }
}