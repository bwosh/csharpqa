using OpenQA.Selenium;
using SeleniumFinal.Core;

namespace SeleniumFinal.Pages
{
    public sealed class DashboardPage : BasePage
    {
        private IWebElement Title {get { return FindByXPath("//*[@id=\"topbarAvatar\"]/a"); }}

        public DashboardPage(IWebDriver webDriver) : base(webDriver)
        {
        }

        public override bool IsProperPageDisplayed()
        {
            Log("Checking if dashboard page is properly displayed...");
            return Title.Text.Contains(Consts.UserLogin);
        }
    }
}
