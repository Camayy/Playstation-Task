using AutomationFramework.Base;
using OpenQA.Selenium;
using AutomationFramework.Helpers;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;

namespace AutomationFramework.Extensions
{
    public static class WebDriverExtension
    {

        // THIS CAN BE MADE BETTER (USE TIMESPAN.FROMSECONDS TO TIME OUT PAGE 
        public static void WaitForPageLoad()
        {
            WebDriverWait wait = new WebDriverWait(Drivers.WebDriver, new TimeSpan(0, 0, 15));
            wait.Until(driver => ((IJavaScriptExecutor)driver).ExecuteScript("return document.readyState").Equals("complete"));

            /*bool wait = Drivers.WebDriver.Execute<bool>("return document.readyState").Equals("complete");

            if (wait)
            {
                Logging.Write("Page loaded");
            }
            else
            {
                Logging.Write("Page did not load");
            }
            //bool wait = new WebDriverWait(driver, TimeSpan.FromSeconds(60)).Until(d => ((javascriptexecutor)d).executescript("return document.readyState").Equals("complete")); 
        }

        public static T Execute<T>(this IWebDriver driver, string script)
        {
            return (T)((IJavaScriptExecutor)driver).ExecuteScript(script);
        }*/
        }
    }
}
