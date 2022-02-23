using NUnit.Framework;
using OrangeDemo1.PageObject;
using System;
using TechTalk.SpecFlow;

namespace OrangeDemo1.StepDefination
{
    [Binding]
    public class LoginSteps
    {

        LogingPage logingPage;

        public LoginSteps()
        {
            logingPage = new LogingPage();
        }
        




        


        [Given(@"I navigate to the website")]
        public void GivenINavigateToTheWebsite()
        {
            logingPage.NavigateToWebsite();
        }
        
        [Given(@"I enter the Username")]
        public void GivenIEnterTheUsername()
        {
            logingPage.EnterUsername();
        }
        
        [Given(@"I enter the  password")]
        public void GivenIEnterThePassword()
        {
            logingPage.EnterPassword();

        }
        
        [When(@"I click on loging")]
        public void WhenIClickOnLoging()
        {
            logingPage.ClickOnLogingButton();
        }
        
        [Then(@"I should be able to loging succefully")]
        public void ThenIShouldBeAbleToLogingSuccefully()
        {
            Assert.That(logingPage.IsMarketPlacDisplayed);
        }
    }
}
