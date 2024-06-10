using System;
using First_Framework.Core;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using Web_Framework.WebApp.LoginPage;
using System.Data;

namespace Web_Framework
{
    [TestClass]
    public class Execution
    {
        #region Setups and Cleanups

        public TestContext instance;
        public TestContext TestContext
        {
            set { instance = value; }
            get { return instance; }
        }

        [ClassInitialize()]
        public static void ClassInit(TestContext context)
        {

        }

        [ClassCleanup()]
        public static void ClassCleanup()
        {

        }

        [TestInitialize()]
        public void TestInit()
        {
            Initialization.Selenium_Init();
        }

        [TestCleanup()]
        public void TestCleanup()
        {
            //CorePage.driver.Close();
        }

        #endregion

        LoginPage loginPage = new LoginPage();
        Inventory inventory = new Inventory();
        Cart cart = new Cart();

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Login.xml", "Login", DataAccessMethod.Sequential)]
        public void Login()
        {

            string url = TestContext.DataRow["url"].ToString();
            string username = TestContext.DataRow["username"].ToString();
            string password = TestContext.DataRow["password"].ToString();

            loginPage.LoginPositive(url, username, password);
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Login.xml", "Login", DataAccessMethod.Sequential)]
        public void ProductClick()
        {
            Login();
            inventory.OpenProduct();
        }

        [TestMethod]
        [DataSource("Microsoft.VisualStudio.TestTools.DataSource.XML", "Login.xml", "Login", DataAccessMethod.Sequential)]
        public void CheckoutFlow()
        {
            Login();
            cart.Checkout();
        }
    }
}
