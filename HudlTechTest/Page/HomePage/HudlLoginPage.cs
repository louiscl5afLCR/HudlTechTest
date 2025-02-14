using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;

namespace HudlTechTest.Page.HomePage
{
    public class HudlLoginPage
    {
        private readonly IWebDriver driver;

        public HudlLoginPage(IWebDriver driver)
        {
            this.driver = driver;
        }

        // Web element locators
         By handleCookie = By.Id("onetrust-accept-btn-handler");
         By loginButtonHomePage = By.Id("login-select");
         By userNameField = By.Id("username");
         By mainLoginBtn = By.Id("data-action-button-primary");
         By passwordField = By.Id("password");
         By loginBtn = By.ClassName("cca57afd8 cd3e7712e ce210c6b1 c90872909 _button-login-password");
         By logoutBtn = By.Id("hui-globalusermenu__item");


        // Page actions
        public void Cookie()
        {
            driver.FindElement(handleCookie).Click();
        }
        public void LoginHomePage()
        {
            driver.FindElement(loginButtonHomePage).Click();
        }
        public void EnterUserName(string username)
        {
            driver.FindElement(userNameField).SendKeys(username);
        }
        public void LoginButtonAfterEmail()
        {
            driver.FindElement(mainLoginBtn).Click();
        }
        public void EnterPassword(string password)
        {
            driver.FindElement(passwordField).SendKeys(password);
        }

        public void ClickLogin()
        {
            driver.FindElement(loginBtn).Click();
        }

        public void ClickLogout()
        {
            driver.FindElement(logoutBtn).Click();
        }

        public bool HudlHome()
        {
            return driver.Url.Contains("https://www.hudl.com/home");
        }

        public bool ErrorMessageDisplayed()
        {
            return driver.FindElement(By.Id("error-element-username")).Displayed;
        }

        public bool ErrorMessageDisplayedPassword()
        {
            return driver.FindElement(By.Id("error-element-password")).Displayed;
            {
           
        }
    }
}

    
}
