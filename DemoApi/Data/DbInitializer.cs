using DemoApi.Models;

namespace DemoApi.Data;

public static class DbInitializer
{
    public static async Task Initialize(ApplicationDbContext context)
    {
        await context.Database.EnsureCreatedAsync();

        if (context.WeatherForecasts.Any())
        {
            return;
        }

        var weathers = new WeatherForecast[]
        {
            new()
            {
                Date = DateTime.Now.ToString(),
                TemperatureC = 5,
                Summary = "something"
            },
            new()
            {
                Date = DateTime.Now.ToString(),
                TemperatureC = 10,
                Summary = "another summary"
            }
        };

        foreach (var weather in weathers)
        {
            context.WeatherForecasts.Add(weather);
        }

        await context.SaveChangesAsync();
    }
    
}