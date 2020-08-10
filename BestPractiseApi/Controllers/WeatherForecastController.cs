using System;
using System.Linq;
using System.Threading.Tasks;
using BestPractiseApi.models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

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
        public ActionResult Get(int limit = 10, int offset = 0)
        {
            var rng = new Random();
            var data = Enumerable.Range(1, 100).Select(index => new WeatherForecast
                {
                    Id = index,
                    Date = DateTime.Now.AddDays(index),
                    TemperatureC = rng.Next(-20, 55),
                    Summary = Summaries[rng.Next(Summaries.Length)]
                })
                .Skip(offset)
                .Take(limit)
                .ToList();

            return Ok(ConstructPaginatedResult(data, 100, limit, offset));
        }
    }
}