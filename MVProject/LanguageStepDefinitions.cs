using MVProject.Utilites;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Threading;
using TechTalk.SpecFlow;

namespace MVProject
{
    [Binding]
    class LanguageStepDefinitions : CommonDriver
    {
        [Given(@": I logged successfully in website")]
        public void GivenILoggedSuccessfullyInWebsite()
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


        [When(@": I add languages")]
        public void WhenIAddLanguages()
        {


            // Click on Language and add details
            Thread.Sleep(3000);
            IWebElement languagesTab = driver.FindElement(By.XPath("//a[@data-tab='first']"));
            languagesTab.Click();

            Thread.Sleep(3000);
            // Click add new
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


            
            //Update the language

            Thread.Sleep(5000);
            IWebElement languageUpdateIcon = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.active.tooltip-target > div > div.twelve.wide.column.scrollTable > div > table > tbody > tr > td.right.aligned > span:nth-child(1) > i"));
            languageUpdateIcon.Click();

            IWebElement languageEdit = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.active.tooltip-target > div > div.twelve.wide.column.scrollTable > div > table > tbody > tr > td > div > div:nth-child(1) > input[type=text]"));
            languageEdit.Clear();
            languageEdit.SendKeys("English");

            // Click on Update Button
            IWebElement languageUpdateButton = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.active.tooltip-target > div > div.twelve.wide.column.scrollTable > div > table > tbody > tr > td > div > span > input.ui.teal.button"));
            languageUpdateButton.Click();

            //IWebElement actualLanguage = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.active.tooltip-target > div > div.twelve.wide.column.scrollTable > div > table > tbody > tr > td > div > span > input.ui.teal.button"));

            ////Assertion
            //Assert.That(actualLanguage.Text == "Punjabi", "Test Failed.");



            //Click on delete

            Thread.Sleep(5000);
            IWebElement languageDeleteButton = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.active.tooltip-target > div > div.twelve.wide.column.scrollTable > div > table > tbody:nth-child(3) > tr > td.right.aligned > span:nth-child(2) > i"));
            languageDeleteButton.Click();



            driver.Close();


        }

        public string GetLanguage()
        { 

        IWebElement actualLanguage = driver.FindElement(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.active.tooltip-target > div > div.twelve.wide.column.scrollTable > div > table > tbody > tr > td > div > span > input.ui.teal.button"));


         IList<IWebElement> actualLanguages = driver.FindElements(By.CssSelector("#account-profile-section > div > section:nth-child(3) > div > div > div > div.eight.wide.column > form > div.ui.bottom.attached.tab.segment.tooltip-target.active > div > div.twelve.wide.column.scrollTable > div > table"));
         Console.WriteLine(actualLanguages.Count);
         foreach (IWebElement aPart in actualLanguages)
        {
         Console.WriteLine(aPart.Text);
        }

        return actualLanguage.Text;

            

        }
        
       

    }
}
