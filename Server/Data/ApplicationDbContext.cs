using Microsoft.EntityFrameworkCore;
using WeatherApp1.Shared;

namespace WeatherApp1.Server.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<CitySearch> CitySearched { get; set; }


    }
}

