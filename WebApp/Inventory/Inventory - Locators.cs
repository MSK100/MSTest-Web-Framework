using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;

namespace Web_Framework.WebApp.LoginPage
{ 
    partial class Inventory
    {
        By usernameId = By.Id("user-name");
        By passwordId = By.Id("password");
        By submitBtnId = By.Id("login-button");
    }
}