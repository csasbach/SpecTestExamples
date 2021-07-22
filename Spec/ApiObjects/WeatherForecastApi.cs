using System.Net.Http;

namespace Spec.ApiObjects
{
    internal class WeatherForecastApi
    {
        private const string ApiUrl = "https://localhost:5001/weatherforecast";
        private readonly HttpClient _httpClient;

        private static WeatherForecastApi _instance;
        public static WeatherForecastApi Initialize(HttpClient httpClient)
        {
            return _instance ??= new WeatherForecastApi(httpClient);
        }

        private WeatherForecastApi(HttpClient httpClient) {           
            _httpClient = httpClient;
        }

        public HttpResponseMessage Get()
        {
            return _httpClient.GetAsync(ApiUrl).Result;
        }
    }
}
