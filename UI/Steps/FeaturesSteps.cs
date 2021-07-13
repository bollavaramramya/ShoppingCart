using System;
using TechTalk.SpecFlow;
using UI.Objects;


namespace UI.Steps
{
    [Binding]
    public class FeaturesSteps
    {
        LoginPageObj loginPage = new LoginPageObj();
 
        private readonly ScenarioContext context;
        public FeaturesSteps(ScenarioContext injectedCotext)
        {
            context = injectedCotext;
        }

        //[Given(@"I enter the following details as")]
        [Given(@"I enter the following details as (.*) & (.*)")]
        public void GivenIEnterTheFollowingDetailsAs(string username, string password)
        {
            loginPage.login(username, password);
        }


        [When(@"I click on submit")]
        public void WhenIClickOnSubmit()
        {
            loginPage.Submit();
        }

        [Then(@"I verify that the homepage is displayed")]
        public void ThenIVerifyThatTheHomepageIsDisplayed()
        {
            loginPage.IsWelcomeTextExist();
        }
    }
}
