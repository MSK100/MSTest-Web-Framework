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
        By productOneId = By.Id("item_4_title_link");
        By productTwoId = By.Id("item_0_title_link");
        By productBackBtnCs = By.ClassName("inventory_details_back_button");
    }
}