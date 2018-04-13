using System;
using System.Linq;
using System.Threading;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace SeleniumTestsUnitTests
{
    [TestClass]
    public class UnitTest1
    {
        private const string MySiteAddress = "http://selenium-test.azurewebsites.net/";
        private IWebDriver _webDriver;
        private WebDriverWait _waiter;

        [TestInitialize]
        public void Setup()
        {
            _webDriver = new ChromeDriver();
            _waiter = new WebDriverWait(_webDriver, TimeSpan.FromSeconds(1));
            _webDriver.Navigate().GoToUrl(MySiteAddress);
            Wait(5);
        }

        [TestCleanup]
        public void CleanUp()
        {
            Wait(5);
            _webDriver.Dispose();
            _webDriver = null;
        }

        private void Wait(int seconds)
        {
#if DEBUG
            Thread.Sleep(seconds * 1000);
#endif
        }

        [TestMethod]
        public void EnterSite()
        {
            // Arrange
            var selector = By.ClassName("header");
            var expectedText = "SeleniumTests";

            // Act
            var elements = _webDriver.FindElements(selector);

            // Assert
            Assert.IsTrue(elements.Any(e => e.Text == expectedText), "Element with text could not be found.");
        }

        [TestMethod]
        public void TestStaticAdd()
        {
            // Arrange
            string expectedValue = "5";
            By buttonSelector = By.XPath("//*[@id=\"form1\"]/div[3]/div[1]/div[3]");
            By resultSelector = By.Id("c1");

            // Act
            var button = _webDriver.FindElement(buttonSelector);
            button.Click();
            Wait(1);

            var resultBox = _webDriver.FindElement(resultSelector);
            var resultText = resultBox.Text;

            // Assert
            Assert.AreEqual(expectedValue, resultText);
        }

        [TestMethod]
        public void TestTimeoutedAdd()
        {
            var x = "dsfsdfsdf".IndexOf("S", StringComparison.InvariantCultureIgnoreCase);

            // Arrange
            string expectedValue = "32";
            By buttonSelector = By.XPath("//*[@id=\"form1\"]/div[3]/div[2]/div[3]");
            By resultSelector = By.Id("c2");

            // Act
            var button = _webDriver.FindElement(buttonSelector);
            button.Click();
            //Wait(1);

            By by = By.ClassName("title");
            if (_waiter.Until(drv => drv.FindElement(resultSelector).Text != ""))
            {
   
                //_waiter.Until(i => i.FindElement(By.CssSelector("ff")));

                var resultBox = _webDriver.FindElement(resultSelector);
                var resultText = resultBox.Text;

                // Assert
                Assert.AreEqual(expectedValue, resultText);
            }
            else
            {
                // TODO Assert.Fail("Could not find element.");
            }
        }
    }
}
