using System;
using TechTalk.SpecFlow;
using Xunit;

namespace SpecflowDotNetCoreVue.Spec.Steps
{
    [Binding]
    public class LoginSteps
    {
        [Given(@"my sales id (.*)")]
        public void GivenMySalesId(int salesId)
        {
            ScenarioContext.Current.Pending();
        }
        
        [When(@"I log in")]
        public void WhenILogIn()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"I should see a friendly error message")]
        public void ThenIShouldSeeAFriendlyErrorMessage()
        {
            ScenarioContext.Current.Pending();
        }
        
        [Then(@"a user object with my information should be returned")]
        public void ThenAUserObjectWithMyInformationShouldBeReturned()
        {
            ScenarioContext.Current.Pending();
        }
    }
}
