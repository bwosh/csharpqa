using NUnit.Framework;
using SeleniumIntro.Framework;

namespace SeleniumIntro
{
    [TestFixture]
    public class MainPageTests
    {
        [Test]
        public void Test2()
        {
            // Arrange
            var expectedUrl = "";

            // Act
            var url = Common.EnterMainPage()
                        .ClickContactUs()
                        .GetUrl();

            // Assert 
            Assert.AreEqual(expectedUrl, url);
        }

        //------------------------------------------------------

        /*
        private IWebDriver Driver { get; set; }

        [SetUp]
        private void StartUp()
        {
            Driver = new FirefoxDriver();
        }

        [TearDown]
        private void TearDown()
        {
            Driver.Dispose();
        }

        public List<IWebElement> FindElementByText(IWebElement we, string text)
        {
            List<IWebElement> results = new List<IWebElement>();
            var foundElemnts = we.FindElements(By.CssSelector("*")).SelectMany(x => FindElementByText(x, text));

            if (foundElemnts.Any())
            {
                results.AddRange(foundElemnts);
            }

            if (!string.IsNullOrWhiteSpace(we.Text) && we.Text.Contains(text))
            {
                results.Add(we);
            }

            return results;
        }

        [Test]
        public void Test()
        {
            // Arrange
            var contactUsSelector = By.Id("menu-item-105");
            var expectedUrl = ";

            // Act
            Driver.Url = HomePagUrl;
            var element = Driver.FindElement(contactUsSelector);
            element.Click();

            // Assert 
            Assert.AreEqual(expectedUrl, Driver.Url);
        }

        */


    }
}
