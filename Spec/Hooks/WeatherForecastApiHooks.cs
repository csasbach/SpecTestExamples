using Spec.ApiObjects;
using Spec.Clients;
using TechTalk.SpecFlow;

namespace Spec.Hooks
{
    [Binding]
    internal class WeatherForecastApiHooks
    {
        [BeforeScenario("WeatherForecastApi")]
        public static void BeforeScenario(HttpClient httpClient)
        {
            // initialize api
            WeatherForecastApi.Initialize(httpClient.Current);
        }
    }
}
