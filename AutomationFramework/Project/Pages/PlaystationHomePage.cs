using AutomationFramework.Base;
using AutomationFramework.Extensions;
using AutomationFramework.Helpers;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecflowProject.Pages
{
    public class PlaystationHomePage : BaseInit
    {
        public PlaystationHomePage()
        {
            WebDriverExtension.WaitForPageLoad();
        }

        [FindsBy(How = How.CssSelector, Using = "#CC027_heroActionPanel > div.heroActionPanelContent > div.cell.left > a")]
        private IWebElement rightNowChevronButton { get; set; }

        [FindsBy(How = How.CssSelector, Using = "#home-content-par-section-5acb-page-section-par-productgridcontainer > div > div > div.producttile_14805072.productTile > div")]
        private IWebElement findOutMorePSPlusTile { get; set; }

        [FindsBy(How =  How.XPath, Using = "//*[@id=\"home - content - par - section - 5acb - page - section - par - productgridcontainer\"]/div/div/div[1]/div/div[1]/a/img")]
        private IWebElement  playstationLogo { get; set; }

        public bool VerifyPlaystationHomePage()
        {
            try
            {
                WebElementExtension.Exists(playstationLogo);
                //pass this through feature file
                return BrowserExtension.VerifyPage("Official Playstation website | Playstation");
                
            }
            catch (Exception e)
            {
                Logging.Write("ERR: Page title doesnt match: "+e);
                return false;
            }
        }

        public bool ClickChevronButton()
        {
            try
            {
                if (WebElementExtension.Exists(rightNowChevronButton))
                {
                    WebElementExtension.Click(rightNowChevronButton);
                    Logging.Write("Clicked chevron button");
                    return true;
                }
                else
                {
                    Logging.Write("ERR: Chevron image was not found");
                    return false;
                }
            }
            catch(Exception e)
            {
                Logging.Write("ERR: Could not click chevron: " + e);
                return false;
            }
        }

        public bool ClickPSPlusTile()
        {
            try
            {
                if (WebElementExtension.Exists(findOutMorePSPlusTile))
                WebElementExtension.Click(findOutMorePSPlusTile);
                Logging.Write("Clicked PS Plus tile");
                return true;
            }
            catch(Exception e)
            {
                Logging.Write("ERR: Could not click PSPlus tile: "+e);
                return false;
            }
        }
    }
}
