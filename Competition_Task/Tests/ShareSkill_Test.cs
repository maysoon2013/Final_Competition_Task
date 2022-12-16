using AventStack.ExtentReports;
using Competition_Task.Pages;
using Competition_Task.Utilities;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competition_Task.Tests
{
    [TestFixture]
    public class ShareSkill_Test : Base

    {
        ProfilePage profilePageObj = new ProfilePage();
        ShareSkill skillsPageObj = new ShareSkill();
        listingPage listingPageObj =new listingPage();


        [Test, Order(1)]
        public void CreateShareSkillTest()
        {
            try
            {
                test = extentreportobj.CreateTest("CreateSkills", "Testing Create Skills");
                profilePageObj.NavigateShareSkills(driver);
                skillsPageObj.CreateSkills(driver);
                ClickScreenshots.TakeScreenshot(driver);
                test.Log(Status.Info, "Skills created successfully");
                test.Log(Status.Pass, "Test passed");
            }
            catch (Exception ex)
            {
                ClickScreenshots.TakeScreenshot(driver);
                test.Log(Status.Info, "Skills does not create successfully");
                test.Log(Status.Fail, "Test failed");
                Assert.Fail("Create Skills Test failed", ex.Message);
                throw;
            }
        }

        [Test,Order(2)]
        public void EditShareSkillsTest()
        {
            try
            {

                test = extentreportobj.CreateTest("EditSkills", "Testing Edit Skills");
                profilePageObj.NavigateManageListings(driver);
                listingPageObj.NagivateToEdit(driver);
                skillsPageObj.EditSkills(driver);
                ClickScreenshots.TakeScreenshot(driver);
                test.Log(Status.Info, "Skills Edited successfully");
                test.Log(Status.Pass, "Test passed");
            }
            catch (Exception ex)
            {
                ClickScreenshots.TakeScreenshot(driver);
                test.Log(Status.Info, "Skills does not edit successfully");
                test.Log(Status.Fail, "Test failed");
                Assert.Fail("Edit Skills Test failed", ex.Message);
                throw;

             }

        }

        [Test,Order(3)]
        public void DeleteShareSkillTest()
        {
            try
            {
                test = extentreportobj.CreateTest("DeleteSkills", "Testing delete Skills");
                profilePageObj.NavigateManageListings(driver);
                listingPageObj.DeleteSkills(driver);
                ClickScreenshots.TakeScreenshot(driver);
                test.Log(Status.Info, "Skills deleted successfully");
                test.Log(Status.Pass, "Test passed");
            }
            catch (Exception ex)
            {
                ClickScreenshots.TakeScreenshot(driver);
                test.Log(Status.Info, "You do not have service listing");
                test.Log(Status.Fail, "Test failed");
                Assert.Fail("Delete Skills Test failed", ex.Message);
                throw;

            }

        }

    }

}
