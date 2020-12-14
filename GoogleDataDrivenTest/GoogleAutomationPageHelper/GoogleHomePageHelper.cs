using NUnit_Demo;
using OpenQA.Selenium;

namespace DotNetAutomation.GoogleDataDrivenTest.GoogleAutomationPageHelper
{
    public class GoogleHomePageHelper
    {
        protected IWebDriver driver;
        protected readonly Browser_ops browser;
        protected GooglePageObject.GoogleHomePageObject googlePageObject;

        public GoogleHomePageHelper()
        {
            browser = new Browser_ops();
        }

        /// <summary>
        /// Initializing browser
        /// </summary>
        [NUnit.Framework.OneTimeSetUp]
        public void start_Browser()
        {
            browser.Init_Browser();
            driver = browser.getDriver;
            googlePageObject = new GooglePageObject.GoogleHomePageObject(driver);
        }

        /// <summary>
        /// searching in home page search bar
        /// </summary>
        /// <param name="keyword"></param>
        /// <param name="pageObject"></param>
        public void Search(string keyword, GooglePageObject.GoogleHomePageObject pageObject)
        {
            var element = pageObject.searchBar;
            element.SendKeys(keyword);
            element.Submit();
        }

        [NUnit.Framework.OneTimeTearDown]
        public void closeBrowser()
        {
            browser.Close();
        }
    }
}
