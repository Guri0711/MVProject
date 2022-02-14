using MVProject.Utilites;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace MVProject
{
    [Binding]
     class SkillsStepDefinitions : CommonDriver
    {
        [Given(@": I logged succesully in website")]
        public void GivenILoggedSuccesullyInWebsite()
        {
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

        [When(@": I add skills to my profile")]
        public void WhenIAddSkillsToMyProfile()
        {
            // Click on Skills and add details
            Thread.Sleep(4000);
            IWebElement skillsTab = driver.FindElement(By.XPath("//a[@data-tab='second']"));
            skillsTab.Click();


            // Click add new

            Thread.Sleep(4000);
            IWebElement addNewButton = driver.FindElement(By.XPath("//div[@class='ui teal button']"));
            addNewButton.Click();

            // Identify the add skills textbox and add detail
            IWebElement addskillsTextbox = driver.FindElement(By.XPath("//input[@placeholder = 'Add Skill']"));
            addskillsTextbox.SendKeys("Testing");

            // Select language level
            IWebElement skillsLevelDropdown = driver.FindElement(By.XPath("//select[@class= 'ui fluid dropdown']"));
            skillsLevelDropdown.Click();

            IWebElement skillsOptionValue = driver.FindElement(By.XPath("//option[@value='Beginner']"));
            skillsOptionValue.Click();

            // Click on Add
            IWebElement add1Button = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > div > span > input.ui.teal.button"));
            add1Button.Click();

    

            driver.Quit();
        }

        [Then(@": The skills should be added")]
        public void ThenTheSkillsShouldBeAdded()
        {
           
        }
    }
}
