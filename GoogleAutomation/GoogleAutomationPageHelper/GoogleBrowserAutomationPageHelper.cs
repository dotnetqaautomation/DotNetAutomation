using DotNetAutomation.GoogleAutomation.GooglePageObjects;
using NUnit_Demo;
using OpenQA.Selenium;

namespace DotNetAutomation.GoogleAutomation.GoogleAutomationPageHelper
{
    /// <summary>
    /// class for google page helper
    /// </summary>
    public class GoogleBrowserAutomationPageHelper
    {
        protected IWebDriver driver;
        protected readonly Browser_ops browser;
        protected GooglePageObject googlePageObject;

        /// <summary>
        /// instance for browser
        /// </summary>
        public GoogleBrowserAutomationPageHelper()
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
            googlePageObject = new GooglePageObject(driver);
        }
    }
}
