using Newtonsoft.Json;

namespace BestPractiseApi.Data
{
    public class DataService
    {
        public static WeatherForecastData GetWeatherForecastData()
        {
            string allText = System.IO.File.ReadAllText(@"data.json");
            WeatherForecastData dataFromJson = JsonConvert.DeserializeObject<WeatherForecastData>(allText);
            return dataFromJson;
        }
    }
}