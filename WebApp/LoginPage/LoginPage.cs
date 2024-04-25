using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using First_Framework.Core;

namespace Web_Framework.WebApp.LoginPage
{
    partial class LoginPage : CorePage
    {   
        public void Login(string url, string username, string password)
        {
            driver.Url = url;
            driver.FindElement(usernameId).SendKeys(username);
            driver.FindElement(passwordId).SendKeys(password);
            driver.FindElement(submitBtnId).Click();

            driver.Close();
        }
    }
}