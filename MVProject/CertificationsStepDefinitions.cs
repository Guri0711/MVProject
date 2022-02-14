
using MVProject.Utilites;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using TechTalk.SpecFlow;

namespace MVProject 
{
    [Binding]
    class CertificationsStepDefinitions : CommonDriver
    {
        [Given(@": I logged to website succesfully")]
        public void GivenILoggedToWebsiteSuccesfully()
        {
            //Open chrome browser
            driver = new ChromeDriver();
            driver.Manage().Window.Maximize();

            //Launch Mars website

            driver.Navigate().GoToUrl("http://localhost:5000/Home");

            // Click on SignIn Button
            IWebElement signinButton = driver.FindElement(By.XPath("//*[@id='home']/div/div/div[1]/div/a"));
            signinButton.Click();


            //Identify username textbox and enter valid details

            IWebElement emailaddressTextbox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[1]/input"));
            emailaddressTextbox.SendKeys("gurcharan0711@gmail.com");

            //Identify username textbox and enter valid details

            IWebElement passwordTextbox = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[2]/input"));
            passwordTextbox.SendKeys("321321");

            // Click on Login Button

            IWebElement loginButton = driver.FindElement(By.XPath("/html/body/div[2]/div/div/div[1]/div/div[4]/button"));
            loginButton.Click();


        }

        [When(@": I add certifications to my profile")]
        public void WhenIAddCertificationsToMyProfile()
        {
            
        }

        [Then(@": The certifications should be added successfully")]
        public void ThenTheCertificationsShouldBeAddedSuccessfully()
        {
            
        }
    }
}
