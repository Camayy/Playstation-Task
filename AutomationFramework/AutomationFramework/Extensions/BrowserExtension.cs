using AutomationFramework.Base;
using AutomationFramework.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFramework.Extensions
{
    public static class BrowserExtension
    {
        public static Screenshot Object()
        {
            try
            {
                ITakesScreenshot screenshotDriver = Drivers.WebDriver as ITakesScreenshot;
                return screenshotDriver.GetScreenshot();
            }
            catch
            {
                Logging.Write("Screenshot creation failed.");
                return null;
            }
        }

        public static string GetPageTitle()
        {
            try
            {
                if (Drivers.WebDriver.Title != "" || Drivers.WebDriver!= null)
                {
                    Logging.Write("Found page title: " + Drivers.WebDriver.Title);
                    return Drivers.WebDriver.Title;
                }
                else return null;
                
            }
            catch (Exception e)
            {
                Logging.Write("ERR: Could not find page header: "+e);
                return null;
            }
        }

        public static bool VerifyPage(string expectedTitle)
        {
            try
            {
                Assert.AreEqual(expectedTitle, GetPageTitle());
                Logging.Write("Page verified with title");
                return true;

            }
            catch (Exception e)
            {
                Logging.Write("ERR: Page title doesnt match: "+e);
                return false;
            }
        }

    }
}
