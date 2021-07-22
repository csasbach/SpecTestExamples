using Spec.Clients;
using Spec.Objects.ApiObjects;
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
