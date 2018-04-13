using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using SeleniumFinal.Pages;

namespace SeleniumFinal.Core
{
    public abstract class TestBase : Base
    {
        private IWebDriver _driver;

        [TestInitialize]
        public void Setup()
        {
            _driver = new ChromeDriver();
        }

        [TestCleanup]
        public void CleanUp()
        {
            WaitABit();
            _driver.Dispose();
            _driver = null;
        }

        protected MainPage GoToStartPage()
        {
            _driver.Url = Consts.StartPageUrl;
            WaitABit();
            return new MainPage(_driver);
        }
    }
}
