using MVProject.Utilites;
using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace MVProject
{
    class LoginPage : CommonDriver
    {
        public static void Main(String[] args)
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




    }




        
}


   
