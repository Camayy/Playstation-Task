using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomationFramework.Base
{
    public abstract class Base
    {
        public Base(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
        }
    }
}
