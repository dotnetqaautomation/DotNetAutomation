using DotNetAutomation.GoogleDataDrivenTest.GoogleAutomationPageHelper;
using NUnit.Framework;
using System.Collections.Generic;

namespace DotNetAutomation
{
    public class DataDrivenTest : GoogleHomePageHelper
    {
        /// <summary>
        /// creating instance for Google Home Page
        /// </summary>
        public GoogleHomePage googleHomePage;

        public static List<TestCaseData> TestCases = GoogleDataDrivenTest.TestDataAccess.DataAccess.TestCases;

        /// <summary>
        /// 
        /// </summary>
        /// <param name="keyword"></param>
        /// <returns></returns>
        [TestCaseSource("TestCases")]
        public void Test_GoogleSearch(string keyword, string expectedTitle)
        {
            // arrange
            googleHomePage = new GoogleHomePage();
            browser.Goto("https://www.google.com/");

            // act
            googleHomePage.Search(keyword, googlePageObject);

            // assert
            Assert.AreEqual(expectedTitle, driver.Title);
        }
    }
}
