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
    public class ProfilePage:Base
    {
        public ProfilePage() 
        {
            PageFactory.InitElements(driver, this);
        }
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Share Skill')]")]
        private IWebElement shareskillBtn;

        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Manage Listings')]")]
        public IWebElement manageListings;

       public void NavigateShareSkills(IWebDriver driver)
        {
            PageFactory.InitElements(driver, this);
            shareskillBtn.Click();

        }
        public void NavigateManageListings(IWebDriver driver)
        {
            manageListings.Click();
            Waits.ImplicitWait();
        }
        









    }
}


