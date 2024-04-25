using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using Docker.DotNet.Models;
using System.Configuration;

namespace First_Framework.Core
{
    public class Initialization : CorePage
    {
        #region Selenium_Initialization

        const string chrome = Keywords.ChromeBrowser;
        public static IWebDriver Selenium_Init(string browser = "Chrome")
        {
            if (browser == "Chrome")
            {
                IWebDriver driver = new ChromeDriver();
                CorePage.driver = driver;
                return driver;
            }
            return driver;
        }
        #endregion


    }
}