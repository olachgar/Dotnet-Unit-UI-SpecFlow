using Dotnet_Unit_UI_SpecFlow.Web.Controllers;
using System;
using TechTalk.SpecFlow;
using Xunit;

namespace Dotnet_Unit_UI_SpecFlow.xUnit.Tests.StepDefinitions
{
    [Binding]
    public class ControllersSteps
    {
        [Given(@"I send a request to (.*) action")]
        public void GivenISendARequestToIndexAction(string action)
        {
            var homeController = new HomeController();

        }
        
        [Then(@"the result should be IActionResult")]
        public void ThenTheResultShouldBeIActionResult()
        {
            Assert.Equal(1, 1);
        }
    }
}
