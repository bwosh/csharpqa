using OpenQA.Selenium;

namespace SeleniumFinal.Core
{
    public abstract class BasePage : Base
    {
        private readonly IWebDriver _webDriver;

        protected BasePage(IWebDriver webDriver)
        {
            _webDriver = webDriver;
        }

        protected IWebDriver WebDriver
        {
            get { return _webDriver; }
        }

        protected IWebElement FindByName(string name)
        {
            Log("Searching for element by name =" + name);
            return WebDriver.FindElement(By.Name(name));
        }

        protected IWebElement FindByXPath(string xPath)
        {
            return WebDriver.FindElement(By.XPath(xPath));
        }

        public abstract bool IsProperPageDisplayed();
    }
}
