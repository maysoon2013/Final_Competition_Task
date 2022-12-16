using Competition_Task.Input;
using Competition_Task.Utilities;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competition_Task.Pages
{
    public class SignupPage:Base
    {
    public SignupPage() 
        {
         PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.XPath, Using = "//button[contains(text(),'Join')]")]
        public IWebElement joinButton;


        [FindsBy(How = How.XPath, Using = "//body/div[2]/div[1]/div[1]/form[1]/div[1]/input[1]")]
        public IWebElement firstNamebox;

        [FindsBy(How = How.XPath, Using = "input[placeholder='Last name']")]
        public IWebElement lastNamebox;

        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Email address']")]
        public IWebElement emailId;

        [FindsBy(How = How.XPath, Using = "//body/div[2]/div[1]/div[1]/form[1]/div[4]/input[1]")]
        public IWebElement passwordButton;

        [FindsBy(How = How.XPath, Using = "//body/div[2]/div[1]/div[1]/form[1]/div[5]/input[1]")]
        public IWebElement passwordConfirm;

        [FindsBy(How = How.XPath, Using = "//body/div[2]/div[1]/div[1]/form[1]/div[6]/div[1]/div[1]/input[1]")]
        public IWebElement agreeTerms;

        [FindsBy(How = How.XPath, Using = "//div[@id='submit-btn']")]
        public IWebElement submitButton;




        public void SignUp(IWebDriver driver)
        {
            Waits.ImplicitWait();
            joinButton.Click();

            firstNamebox.Click();
            firstNamebox.SendKeys(SignupCredential.firstName);

            lastNamebox.Click();
            lastNamebox.SendKeys(SignupCredential.lastName);

            emailId.Click();
            emailId.SendKeys(SignupCredential.email);

            passwordButton.Click();
            passwordButton.SendKeys(SignupCredential.password);

            passwordConfirm.Click();
            passwordConfirm.SendKeys(SignupCredential.confirmPassword);

            agreeTerms.Click();
            submitButton.Click();

        }

    }
}



