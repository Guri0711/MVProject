using MVProject.Utilites;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;
using TechTalk.SpecFlow;

namespace MVProject
{
    [Binding]
    class DescriptionStepDefinitions : CommonDriver
    {
        [Given(@": I logged successfully")]
        public void GivenILoggedSuccessfully()
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

        [When(@": I add description")]
        public void WhenIAddDescription()
        {
            // Click on Descripton and add details

            Thread.Sleep(3000);
            IWebElement descriptionTab = driver.FindElement(By.XPath("//i[@class='outline write icon']"));
            descriptionTab.Click();

            // Enter the details
            IWebElement descriptionTextbox = driver.FindElement(By.XPath("//textarea[@name='value']"));
            descriptionTextbox.SendKeys("My hobbies cooking and exploring new places");

            //Click on Save button
            IWebElement saveButton = driver.FindElement(By.XPath("//button[@type='button']"));
            saveButton.Click();

            driver.Quit();

        }

        [Then(@": descrition should add")]
        public void ThenDescritionShouldAdd()
        {
          //  IWebElement actualDescription = driver.FindElement(By.XPath("//span[@style='padding - top: 1em; ']"));

            //if (actualDescription.Text == "My hobbies cooking and exploring new places")
           // {
            //  Console.WriteLine("Description added, test passed");
           // }
           // else
           // {
               // Console.WriteLine("Test Failed");
            //}
        }
    }
}
