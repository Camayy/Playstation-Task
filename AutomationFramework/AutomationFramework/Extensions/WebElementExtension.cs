using OpenQA.Selenium;
using System;
using AutomationFramework.Helpers;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFramework.Extensions
{
    public static class WebElementExtension
    {
        public static bool Exists(this IWebElement element)
        {
            if (element.Displayed)
            {
                Logging.Write("Element: " + element.TagName+" was found");
                return true;
            }
            else
            {
                Logging.Write("Element " + element.ToString() + " was not found on the page");
                throw new Exception(string.Format("Element was not displayed on page"));
            }
        }

        public static bool Click(this IWebElement element)
        {
            try
            {
                element.Click();
                Logging.Write("Element Clicked");
                return true;
            }
            catch (Exception e)
            {
                //Logging.Write("ERR: Element" +element.ToString()+" could not be clicked "+e);
                return false;
            }
        }

        public static bool SetText(this IWebElement element, string text)
        {
            try
            {
                element.SendKeys(text);
                Logging.Write("Set text into text box");
                return true;
            }
            catch (Exception e)
            {
                Logging.Write("ERR: Element" + element.ToString() + " could not have text set " + e);
                return false;
            }
        }
    }
}
