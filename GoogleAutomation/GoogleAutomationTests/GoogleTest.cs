using NUnit.Framework;
//using excel = Microsoft.Office.Interop.Excel;
using DotNetAutomation.GoogleAutomation.GoogleAutomationPageHelper;
using DotNetAutomation.GoogleAutomation.TestDataAccess;

namespace DotNetAutomation.GoogleAutomation.GoogleAutomationTests
{
    /// <summary>
    /// class for testing Google Home Page
    /// </summary>
    [TestFixture]
    public class GoogleTest : GoogleBrowserAutomationPageHelper
    {
        /// <summary>
        /// creating instance for Google Home Page
        /// </summary>
        GoogleHomePage googleHomePage = new GoogleHomePage();

        /// <summary>
        /// test for searching google home page
        /// </summary>
        [Test]
        public void GoogleSearch()
        {
            TestDataAccess.DataAccess dataAccess = new TestDataAccess.DataAccess();
            var testData = dataAccess.GetTestData();

            testData.ForEach(testCase =>
            {
                browser.Goto("https://www.google.com/");
                googleHomePage.Search(testCase.Keyword, googlePageObject);
                Assert.AreEqual(testCase.ExpectedResult, driver.Title);
            });
        }

        /// <summary>
        /// test for searching google home page
        /// </summary>
        [TestCaseSource("GetTestData")]
        public void GoogleSearch1()
        {
            TestDataAccess.DataAccess dataAccess = new TestDataAccess.DataAccess();
            var testData = dataAccess.GetTestData();

            testData.ForEach(testCase =>
            {
                browser.Goto("https://www.google.com/");
                googleHomePage.Search(testCase.Keyword, googlePageObject);
                Assert.AreEqual(testCase.Keyword, driver.Title);
            });
        }
    }
}
