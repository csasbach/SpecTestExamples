using BoDi;
using Spec.Drivers;
using TechTalk.SpecFlow;

namespace Spec.Hooks
{
    [Binding]
    internal class SharedBrowserHooks
    {
        [BeforeTestRun]
        public static void BeforeTestRun(ObjectContainer testThreadContainer)
        {
            //Initialize a shared BrowserDriver in the global container
            testThreadContainer.BaseContainer.Resolve<BrowserDriver>();
        }
    }
}
