using Spec.Drivers;
using Spec.Objects.PageObjects;
using TechTalk.SpecFlow;

namespace Spec.Hooks
{
    [Binding]
    internal class HomePageHooks
    {
        [BeforeScenario("HomePage")]
        public static void BeforeScenario(BrowserDriver webDriver)
        {
            HomePage.Initialize(webDriver.Current).LoadOrReload();
        }
    }
}
