using System.ComponentModel;

namespace ConsoleApplication4
{

    class MyTests
    {
        void SetStartPage(IMyPage myPage)
        {
            webDriver.Navigate(myPage.GetPageUrl());
        }

        public void Test()
        {
            // Arrange
            var page1 = new Page1();

            // Act
            SetStartPage(page1);
            //var result = page1.ClickButton2().Back();


            page1.ClickButton2();

            /* Page1.ClickAddTodoListItem()
                .EnterItemName("sdsd").
                .ClickSaveButton();*/

            // Assert
            /*page1.VisibleItems.Contains("sdsd");


            Assert.NotNull(result);*/
        }
    }

    interface IMyPage
    {
        string GetPageUrl();
    }

    class PageWithTitleAndheader 
    {
        public string GetHeaderText()
        {
            var element = webDriver.FindElement(By.ClassName("headertext"));
            return element.Text;
        }

        public string GetPageTitle()
        {
            
        }
    }

    class Page1 : PageWithTitleAndheader, IMyPage
    {
        public Page2 ClickButton2()
        {
            var element = webDriver.FindElement(By.Id("sssss2"));
            element.Click();
        }

        public void ClickButton3()
        {
            
        }

        public void ClickButton4()
        {
            
        }

        public string GetPageUrl()
        {
            return "http:\\a.com";
        }
    }

    class Page2 : PageWithTitleAndheader, IMyPage
    {
        public Page1 Back()
        {
            
        }

        public string GetPageUrl()
        {
            throw new System.NotImplementedException();
        }
    }

    class Page3 : PageWithTitleAndheader, IMyPage
    {
        void Back()
        {

        }

        public string GetPageUrl()
        {
            throw new System.NotImplementedException();
        }
    }

    class Page4 : PageWithTitleAndheader, IMyPage
    {
        void Back()
        {

        }

        public string GetPageUrl()
        {
            throw new System.NotImplementedException();
        }
    }

    class ContactUs : PageWithTitleAndheader, IMyPage
    {
        public string GetPageUrl()
        {
            throw new System.NotImplementedException();
        }
    }
}
