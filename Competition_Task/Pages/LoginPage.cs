using Competition_Task.Input;
using Competition_Task.Utilities;
using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competition_Task.Pages
{
    public class LoginPage:Base
    {
        public LoginPage()
        {
            PageFactory.InitElements(driver,this);
        }
            //Click on SignIn
        [FindsBy(How = How.XPath, Using = "//A[@class='item'][text()='Sign In']")]
        private IWebElement signIn;

        //Enter Email address
        [FindsBy(How = How.XPath, Using = "(//INPUT[@type='text'])[2]")]
        private IWebElement userName;

        //Enter password
        [FindsBy(How = How.XPath, Using = "//INPUT[@type='password']")]
        private IWebElement passWord;

        //Click on Login
        [FindsBy(How = How.XPath, Using = "//BUTTON[@class='fluid ui teal button'][text()='Login']")]
        private IWebElement loginBtn;

        public void LoginSteps(IWebDriver driver)

        {

           
            try
            {
                signIn.Click();
                userName.SendKeys(LoginCredential.username);
                passWord.SendKeys(LoginCredential.password);
                loginBtn.Click();
                Waits.ImplicitWait();
            }
            catch (Exception e)
            { 
                
               ClickScreenshots.TakeScreenshot(driver);

               Assert.Fail("Unable to sign in", e.Message);
                throw;

              
                }



        }

    }
}


    

