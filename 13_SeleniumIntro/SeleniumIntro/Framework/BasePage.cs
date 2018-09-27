using System;
using System.Xml.Schema;
using OpenQA.Selenium;

namespace SeleniumIntro.Framework
{
    public abstract class BasePage
    {
        private readonly IWebDriver _driver;

        protected IWebDriver Driver
        {
            get { return _driver; }
        }

        protected BasePage(IWebDriver driver)
        {
            _driver = driver;
            Validate();
        }

        public string GetTitle()
        {
            return _driver.Title;
        }

        public string GetUrl()
        {
            return _driver.Url;
        }

        protected abstract string ValidUrl { get; }

        protected void Validate() 
        {
            if (GetUrl() != ValidUrl)
            {
                throw new Exception("Validation failed");
            }
        }
    }
}
