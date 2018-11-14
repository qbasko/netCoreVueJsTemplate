using System.Collections.Generic;
using netCoreVueJsTemplate.Models;

namespace netCoreVueJsTemplate.Providers
{
    public interface IWeatherProvider
    {
        List<WeatherForecast> GetForecasts();
    }
}
