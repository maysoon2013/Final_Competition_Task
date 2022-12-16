using OpenQA.Selenium;
using OpenQA.Selenium.Support.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Competition_Task.Utilities
{
    public class ClickScreenshots
    {

        public static void TakeScreenshot(IWebDriver driver)
        { 
           
            Screenshot screenShot = ((ITakesScreenshot)driver).GetScreenshot();
            screenShot.SaveAsFile(@"C:\Automationtest\CompetitionTask\Competition_Task\Screenshoots" + DateTime.Now.ToString("dd-MM-yyyy HH mm ss") + ".jpeg", ScreenshotImageFormat.Jpeg);
  
        }

    }


}

