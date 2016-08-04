using System;
using OpenQA.Selenium;
using BasicSelenium.Common;
using BasicSelenium.PageObjects;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Firefox;

namespace BasicSelenium.PageObjects
{
    public class GeneralPage:CommonPage
    {
        #region Locators

        private static readonly By _tabLogin = By.XPath("//span[.='Login']");
        private static readonly By _tabLogout = By.XPath("//span[.='Logout']");
        private static readonly By _lblWelcome = By.XPath("//div[@class='account']");
        private static readonly By _lblErrormessage = By.XPath("//p[@class='message error LoginForm']");
        private static readonly By _tabRegister = By.XPath("//a[@href='/Account/Register.cshtml']");
        private static readonly By _lblSucMessage = By.XPath("//div[@id='content']/h1");
        #endregion

        #region Elements

        public IWebElement TabLogin
        {
            get { return Constant.WebDriver.FindElement(_tabLogin); }
        }

        public IWebElement TabLogout
        {
            get { return Constant.WebDriver.FindElement(_tabLogout); }
        }

        public IWebElement TabRegister
        {
            get { return Constant.WebDriver.FindElement(_tabRegister); }
        }

        public IWebElement LblWelcomeMessage
        {
            get { return Constant.WebDriver.FindElement(_lblWelcome); }
        }

        public IWebElement LblLoginFailed
        {
            get { return Constant.WebDriver.FindElement(_lblErrormessage); }
        }

        public IWebElement LblSucMessage
        {
            get { return Constant.WebDriver.FindElement(_lblSucMessage); }
        }

        #endregion

        #region Methods

        
        public string GetWelcome()
        {
            return LblWelcomeMessage.Text;
        }

        public string GetErrorMsg()
        {
            return LblLoginFailed.Text;
        }

        public string GetSucMsg()
        {
            return LblSucMessage.Text;
        }

        public LoginPage GotoLoginPage()
        {
            TabLogin.Click();
            return new LoginPage();
        }

        public RegisterPage GotoRegisterPage()
        {
            TabRegister.Click();
            return new RegisterPage();
        }

        public void NavigateRailway()
        {
            HomePage homepage = new HomePage();
            homepage.Open();
        }

        public void GotoTab(string Tabname)
        {
            switch (Tabname)
            {
                case "Login":
                    TabLogin.Click();
                    break;
            }
        }

        #endregion


    }
}