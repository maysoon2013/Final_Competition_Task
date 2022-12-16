﻿using Competition_Task.Input;
using Competition_Task.Utilities;
using OpenQA.Selenium.Support.UI;
using OpenQA.Selenium;
using SeleniumExtras.PageObjects;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competition_Task.Pages
{
    public class ShareSkill:Base
    {
        public ShareSkill()
        {
            PageFactory.InitElements(driver, this);
        }

            [FindsBy(How = How.XPath, Using = "//body/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[1]/div[1]/div[2]/div[1]/div[1]/input[1]")]
        private IWebElement titleTextBox;

        [FindsBy(How = How.Name, Using = "description")]
        public IWebElement descriptionTextbox;

        [FindsBy(How = How.Name, Using = "categoryId")]
        public IWebElement categoryDropdown;

        [FindsBy(How = How.Name, Using = "subcategoryId")]
        public IWebElement subCategory;

        [FindsBy(How = How.XPath, Using = "//body/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[4]/div[2]/div[1]/div[1]/div[1]/div[1]/input[1]")]
        public IWebElement tagName;

        //Select the Service type - hourly service 

        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[5]/div[2]/div[1]/div[1]/div/input")]
        private IWebElement hourlyServiceType;


        //Select One Off Service Type
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[5]/div[2]/div[1]/div[2]/div/input")]
        private IWebElement oneOffServiceType;

        //Select On-Site Location Type
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[6]/div[2]/div/div[1]/div/input")]
        public IWebElement onSiteLocation;

        //Select Online Location Type
        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[6]/div[2]/div/div[2]/div/input")]
        public IWebElement onlineLocation;

        [FindsBy(How = How.Name, Using = "startDate")]
        public IWebElement startDate;

        [FindsBy(How = How.Name, Using = "endDate")]
        public IWebElement endDate;

        [FindsBy(How = How.XPath, Using = "//body/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[7]/div[2]/div[1]/div[5]/div[1]/div[1]/input[1]")]
        public IWebElement selectWednesday;

        [FindsBy(How = How.XPath, Using = "//body/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[7]/div[2]/div[1]/div[5]/div[2]/input[1]")]
        public IWebElement startTime;

        [FindsBy(How = How.XPath, Using = "//body/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[7]/div[2]/div[1]/div[5]/div[3]/input[1]")]
        public IWebElement endTime;

        [FindsBy(How = How.XPath, Using = "//body/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[8]/div[2]/div[1]/div[1]/div[1]")]
        public IWebElement skillsExchange;

        [FindsBy(How = How.XPath, Using = "//body/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[8]/div[2]/div[1]/div[2]/div[1]/input[1]")]
        public IWebElement selectCredit;

        [FindsBy(How = How.XPath, Using = "//body/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[8]")]
        public IWebElement creditAmount;

        [FindsBy(How = How.XPath, Using = "//*[@id='service-listing-section']/div[2]/div/form/div[8]/div[4]/div/div/div/div/div/input")]
        public IWebElement skillExchange;


        [FindsBy(How = How.XPath, Using = "/html/body/div/div/div[1]/div[2]/div/form/div[9]/div/div[2]/section/div/label/div/span/i")]
        public IWebElement workSample;

        [FindsBy(How = How.XPath, Using = "//body/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[10]/div[2]/div[1]/div[1]/div[1]/input[1]")]
        public IWebElement selectActive;

        [FindsBy(How = How.XPath, Using = "//body/div[1]/div[1]/div[1]/div[2]/div[1]/form[1]/div[1")]
        public IWebElement selectHidden;

        [FindsBy(How = How.XPath, Using = "//input[@value='Save']")]
        public IWebElement saveButton;

        public void CreateSkills(IWebDriver driver)
        {
            
            //identify the title text box and add the title
            string title = ExcelReader.ReadData(1, "Title");
            titleTextBox.SendKeys(title);

            //Identify the description text box and add the description
            descriptionTextbox.Click();
            string description = ExcelReader.ReadData(1, "Description");
            descriptionTextbox.SendKeys(description);

            categoryDropdown.Click();
            SelectElement selectCategory = new SelectElement(categoryDropdown);
            selectCategory.SelectByText(ExcelReader.ReadData(1, "Category"));

            subCategory.Click();
            SelectElement selectSubcategory = new SelectElement(subCategory);
            selectSubcategory.SelectByText(ExcelReader.ReadData(1, "SubCategory"));

            string tag = ExcelReader.ReadData(1, "Tags");
            tagName.SendKeys(tag);
            tagName.SendKeys(Keys.Enter);

            string serviceType = ExcelReader.ReadData(1, "ServiceType");
            if (serviceType.Equals("Hourly basis service"))
            {
                hourlyServiceType.Click();
            }
            else if (serviceType.Equals("One-off service"))
            {
                oneOffServiceType.Click();
            }


            string locationType = ((ExcelReader.ReadData(1, "LocationType")));
            if (locationType.Equals("On-site"))
            {
                onSiteLocation.Click();
            }
            else if (locationType.Equals("Online"))
            {
                onlineLocation.Click();
            }

            string startDateOn = ExcelReader.ReadData(1, "Start Date");
            startDate.SendKeys(startDateOn);

            string endDateOn = ExcelReader.ReadData(1, "End Date");
            endDate.SendKeys(endDateOn);

            selectWednesday.Click();

            string startTimeOn = ExcelReader.ReadData(1, "Start Time");
            startTime.SendKeys(startTimeOn);

            string endTimeOn = ExcelReader.ReadData(1, "End Time");
            endTime.SendKeys(endTimeOn);

            //string creditAmt = ExcelReader.ReadData(1, "Credit Amount");
            //creditAmount.SendKeys(creditAmt);

            skillExchange.Click();
            string skillExchangeTag = ExcelReader.ReadData(1, "SkillsExchange");

            skillExchange.SendKeys(skillExchangeTag);
            skillExchange.SendKeys(Keys.Enter);

            workSample.Click();
            Thread.Sleep(2000);

            using (Process exeProcess = Process.Start(@"C:\Users\mamun\Desktop\worksample.exe"))
            {
                exeProcess.WaitForExit();
            }

            selectActive.Click();
            Waits.ImplicitWait();


            saveButton.Click();
            Waits.ImplicitWait();

            IWebElement viewCreatedSkills = driver.FindElement(By.XPath("//tbody/tr[1]/td[8]/div[1]/button[1]/i[1]"));
            viewCreatedSkills.Click();
            IWebElement checkCreatedTitle = driver.FindElement(By.XPath("//span[contains(text(),'Ace English Grammar')]"));
            Assert.That(checkCreatedTitle.Text == "Ace English Grammar", "Expected Title and Edited Title do not match");


    }

        public void EditSkills(IWebDriver driver)
        {
            Waits.ImplicitWait();
            PageFactory.InitElements(driver, this);
            titleTextBox.Clear();
            string title1 = ExcelReader.ReadData(2, "Title");
            titleTextBox.SendKeys(title1);
            descriptionTextbox.Clear();
            string description1 = ExcelReader.ReadData(2, "Description");
            descriptionTextbox.SendKeys(description1);
            string tag2 = ExcelReader.ReadData(2, "Tags");
            tagName.SendKeys(tag2);
            tagName.SendKeys(Keys.Enter);
            saveButton.Click();
            Waits.ImplicitWait();
            IWebElement viewEditedSkills = driver.FindElement(By.XPath("//tbody/tr[1]/td[8]/div[1]/button[1]/i[1]"));
            viewEditedSkills.Click();
            IWebElement checkEditedTitle = driver.FindElement(By.XPath("//span[contains(text(),'Conversational English')]"));
            Assert.That(checkEditedTitle.Text == "Conversational English", "Expected Title and Edited Title do not match");

        }

       
    }
}




    

