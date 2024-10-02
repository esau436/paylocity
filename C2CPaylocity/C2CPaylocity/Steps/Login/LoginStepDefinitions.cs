using C2CPaylocity.Page.Login;
using System;
using TechTalk.SpecFlow;

namespace C2CPaylocity.Steps.Login
{
    [Binding]
    public class LoginStepDefinitions
    {
        private LoginPage login = new LoginPage();

        [Given(@"I Login as a User")]
        public void GivenILoginAsAUser()
        {
            login.LoginToDashboard("TestUser445", "pS_XjKcAR{^O");
        }
    }
}
