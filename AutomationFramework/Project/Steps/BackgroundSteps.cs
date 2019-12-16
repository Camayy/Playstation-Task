using AutomationFramework.Base;
using AutomationFramework.Helpers;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TechTalk.SpecFlow;

namespace Project.Steps
{
    [Binding]
    public sealed class BackgroundSteps
    {
        DateTime TestStartTime;

        [Given(@"I start ""(.*)"" test")]
        public void GivenIStartTest(string testDetails)
        {
            Browser.SelectBrowserType(Browser.BrowserType.Chrome);
            Drivers.WebDriver.Manage().Window.Maximize();

            // Logging.CreateLogFile();
            Logging.SetDirectory();

            Logging.Write("------------------------------------");
            Logging.Write("Starting Test...");
            TestStartTime = DateTime.Now;
            Logging.Write("Test Start Time: " + TestStartTime);
        }

        [Then(@"Complete the test")]
        public void ThenCompleteTheTest()
        {
            Logging.Write("Finishing Test...");
            DateTime TestFinishTime = DateTime.Now;
            Logging.Write("Test Finish Time: " + TestFinishTime);
            Logging.Write("Total Test time = "+(TestStartTime - TestFinishTime).TotalHours);
            Logging.Write("------------------------------------");

            Drivers.WebDriver.Quit();
        }

        [Given(@"I have navigated to the playstion website")]
        public void NavigateToWebsite()
        {
            Drivers.Browser.NavigateToUrl(ConfigurationManager.AppSettings["URL"].ToString());
            //Assert.IsTrue(true);
        }
    }

}
