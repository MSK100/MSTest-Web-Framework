﻿using System;
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
    public partial class Inventory
    {
        [TestMethod]
        [TestCategory("Product"), TestCategory("Positive"), TestCategory("UAT")]
        public void OpenProduct()
        {
            driver.FindElement(productOneId).Click();
            driver.FindElement(productBackBtnCs).Click();
        }
    }
}