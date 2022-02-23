using OrangeDemo1.PageObject;
using System;
using TechTalk.SpecFlow;

namespace OrangeDemo1.StepDefination
{
    [Binding]
    public class DataDrivenWithExempleSteps
    {
        DataDrivenWithExemplePage dataDrivenWithExemplePage;

        public DataDrivenWithExempleSteps()
        {
            dataDrivenWithExemplePage = new DataDrivenWithExemplePage();
        }





        [Given(@"the user enter the Username ""(.*)""")]
        public void GivenTheUserEnterTheUsername(string Surname)
        {
           dataDrivenWithExemplePage.EnterUsername(Surname);
        }
        
        [Given(@"the user enter the  password ""(.*)""")]
        public void GivenTheUserEnterThePassword(string Password)
        {
            dataDrivenWithExemplePage.EnterPassword(Password);
        }
    }
}
