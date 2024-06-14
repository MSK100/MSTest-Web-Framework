using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.UI;

namespace Web_Framework.WebApp.LoginPage
{ 
    partial class Inventory
    {
        By productOneId = By.Id("item_4_title_link");
        By productTwoId = By.Id("item_0_title_link");
        By invAlpSortFilter = By.XPath("//select[@class=\'product_sort_container\']");
        By sortFilterOp1 = By.XPath("//option[@value='az']");
        By sortFilterOp2 = By.XPath("//option[@value='za']");
        By sortFilterOp3 = By.XPath("//option[@value='lohi']");
        By sortFilterOp4 = By.XPath("//option[@value='hilo']");
        By productBackBtnCs = By.ClassName("inventory_details_back_button");
        SelectElement filterSelect;
    }
}