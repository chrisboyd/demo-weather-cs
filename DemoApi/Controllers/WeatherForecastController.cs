using DemoApi.Models;
using DemoApi.Repository;
using Microsoft.AspNetCore.Mvc;

namespace DemoApi.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private readonly ILogger<WeatherForecastController> _logger;
    private readonly IWeatherRepository _weatherRepository;

    public WeatherForecastController(ILogger<WeatherForecastController> logger, IWeatherRepository weatherRepository)
    {
        _logger = logger;
        _weatherRepository = weatherRepository;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public List<WeatherForecast> Get()
    {
        _logger.LogInformation("GET request");
        return _weatherRepository.GetAll();
    }
}