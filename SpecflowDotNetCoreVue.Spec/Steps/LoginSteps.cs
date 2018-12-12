using System;
using TechTalk.SpecFlow;

namespace SpecflowDotNetCoreVue.Spec.Steps
{
    [Binding]
    public class LoginSteps
    {
        [Given(@"a sales Id of (.*)")]
        public void GivenASalesIdOf(int p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"a password '(.*)'")]
        public void GivenAPassword(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [Given(@"a password ""(.*)""")]
        public void GivenAPassword(string p0)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I login")]
        public void WhenILogin()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"the system should retun a User Ojbect")]
        public void ThenTheSystemShouldRetunAUserOjbect()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I should be shown a friendly erorr message")]
        public void ThenIShouldBeShownAFriendlyErorrMessage()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
