using DemoApi.Models;
using Microsoft.EntityFrameworkCore;

namespace DemoApi.Data;

public class ApplicationDbContext : DbContext
{
    public DbSet<WeatherForecast> WeatherForecasts { get; set; }

    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
    {
    }

    // protected override void OnModelCreating(ModelBuilder modelBuilder)
    // {
    //     base.OnModelCreating(modelBuilder);
    //     modelBuilder.Entity<WeatherForecast>().HasData(
    //         new WeatherForecast
    //         {
    //             Id = 1,
    //             Date = DateTime.Now.ToString(),
    //             Summary = "is not hot",
    //             TemperatureC = 5,
    //             Overcast = true
    //         });
    // }
}