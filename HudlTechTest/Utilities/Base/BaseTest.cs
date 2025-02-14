using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using NUnit.Framework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HudlTechTest.Utilities.Base
{
    public class BaseTest
    {
        

        protected IWebDriver driver;
        protected string url = "https://www.hudl.com/en_gb/";
        

        // setting up the test
         [SetUp]
        public void Setup()
        {
           IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Navigate().GoToUrl(url);
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(30);
        }

        // closing browser after test run
        [TearDown]
        public void Teardown()

        {
           
            {
                driver.Quit();
            }


        
            
        }
    }
}
