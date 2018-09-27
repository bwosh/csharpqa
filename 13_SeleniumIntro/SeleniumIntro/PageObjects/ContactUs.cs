using OpenQA.Selenium;
using SeleniumIntro.Framework;

namespace SeleniumIntro.PageObjects
{
    public class ContactUs : BasePage
    {
        public ContactUs(IWebDriver driver) : base(driver)
        {
        }

        protected override string ValidUrl
        {
            get { return Settings.ValidContactUsPageUrl; }
        }
    }
}
