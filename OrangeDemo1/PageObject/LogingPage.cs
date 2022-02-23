using OpenQA.Selenium;
using OrangeDemo1.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeDemo1.PageObject
{
    class LogingPage
    {
        public LogingPage()
        {
            driver = Hooks1.driver;
        }
        IWebDriver driver;


        
        IWebElement UserName => driver.FindElement(By.Id("txtUsername"));

        IWebElement Password => driver.FindElement(By.Id("txtPassword"));

        IWebElement loging => driver.FindElement(By.Id("btnLogin"));

        IWebElement Marketplace => driver.FindElement(By.Id("MP_link"));

        public void NavigateToWebsite()
        {
            driver.Navigate().GoToUrl("https://opensource-demo.orangehrmlive.com/");
        }

        public void EnterUsername()
        {
           UserName.SendKeys("Admin");
        }





        public void EnterPassword()
        {
            Password.SendKeys("admin123");
        }


        public void ClickOnLogingButton()
        {
            loging.Click();
        }

        public bool IsMarketPlacDisplayed()
        {
            return Marketplace.Displayed;
           
        }




    }
}
