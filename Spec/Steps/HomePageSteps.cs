using NUnit.Framework;
using OpenQA.Selenium;
using Spec.Drivers;
using Spec.Objects.PageObjects;
using TechTalk.SpecFlow;

namespace Spec.Steps
{
    [Binding]
    public sealed class HomePageSteps
    {
        private readonly ScenarioContext _scenarioContext;

        private IWebDriver _webDriver;
        private IWebDriver WebDriver => _webDriver ??= _scenarioContext.ScenarioContainer.Resolve<BrowserDriver>().Current;

        private HomePage _homePage;
        private HomePage HomePage => _homePage ??= HomePage.Initialize(WebDriver);

        public HomePageSteps(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
        }

        [Given("I am on the home page")]
        public void IAmOnTheHomePage()
        {
            HomePage.LoadOrReload();
        }

        [When(@"I click on the Fetch Data link")]
        public void WhenIClickOnTheFetchDataLink()
        {
            HomePage.ClickFetchDataNavigationLink();
        }
        
        [Then(@"I have navigated to the Weather Forecast page")]
        public void ThenIHaveNavigatedToTheWeatherForecastPage()
        {
            Assert.True(WebDriver.FindElement(By.Id("tabelLabel")).Text == "Weather forecast");
        }

    }
}
