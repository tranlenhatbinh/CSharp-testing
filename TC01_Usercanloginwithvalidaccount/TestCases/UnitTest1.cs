using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using OpenQA.Selenium.Firefox;
using BasicSelenium.Common;
using BasicSelenium.PageObjects;

namespace BasicSelenium.TestCases
{

    [TestClass]
    public class UnitTest1: GeneralPage
    {
        [TestMethod]
        public void TC01_User_can_login_to_Railway_with_valid_username_and_password()
        {
            Console.WriteLine("TC01 - User can log into Railway with valid username and password");
            //1. Navigate to QA Railway Website
            NavigateRailway();

            //2. Click on "Login" tab
            GotoTab("Login");

            //3. Enter valid Email and Password
            //4. Click on "Login" button
            LoginPage loginPage = new LoginPage();
            loginPage.Login(Constant.userName, Constant.passWord);

            //VP. User is logged into Railway. Welcome user message is displayed
            string actualMsg = loginPage.GetWelcome();
            VerifyMessage(Constant.welcomeMessage,actualMsg);

        }

        [TestMethod]
        public void TC02_User_cannot_login_with_blank_Username_textbox()
        {
            Console.WriteLine("TC02 - User can't login with blank Username textbox");
            //1. Navigate to QA Railway Website
            HomePage homePage = new HomePage();
            homePage.Open();

            //2. Click on "Login" tab
            LoginPage loginPage = homePage.GotoLoginPage();

            //3. User doesn't type any words into "Username" textbox but enter valid information into "Password" textbox
            //4. Click on "Login" button
            loginPage.Login("", Constant.passWord);

            //VP. User can't login and message "There was a problem with your login and/or errors exist in your form. "
            string actualMsg = loginPage.GetErrorMsg();
            Assert.AreEqual(Constant.errorTC02, actualMsg);
        }

        [TestMethod]
        public void TC03_User_cannot_login_to_Railway_with_valid_password()
        {
            Console.WriteLine("TC03 - User cannot log into Railway with valid password");
            //1. Navigate to QA Railway Website
            HomePage homePage = new HomePage();
            homePage.Open();

            //2. Click on "Login" tab
            LoginPage loginPage = homePage.GotoLoginPage();

            //3. Enter valid Email and invalid Password
            //4. Click on "Login" button
            loginPage.Login(Constant.userName, Constant.invalidPassword);

            //VP Error message "There was a problem with your login and/or errors exist in your form." is displayed
            string actualMsg = loginPage.GetErrorMsg();
            Assert.AreEqual(Constant.errorTC03, actualMsg);
        }

        [TestMethod]
        public void TC04_System_show_message_when_user_enter_wrong_password_severaltimes()
        {
            Console.WriteLine("TC04- System show message when user enter wrong password several times");
            //1. Navigate to QA Railway Website
            HomePage homePage = new HomePage();
            homePage.Open();

            //2. Click on "Login" tab
            LoginPage loginPage = homePage.GotoLoginPage();

            //3. Enter valid information into "Username" textbox except "Password" textbox
            //4. Click on "Login" button
            //5. Repeat step 3 three more times
            loginPage.LoginTimes(Constant.times, Constant.userName, Constant.invalidPassword);

            //VP User can't login and message "You have used 4 out of 5 login attempts.After all 5 have been used, you will be unable to login for 15 minutes." appears
            string actualMsg = loginPage.GetErrorMsg();
            Assert.AreEqual(Constant.errorTC04, actualMsg);
        }

        [TestMethod]
        public void TC05_User_can_create_new_account()
        {
            Console.WriteLine("TC05- User can create new account");
            //1. Navigate to QA Railway Website
            HomePage homePage = new HomePage();
            homePage.Open();

            //2. Click on "Register" tab
            RegisterPage registerPage = homePage.GotoRegisterPage();


            //3. Enter valid information into all fields
            //4. Click on "Register" button
            registerPage.Create(Constant.randomEmail, Constant.passWord, Constant.confirmPassword, Constant.PID);

            //VP New account is created and message "Thank you for registering your account" appears
            string actualMsg =
                registerPage.GetSucMsg();
            Assert.AreEqual(Constant.sucMessageTC05, actualMsg);
        }

        [TestMethod]
        public void TC06_User_cannot_login_with_account_has_not_been_activated()
        {
            Console.WriteLine("TC06- User can't login with account hasn't been activated");
            //1. Navigate to QA Railway Website
            HomePage homePage = new HomePage();
            homePage.Open();

            //2. Click on "Login" tab
            //2. Click on "Login" tab
            LoginPage loginPage = homePage.GotoLoginPage();

            //3. Enter username and password of account hasn't been actived
            //4. Click on "Login" button
            loginPage.Login(Constant.randomEmail, Constant.passWord);

            //VP User can't login and message "Invalid username or password. Please try again."
            string actualMsg = loginPage.GetErrorMsg();
            Assert.AreEqual(Constant.errorTC06, actualMsg);
        }

    }
}
