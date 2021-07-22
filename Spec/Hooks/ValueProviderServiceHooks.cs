using Spec.Factories;
using Spec.ServiceObjects;
using TechTalk.SpecFlow;

namespace Spec.Hooks
{
    [Binding]
    internal class ValueProviderServiceHooks
    {
        [BeforeScenario("ValueProviderService")]
        public static void BeforeScenario(ValueProviderServiceFactory factory)
        {
            // initialize api
            ValueProviderService.Initialize(factory.Current);
        }
    }
}
