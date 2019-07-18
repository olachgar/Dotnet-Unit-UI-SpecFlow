using System;
using TechTalk.SpecFlow;

namespace Dotnet_Unit_UI_SpecFlow.xUnit.Tests.StepDefinitions
{
    [Binding]
    public class CalculatorSteps
    {
        [Given(@"I have entered (.*) into the calculator(.*)")]
        public void GivenIHaveEnteredIntoTheCalculator(int p0, int p1)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the result should be (.*) on the screen(.*)")]
        public void ThenTheResultShouldBeOnTheScreen(int p0, int p1)
        {
            ScenarioContext.Current.Pending();
        }
    }
}
