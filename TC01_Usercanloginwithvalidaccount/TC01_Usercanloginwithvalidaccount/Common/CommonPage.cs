using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasicSelenium.Common;
using OpenQA.Selenium.Firefox;
using BasicSelenium.PageObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace BasicSelenium.PageObjects
{
    public class CommonPage
    {
        [TestInitialize]
        public void TestInitializeMeThod()
        {
            OpenBrowser();
        }
        [TestCleanup]
        public void TestCleapUpMethod()
        {
            CloseBrowser();
        }

        #region Initialize
        public static void OpenBrowser()
        {
            Constant.WebDriver = new FirefoxDriver();
            Constant.WebDriver.Manage().Window.Maximize();
        }
        #endregion

        #region CleanUp
        public static void CloseBrowser()
        {
            Constant.WebDriver.Manage().Cookies.DeleteAllCookies();
            Constant.WebDriver.Quit();
        }
        #endregion

        public void VerifyMessage(string expected_message, string actual_message)
        {
            Assert.AreEqual(expected_message, actual_message);
        }



    }
}
