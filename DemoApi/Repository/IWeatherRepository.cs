using DemoApi.Models;

namespace DemoApi.Repository;

public interface IWeatherRepository
{
    public Task<WeatherForecast[]> GetAll();
}