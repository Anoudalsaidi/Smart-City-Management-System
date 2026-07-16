using Microsoft.EntityFrameworkCore;


namespace SmartCity.API
{
    public class SmartCityDbContext : DbContext
    {
        public SmartCityDbContext(DbContextOptions<SmartCityDbContext> options)
            : base(options)
        {
        }
    }
}

