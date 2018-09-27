using OpenQA.Selenium;
using SeleniumIntro.Framework;

namespace SeleniumIntro.PageObjects
{
    public class MainPage : BasePage
    {
        public ContactUs ClickContactUs()
        {
            Driver.FindElement(By.Id("menu-item-105")).Click();
            return new ContactUs(Driver);
            
        }

        public MainPage(IWebDriver driver) : base(driver)
        {
        }

        protected override string ValidUrl
        {
            get { return Settings.ValidMainPageUrl; }
        }
    }
}
