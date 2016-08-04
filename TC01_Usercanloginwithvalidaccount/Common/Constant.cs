using System;
using OpenQA.Selenium;
using  BasicSelenium.Common;
namespace BasicSelenium.Common
{
    public class Constant
    {   
        // Initialize about some information
        public const string HomePageUrl = "http://192.168.189.49:8099/Page/HomePage.cshtml";
        public const string userName = "binhtran@mailinator.com";
        public const string passWord = "123456789";
        public const string invalidPassword = "123";
        public const string confirmPassword = "123456789";
        public const string PID = "123456789";
        public const int times = 4;
        public static IWebDriver WebDriver;
        public static readonly string randomEmail = Convert.ToString(DateTime.Now.ToString("ddMMyyyyhhmmss") + "@mailinator.com");

        //Define some expected messages 
        public static string welcomeMessage = "Welcome " + userName;
        public static string errorTC02 = "There was a problem with your login and/or errors exist in your form. ";
        public static string errorTC03 = "There was a problem with your login and/or errors exist in your form.";
        public static string errorTC04 = "You have used 4 out of 5 login attempts.After all 5 have been used, you will be unable to login for 15 minutes.";
        public static string sucMessageTC05 = "Thank you for registering your account";
        public static string errorTC06 = "Invalid username or password. Please try again.";
    }




}