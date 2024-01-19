using ClassLibraryTesting;
using System;
using TechTalk.SpecFlow;

namespace SpecFlowTeatingProject.StepDefinitions
{
    [Binding]
    public class LoginTestingStepDefinitions
    {
        private string username;
        private string password;
        private string loginresult;
        private readonly ScenarioContext scenarioContext;
        private readonly Class1 userLogin;

        public LoginTestingStepDefinitions(ScenarioContext sc)
        {
            this.scenarioContext = sc;
            userLogin = new Class1();
        }
        [Given(@"a user with valid user name ""([^""]*)"" and valid password ""([^""]*)""")]
        public void GivenAUserWithValidUserNameAndValidPassword(string nehash, string p1)
        {
            username = nehash;
            password = p1;
        }

        [When(@"the Login method is called")]
        public void WhenTheLoginMethodIsCalled()
        {
            loginresult = userLogin.Login(username, password);
        }

        [Then(@"the result should be Login Successful")]
        public void ThenTheResultShouldBeLoginSuccessful()
        {
            loginresult.Should().Be(loginresult);
        }

        [Given(@"a user with invalid user name ""([^""]*)"" and valid password ""([^""]*)""")]
        public void GivenAUserWithInvalidUserNameAndValidPassword(string p0, string invalid)
        {
            username = p0;
            password = invalid;
        }

        [Then(@"the result should be Login Failed")]
        public void ThenTheResultShouldBeLoginFailed()
        {
            loginresult.Should().Be(loginresult);
        }
    }
}
