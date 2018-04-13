using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace KaBoom
{
    [TestClass]
    public class UnitTest1
    {
        private IWebDriver driver;

        [TestInitialize]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Url = "http://smtsoftware.com/en/";
        }

        [TestCleanup]
        public void CleanUp()
        {
            driver.Dispose();
        }

        [TestMethod]
        public void SiteWorks()
        {
            // Act
            var menuItems = driver.FindElements(By.ClassName("menu-item"));
            var firstElement = menuItems.First();

            // Assert
            Assert.AreEqual("ABOUT US", firstElement.Text);
        }

        [TestMethod]
        public void IsCareersVisible()
        {
            // Act
            var menuItems = driver.FindElements(By.ClassName("menu-item"));
            var found = menuItems.Any(e => e.Text == "CAREERS");

            // Assert
            Assert.IsTrue(found, "Careers element was not found.");
        }

        [TestMethod]
        public void IsAboutUsVisible()
        {
            // Act
            var elements = driver.FindElements(By.XPath("/html/body/div[6]/div[2]/div/div/div/div/div/div/div[2]"));
            var first = elements.First();

            // Assert
            Assert.AreEqual("into technology", first.Text);
        }
    }
}
