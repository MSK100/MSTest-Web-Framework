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
    [TestClass]
    public partial class Cart
    {
        [TestMethod]
        [TestCategory("Checkout"), TestCategory("Positive"), TestCategory("UAT")]
        public void Checkout()
        {
            driver.FindElement(AddtoCartXp).Click();
            driver.FindElement(CartXp).Click();
            driver.FindElement(CheckoutXp).Click();
            driver.FindElement(Chk_FirstNameId).SendKeys("Test");
            driver.FindElement(Chk_LastNameId).SendKeys("Test");
            driver.FindElement(Chk_ZipCodeId).SendKeys("1000");
            driver.FindElement(ContinueXp).Click();
            driver.FindElement(FinishXp).Click();
        }
    }
}