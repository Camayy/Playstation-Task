using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFramework.Base
{
    public abstract class BaseInit
    {
        public BaseInit()
        {
            PageFactory.InitElements(Drivers.WebDriver, this);
            Drivers.WebDriver.Manage().Timeouts().PageLoad = TimeSpan.FromSeconds(30);
            Drivers.WebDriver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);

        }
    }
}
