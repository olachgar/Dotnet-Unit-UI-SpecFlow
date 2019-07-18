using Xunit;
using TechTalk.SpecFlow;

namespace Dotnet_Unit_UI_SpecFlow.UI.Tests.StepDefinition
{
    [Binding]
    public class LoginSteps
    {
        [Given(@"I have entered my login into the login page")]
        public void GivenIHaveEnteredMyLoginIntoTheLoginPage()
        {
            Assert.Equal(0, 0);
        }
        
        [Given(@"I have entered my passeword into the login page")]
        public void GivenIHaveEnteredMyPassewordIntoTheLoginPage()
        {
            Assert.Equal(0, 0);
        }
        
        [When(@"I press validate")]
        public void WhenIPressValidate()
        {
            Assert.Equal(0, 0);
        }
        
        [Then(@"the profil page should load")]
        public void ThenTheProfilPageShouldLoad()
        {
            Assert.Equal(0, 0);
        }
    }
}
