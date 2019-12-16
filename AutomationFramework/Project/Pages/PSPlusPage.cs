using AutomationFramework.Base;
using AutomationFramework.Extensions;
using AutomationFramework.Helpers;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecflowProject.Pages
{
    public class PSPlusPage : BaseInit
    {

        [FindsBy(How = How.CssSelector, Using = "#age-gate-overlay > div > div > div:nth-child(2) > div.text-contents > h3")]
        private IWebElement ageRestrictedText { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#age-gate-overlay > div > div > div:nth-child(2) > div.age-form > div.left > span:nth-child(1) > input")]
        private IWebElement dayTextBox { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#age-gate-overlay > div > div > div:nth-child(2) > div.age-form > div.left > span:nth-child(2) > input")]
        private IWebElement monthTextBox { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#age-gate-overlay > div > div > div:nth-child(2) > div.age-form > div.left > span:nth-child(3) > input")]
        private IWebElement yearTextBox { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#age-gate-overlay > div > div > div:nth-child(2) > div.age-form > div.right > a > div")]
        private IWebElement submitButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#cboxClose")]
        private IWebElement closePopoutVideoButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#cq-image-jsp-\\/content\\/pdc\\/gb\\/en_GB\\/explore\\/games\\/a\\/ap\\/apex-legends-ps4\\/jcr\\:content\\/hugeherobanner\\/logo > img")]
        private IWebElement apexLegendsImage { get; set; }

        public PSPlusPage()
        {
            WebDriverExtension.WaitForPageLoad();
        }

        public bool VerifyPSPlusPage()
        {
            try
            {
                if (WebElementExtension.Exists(ageRestrictedText) && WebElementExtension.Exists(dayTextBox))
                {
                    WebElementExtension.SetText(dayTextBox,"01");
                    WebElementExtension.SetText(monthTextBox, "05");
                    WebElementExtension.SetText(yearTextBox, "1990");

                    WebElementExtension.Click(submitButton);

                    WebElementExtension.Click(closePopoutVideoButton);
                }

                if (WebElementExtension.Exists(apexLegendsImage))
                {
                    //pass expected title through feature file
                    Logging.Write("Verified PSPlus Page");
                    return BrowserExtension.VerifyPage("Apex Legends | PS4 Games | PlayStation");
                }
                else
                {
                    Logging.Write("ERR: Not on the correct page");
                    return false;
                }
                
            }
            catch (Exception e)
            {
                Logging.Write("ERR: Page title doesnt match: "+e);
                return false;
            }
        }
    }
}
