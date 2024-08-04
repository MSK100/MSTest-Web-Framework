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
        By AddtoCartXp1 = By.XPath("(//div[@class=\"pricebar\"]//button)[1]");
        By AddtoCartXp2 = By.XPath("(//div[@class=\"pricebar\"]//button)[2]");
        By AddtoCartXp3 = By.XPath("(//div[@class=\"pricebar\"]//button)[3]");
        By AddtoCartXp4 = By.XPath("(//div[@class=\"pricebar\"]//button)[4]");
        By AddtoCartXp5 = By.XPath("(//div[@class=\"pricebar\"]//button)[5]");
        By AddtoCartProductDetail = By.XPath("//button[@class=\'btn_primary btn_inventory\']");
        By RemoveXp = By.XPath("//*[@class=\'btn_secondary btn_inventory\']");
        By CartXp = By.XPath("//a[@class=\'shopping_cart_link fa-layers fa-fw\']");
        By CheckoutXp = By.XPath("//a[@class=\'btn_action checkout_button\']");
        By Chk_FirstNameId = By.Id("first-name");
        By Chk_LastNameId = By.Id("last-name");
        By Chk_ZipCodeId = By.Id("postal-code");
        By ContinueXp = By.XPath("//input[@class=\'btn_primary cart_button\']");
        By FinishXp = By.XPath("//a[@class=\'btn_action cart_button\']");
        By productOneId = By.Id("item_4_title_link");
    }
}