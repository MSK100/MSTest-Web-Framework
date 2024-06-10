using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System.Configuration;
using OpenQA.Selenium.Firefox;

namespace First_Framework.Core
{
    public class CorePage
    {
        #region Properties

        public static IWebDriver driver;
        public static int MaxTimeToFindElement = Convert.ToInt32(ConfigurationManager.AppSettings["MaxTimeToFindElement"]);
        public static string Browser = ConfigurationManager.AppSettings["Browser"].ToString();
        public static bool HeadlessExecution = Convert.ToBoolean(ConfigurationManager.AppSettings["HeadlessExecution"]);

        #endregion

        #region CoreMethods

        public void Write(By by, string value, int TimeToReadyElement = 0) { }
        public void Click(By by, int TimeToReadyElement = 0) { }
        public void OpenURL(string url) { }
       /* public string GetElementText(By by) { }
        public bool GetElementState() { }*/
        #endregion

    }
}
