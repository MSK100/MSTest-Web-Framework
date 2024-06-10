using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using Docker.DotNet.Models;
using System.Configuration;
using OpenQA.Selenium.Firefox;
using Xamarin.Essentials;

namespace First_Framework.Core
{
    public class Initialization : CorePage
    {
        #region Selenium_Initialization

        public static string browser = "chrome";

        public static void Selenium_Init()
        {
            if (browser == "chrome")
            {
                    var chromeOptions = new ChromeOptions();
                    chromeOptions.AddArgument("--start-maximized");
                    driver = new ChromeDriver(chromeOptions);
            }
            else if (browser == "firefox")
            {
                    FirefoxOptions firefoxOptions = new FirefoxOptions();
                    firefoxOptions.AddArgument("");
                    driver = new FirefoxDriver(firefoxOptions);
            }
        }
        #endregion


    }
}