using OpenQA.Selenium;
using SeleniumFinal.Core;

namespace SeleniumFinal.Pages
{
    public sealed class MainPage : BasePage
    {
        private IWebElement LoginField { get { return FindByName("Login"); } }
        private IWebElement PasswordField { get { return FindByName("Password"); } }
        private IWebElement LoginButton { get { return FindByName("topBar_LoginBtn"); } }
        private IWebElement TitleImg { get { return FindByXPath("//*[@id=\"mainPage\"]/div[1]/div/h1/img"); } }

        public MainPage(IWebDriver webDriver)
            : base(webDriver)
        {
            Log("Entering main page...");
        }

        public override bool IsProperPageDisplayed()
        {
            Log("Checking if main page is properly displayed...");
            return TitleImg.GetAttribute("title").Contains("Chomikuj");
        }

        public MainPage SetLogin(string login)
        {
            Log("Setting login...");
            LoginField.SendKeys(login);
            WaitABit();
            return this;
        }

        public MainPage SetPassword(string password)
        {
            Log("Setting password...");
            PasswordField.SendKeys(password);
            WaitABit();
            return this;
        }

        public DashboardPage LoginAndGoToDashboard()
        {
            Log("Clicking login button and redirecting to dashboard page...");
            LoginButton.Click();
            WaitABit();
            return new DashboardPage(WebDriver);
        }
    }
}
