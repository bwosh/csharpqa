using Microsoft.VisualStudio.TestTools.UnitTesting;
using SeleniumFinal.Core;

namespace SeleniumFinal
{
    [TestClass]
    public class LoginTests : TestBase
    {
        [TestMethod]
        public void IsStartPageAccessible()
        {
            // Act
            var startPage = GoToStartPage();
            var properlyDisplayed = startPage.IsProperPageDisplayed();

            // Assert
            Assert.IsTrue(properlyDisplayed);
        }

        [TestMethod]
        public void ProperLogin()
        {
            // Act
            var dashboardPage = GoToStartPage()
                .SetLogin(Consts.UserLogin)
                .SetPassword(Consts.UserPassword)
                .LoginAndGoToDashboard();

            var properlyDisplayed = dashboardPage.IsProperPageDisplayed();

            // Assert
            Assert.IsTrue(properlyDisplayed);
        }
    }
}
