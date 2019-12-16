using AutomationFramework.Base;
using NUnit.Framework;
using System.Configuration;
using TechTalk.SpecFlow;

namespace SpecflowProject.Steps
{
    [Binding]
    class SampleSteps
    {
        [When(@"I click the Right Now On Playstation chevron")]
        public void WhenIClickTheRightNowOnPlaystationChevron()
        {
            Assert.IsTrue(new Pages.PlaystationHomePage().ClickChevronButton());
        }

        [When(@"I click the Your PS Plus games for December image")]
        public void WhenIClickTheYourPSPlusGamesForDecemberImage()
        {
            Assert.IsTrue(new Pages.PlaystationHomePage().ClickPSPlusTile());
        }

        [When(@"I Verify that the page has loaded correctly")]
        public void WhenIVerifyThatThePageHasLoadedCorrectly()
        {
            Assert.IsTrue(new Pages.PSPlusPage().VerifyPSPlusPage());
        }
    }
}
