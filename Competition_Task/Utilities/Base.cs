
using AventStack.ExtentReports;
using AventStack.ExtentReports.Reporter;
using Competition_Task.Input;
using Competition_Task.Pages;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    

namespace Competition_Task.Utilities
{
    public class Base
    {
        public static IWebDriver driver;
        public static string url = "http://localhost:5000";
        public static FileStream stream;
        public static ExtentReports extentreportobj;
        public static ExtentHtmlReporter htmlReporter;
        public static ExtentTest test;


    [OneTimeSetUp]
        public void LoginAction()
        {
            var htmlreporter = new ExtentHtmlReporter(@"C:\Automationtest\CompetitionTask\Competition_Task\ExtentReports");
       
            extentreportobj = new ExtentReports();
            extentreportobj.AttachReporter(htmlreporter);


            driver= new ChromeDriver();

            driver.Navigate().GoToUrl(url);

            driver.Manage().Window.Maximize();

            if (LoginCredential.username == "mmr.liton1981@gmail.com")
            {
                LoginPage loginPageObj = new LoginPage();
                loginPageObj.LoginSteps(driver);
            }
            else
            {
                SignupPage signupPageObj = new SignupPage();
                signupPageObj.SignUp(driver);
            }

            
            string fileName = @"C:\Users\mamun\Desktop\SkillParticulars.xlsx";
            //open file and returns as stream
            stream = File.Open(fileName, FileMode.Open, FileAccess.Read);
            ExcelReader.ReadDataTable(stream,"SkillsProfile");
            
        }

        [OneTimeTearDown]

        public void CloseBrowser()
        {
            extentreportobj.Flush();
            driver.Quit();
        }
    }

}

