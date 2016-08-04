using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BasicSelenium.Common;
using OpenQA.Selenium;

namespace BasicSelenium.PageObjects
{
    public class RegisterPage:GeneralPage
    {
        #region Locators
        private static readonly By _txtEmail = By.Id("email");
        private static readonly By _txtPassword = By.Id("password");
        private static readonly By _txtConfirmPassword = By.Id("confirmPassword");
        private static readonly By _txtPID = By.Id("pid");
        private static readonly By btnRegister= By.XPath("//input[@type='submit']");

        #endregion

        #region Elements

        public IWebElement TxtEmail
        {
            get { return Constant.WebDriver.FindElement(_txtEmail); }
        }

        public IWebElement TxtPassword
        {
            get { return Constant.WebDriver.FindElement(_txtPassword); }
        }

        public IWebElement TxtConfirmPassword
        {
            get { return Constant.WebDriver.FindElement(_txtConfirmPassword); }
        }

        public IWebElement TxtPID
        {
            get { return Constant.WebDriver.FindElement(_txtPID); }
        }
        public IWebElement BtnRegister
        {
            get { return Constant.WebDriver.FindElement(btnRegister); }
        }

        #endregion

        #region Methods

        public RegisterPage Create(string email, string password, string confirmPassword, string pid)
        {   
            TxtEmail.SendKeys(email);
            TxtPassword.SendKeys(password);
            TxtConfirmPassword.SendKeys(confirmPassword);
            TxtPID.SendKeys(pid);
            BtnRegister.Click();
            return new RegisterPage();
        }

        #endregion
    }
}
