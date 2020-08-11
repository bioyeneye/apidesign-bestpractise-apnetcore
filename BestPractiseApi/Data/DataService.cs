using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;

namespace BestPractiseApi.Data
{
    public static class DataService
    {
        public static WeatherForecastData GetWeatherForecastData()
        {
            string allText = System.IO.File.ReadAllText(@"data.json");
            WeatherForecastData dataFromJson = JsonConvert.DeserializeObject<WeatherForecastData>(allText);
            return dataFromJson;
        }

        public static List<WeatherForecast> GetPaginatedWeatherForecasts(int limit, int offset)
        {
            try
            {
                return DataService.GetWeatherForecastData()?.Results?
                    .Skip(offset)
                    .Take(limit)
                    .ToList();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}