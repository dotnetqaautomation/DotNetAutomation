using DotNetAutomation.GoogleDataDrivenTest.GoogleAutomationPageHelper;
using NUnit.Framework;
using System.Collections.Generic;

namespace DotNetAutomation
{
    public class DataDrivenTest : GoogleHomePageHelper
    {
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
            browser.Goto("https://www.google.com/");

            // act
            Search(keyword, googlePageObject);

            // assert
            Assert.AreEqual(expectedTitle, driver.Title);
        }
    }
}
