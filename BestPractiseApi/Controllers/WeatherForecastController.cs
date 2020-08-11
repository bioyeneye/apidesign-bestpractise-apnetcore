using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using BestPractiseApi.Data;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;

namespace BestPractiseApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : BaseApiController
    {
        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<WeatherForecastController> _logger;

        public WeatherForecastController(ILogger<WeatherForecastController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        public IActionResult Get(int limit = 10, int offset = 0)
        {
            try
            {
                var data = DataService.GetPaginatedWeatherForecasts(limit, offset);
                return Ok(ConstructPaginatedResult(data ?? new List<WeatherForecast>(), 100, limit, offset));
            }
            catch (Exception e)
            {
                return  StatusCode(StatusCodes.Status500InternalServerError);
            }
        }
    }
}