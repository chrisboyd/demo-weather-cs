using DemoApi.Models;

namespace DemoApi.Repository;

public class WeatherRepository : IWeatherRepository
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };
    private static List<WeatherForecast> data;

    public WeatherRepository()
    {
        data = new List<WeatherForecast>();
        data.AddRange(Enumerable.Range(1, 5).Select(index => new WeatherForecast
       {
           Date = DateTime.Now.AddDays(index),
           TemperatureC = Random.Shared.Next(-20, 55),
           Summary = Summaries[Random.Shared.Next(Summaries.Length)]
       }));
        
    }
    public List<WeatherForecast> GetAll()
    {
        return data;
    }
}