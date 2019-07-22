using Dotnet_Unit_UI_SpecFlow.UI.Tests.PageObjects;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;
using Xunit;

namespace Dotnet_Unit_UI_SpecFlow.UI.Tests.StepDefinition
{
    [Binding]
    public class IndexSteps
    {
        readonly ChromeDriver driver = new ChromeDriver(".");
        string pageTitle = string.Empty;

        [Given(@"I have entered (.*) into the calculator")]
        public void GivenIHaveEnteredIntoTheCalculator(int p0)
        {
            driver.Navigate().GoToUrl("http://localhost:51706/");

            driver.Manage().Window.Maximize();
        }
        
        [When(@"I press add")]
        public void WhenIPressAdd()
        {
            HomePage homePage = new HomePage(driver);

            pageTitle = homePage.pageTitle.Text;

            homePage.learnAboutLink.Click();
        }
        
        [Then(@"the page should be displayed on the screen with '(.*)' as currect page title.")]
        public void ThenTheResultShouldBeOnTheScreen(string currentPageTitle)
        {
            Assert.Equal(currentPageTitle, pageTitle);
        }
    }
}
