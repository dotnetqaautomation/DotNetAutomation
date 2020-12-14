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
        public string Test_GoogleSearch(string keyword)
        {
            // arrange
            browser.Goto("https://www.google.com/");

            // act
            //IWebElement element = driver.FindElement(By.XPath("//body/div[@id='viewport']/div[@id='searchform']/form[@id='tsf']/div[2]/div[1]/div[1]/div[1]/div[2]/input[1]"));
            //element.SendKeys(keyword);
            //element.Submit();
            Search(keyword, googlePageObject);

            // assert
            //Assert.AreEqual(expectedTitle, driver.Title);
            return driver.Title;
        }
    }
}
