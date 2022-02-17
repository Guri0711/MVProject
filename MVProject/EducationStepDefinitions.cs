using MVProject.Utilites;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace MVProject
{
    [Binding]
    class EducationStepDefinitions : CommonDriver
    {
        [Given(@": I logged in successfully")]
        public void GivenILoggedInSuccessfully()
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

        [When(@": I add my education details")]
        public void WhenIAddMyEducationDetails()
        {
            // Click on Descripton and add details

            // Click on Language and add details
            Thread.Sleep(3000);
            IWebElement languagesTab = driver.FindElement(By.XPath("//a[@data-tab='third']"));
            languagesTab.Click();

            // Click add new,

            Thread.Sleep(3000);
            
            IWebElement addNewButton = driver.FindElement(By.XPath("//div[@class= 'ui teal button ' and text() = 'Add New']"));
            addNewButton.Click();

            // Identify the add language textbox and add detail
            IWebElement addlanguagesTextbox = driver.FindElement(By.XPath("//input[@name='name']"));
            addlanguagesTextbox.SendKeys("Punjabi");

            // Select language level
            IWebElement languageLevelDropdown = driver.FindElement(By.XPath("//select[@name='level']"));
            languageLevelDropdown.Click();

            IWebElement langauageOptionValue = driver.FindElement(By.XPath("//option[@value='Basic']"));
            langauageOptionValue.Click();

            // Click on Add
            IWebElement addButton = driver.FindElement(By.XPath("//input[@value= 'Add']"));
            addButton.Click();


            driver.Quit();
        }

        [Then(@": The education detail should be added")]
        public void ThenTheEducationDetailShouldBeAdded()
        {
            throw new PendingStepException();
        }
    }
}
