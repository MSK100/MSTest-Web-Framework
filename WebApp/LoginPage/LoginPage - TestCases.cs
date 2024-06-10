using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Security.Policy;

namespace Web_Framework.WebApp.LoginPage
{
    public partial class LoginPage
    {
        public void LoginPositive(string url, string username, string password)
        {
            driver.Url = url;
            driver.FindElement(usernameId).SendKeys(username);
            driver.FindElement(passwordId).SendKeys(password);
            driver.FindElement(submitBtnId).Click();
        }
        public void LoginNegative()
        {

        }
    }
}