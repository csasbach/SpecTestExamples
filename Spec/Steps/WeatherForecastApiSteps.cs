using System.Collections.Generic;
using System.Net.Http;
using App;
using Newtonsoft.Json;
using NUnit.Framework;
using Spec.Objects.ApiObjects;
using TechTalk.SpecFlow;
using HttpClient = Spec.Clients.HttpClient;

// ReSharper disable InconsistentNaming

namespace Spec.Steps
{
    [Binding]
    internal sealed class WeatherForecastApiSteps
    {
        private readonly ScenarioContext _scenarioContext;

        private System.Net.Http.HttpClient _httpClient;
        private System.Net.Http.HttpClient HttpClient => _httpClient ??= _scenarioContext.ScenarioContainer.Resolve<HttpClient>().Current;

        private WeatherForecastApi _weatherForecastApi;
        private WeatherForecastApi WeatherForecastApi => _weatherForecastApi ??= WeatherForecastApi.Initialize(HttpClient);

        private HttpResponseMessage GetResponse
        {
            set => _scenarioContext["GetResponse"] = value;
            get
            {
                if (_scenarioContext.TryGetValue("GetResponse", out var response) && response is HttpResponseMessage httpResponseMessage)
                {
                    return httpResponseMessage;
                }

                Assert.Fail("Could not find 'GetResponse' in the scenario context.");
                return null;
            }
        }

        public WeatherForecastApiSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [When(@"I make a valid request to the GET endpoint of the WeatherForecast API")]
        public void WhenIMakeAValidRequestToTheGETEndpointOfTheWeatherForecastAPI()
        {
            GetResponse = WeatherForecastApi.Get();
        }
        
        [Then(@"I retrieve the weather forecast data")]
        public void ThenIRetrieveTheWeatherForecastData()
        {
            var data = JsonConvert.DeserializeObject<List<WeatherForecast>>(GetResponse.Content.ReadAsStringAsync().Result);

            Assert.IsNotNull(data);
        }
    }
}
