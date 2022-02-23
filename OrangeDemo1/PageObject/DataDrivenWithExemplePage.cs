using OpenQA.Selenium;
using OrangeDemo1.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrangeDemo1.PageObject
{
    class DataDrivenWithExemplePage
    {

        public DataDrivenWithExemplePage()
        {
            driver = Hooks1.driver;
        }
        IWebDriver driver;

        IWebElement UserName => driver.FindElement(By.Id("txtUsername"));

        IWebElement password => driver.FindElement(By.Id("txtPassword"));







        public void EnterUsername(string Username)
        {
            UserName.SendKeys(Username);
        }


        public void EnterPassword(string Password)
        {
            password.SendKeys(Password);
        }














    }
}
