using OpenQA.Selenium;

namespace Spec.Objects.PageObjects
{
    internal class HomePage
    {
        private const string PageUrl = "https://localhost:5001/";
        private readonly IWebDriver _webDriver;

        private static HomePage _instance;
        public static HomePage Initialize(IWebDriver webDriver)
        {
            return _instance ??= new HomePage(webDriver);
        }

        private HomePage(IWebDriver webDriver) {           
            _webDriver = webDriver;
        }

        public void LoadOrReload()
        {
            if (_webDriver.Url != PageUrl)
            {
                _webDriver.Url = PageUrl;
            }
            else
            {
                _webDriver.Navigate().Refresh();
            }
        }

        private IWebElement FetchDataNavigationLink => _webDriver.FindElement(By.LinkText("Fetch data"));

        public void ClickFetchDataNavigationLink()
        {
            FetchDataNavigationLink.Click();
        }
    }
}
