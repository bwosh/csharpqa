using System;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Firefox;
using SeleniumIntro.PageObjects;

namespace SeleniumIntro.Framework
{
    class Common
    {
        const BrowserType DefaultBrowser = BrowserType.Firefox;

        public static MainPage EnterMainPage(BrowserType browserType = DefaultBrowser)
        {
            return EnterPage(Settings.HomePageUrl, driver => new MainPage(driver), browserType);
        }

        public static T EnterPage<T>(string url, Func<IWebDriver, T> creationFunction, BrowserType browserType = DefaultBrowser)
        {
            IWebDriver driver = null;

            switch (browserType)
            {
                case BrowserType.Firefox:
                    driver = new FirefoxDriver();
                    break;
                case BrowserType.Chrome:
                    driver = new ChromeDriver();
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(browserType), browserType, null);
            }

            driver.Url = url;

            return creationFunction.Invoke(driver);
        }
    }
}
