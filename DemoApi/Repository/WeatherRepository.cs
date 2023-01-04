using System.Globalization;
using DemoApi.Data;
using DemoApi.Models;
using Microsoft.EntityFrameworkCore;

namespace DemoApi.Repository;

public class WeatherRepository : IWeatherRepository
{
    private readonly ApplicationDbContext _context;

    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };
    private static List<WeatherForecast> data;

    public WeatherRepository(ApplicationDbContext context)
    {
        _context = context;
        //  data = new List<WeatherForecast>(); 
       //  data.AddRange(Enumerable.Range(1, 5).Select(index => new WeatherForecast
       // {
       //     Date = DateTime.Now.AddDays(index).ToString(CultureInfo.InvariantCulture),
       //     TemperatureC = Random.Shared.Next(-20, 55),
       //     Summary = Summaries[Random.Shared.Next(Summaries.Length)]
       // }));
    }
    public async Task<WeatherForecast[]> GetAll()
    {
        return await _context.WeatherForecasts.ToArrayAsync();
    }
}