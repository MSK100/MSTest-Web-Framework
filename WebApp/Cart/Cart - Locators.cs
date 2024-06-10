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
    public partial class Cart
    {
        By AddtoCartXp = By.XPath("//*[@class=\'btn_primary btn_inventory\']");
        By RemoveXp = By.XPath("//*[@class=\'btn_secondary btn_inventory\']");
        By CartXp = By.XPath("//a[@class=\'shopping_cart_link fa-layers fa-fw\']");
        By CheckoutXp = By.XPath("//a[@class=\'btn_action checkout_button\']");
        By Chk_FirstNameId = By.Id("first-name");
        By Chk_LastNameId = By.Id("last-name");
        By Chk_ZipCodeId = By.Id("postal-code");
        By ContinueXp = By.XPath("//input[@class=\'btn_primary cart_button\']");
        By FinishXp = By.XPath("//a[@class=\'btn_action cart_button\']");
    }
}