using DemoApi.Models;

namespace DemoApi.Repository;

public interface IWeatherRepository
{
    public List<WeatherForecast> GetAll();
}