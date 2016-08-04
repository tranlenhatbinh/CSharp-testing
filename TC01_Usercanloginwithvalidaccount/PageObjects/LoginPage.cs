using OpenQA.Selenium;
using BasicSelenium.Common;

namespace BasicSelenium.PageObjects
{
    public class LoginPage : GeneralPage
    {
        #region  Locators

        private static readonly By _txtUsername = By.Id("username");
        private static readonly By _txtPassword = By.Id("password");
        private static readonly By _btnLogin = By.XPath("//input[@value='login']");

        #endregion

        #region Elements

        public IWebElement TxtUsername
        {
            get { return Constant.WebDriver.FindElement(_txtUsername); }
        }

        public IWebElement TxtPassword
        {
            get { return Constant.WebDriver.FindElement(_txtPassword); }
        }

        public IWebElement BtnLogin
        {
            get { return Constant.WebDriver.FindElement(_btnLogin); }
        }

        #endregion

        #region Methods

        public HomePage Login(string username, string password)
        {
            TxtUsername.SendKeys(username);
            TxtPassword.SendKeys(password);
            BtnLogin.Click();
            return new HomePage();
        }

        public HomePage LoginTimes(int time, string username, string password)
        {
            for (var i = 1; i <= time; i++)
            {   
                TxtUsername.SendKeys(username);
                TxtPassword.SendKeys(password);
                BtnLogin.Click();
            }
            return new HomePage();
        }

        #endregion
    }
}