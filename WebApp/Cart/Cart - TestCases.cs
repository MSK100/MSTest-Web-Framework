using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Runtime.Versioning;

namespace Web_Framework.WebApp.LoginPage
{
    [TestClass]
    public partial class Cart
    {
        /*[TestMethod]
        [TestCategory("Checkout"), TestCategory("Positive"), TestCategory("UAT")]*/
        public void Checkout(string fname, string lname, string zip)
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

       /* [TestMethod]
        [TestCategory("Checkout"), TestCategory("Positive"), TestCategory("UAT")]*/ 
        public void CheckoutFromProductDetail(string fname, string lname, string zip)
        {
            driver.FindElement(productOneId).Click();
            driver.FindElement(AddtoCartProductDetail).Click();
            driver.FindElement(CartXp).Click();
            driver.FindElement(CheckoutXp).Click();
            driver.FindElement(Chk_FirstNameId).SendKeys(fname);
            driver.FindElement(Chk_LastNameId).SendKeys(lname);
            driver.FindElement(Chk_ZipCodeId).SendKeys(zip);
            driver.FindElement(ContinueXp).Click();
            driver.FindElement(FinishXp).Click();
        }
    }
}