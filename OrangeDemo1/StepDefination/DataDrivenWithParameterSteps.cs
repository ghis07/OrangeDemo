using OrangeDemo1.PageObject;
using System;
using TechTalk.SpecFlow;

namespace OrangeDemo1.StepDefination
{
    [Binding]
    public class DataDrivenWithParameterSteps
    {


        DataDrivenWithParameterPage dataDrivenWithParameterPage;

        public  DataDrivenWithParameterSteps()
        {
            dataDrivenWithParameterPage = new DataDrivenWithParameterPage();
        }

        [Given(@"I navigate to ""(.*)""")]
        public void GivenINavigateTo(string url)
        {
            dataDrivenWithParameterPage.NavigateToWebsite(url);
        }
        
        [Given(@"I enter the Username ""(.*)""")]
        public void GivenIEnterTheUsername(string Username)
        {

            dataDrivenWithParameterPage.EnterUsername(Username);
        }
        
        [Given(@"I enter the  password ""(.*)""")]
        public void GivenIEnterThePassword(string Password)
        {
            dataDrivenWithParameterPage.EnterPassword(Password);
        }
    }
}
