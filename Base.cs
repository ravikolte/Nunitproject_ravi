using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using System.Threading.Tasks;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using OpenQA.Selenium.Remote;

namespace Nunitproject_ravi
{
    public class Base
    {
       public static RemoteWebDriver driver;

        [SetUp]
        public void startBrowser()
        {

              //CHROME and IE            
            ChromeOptions Options = new ChromeOptions();
            //InternetExplorerOptions Options = new InternetExplorerOptions();
            Options.PlatformName = "windows";
            Options.AddAdditionalCapability("platform", "WIN10", true); // Supported values: "VISTA" (Windows 7), "WIN8" (Windows 8), "WIN8_1" (windows 8.1), "WIN10" (Windows 10), "LINUX" (Linux)
            Options.AddAdditionalCapability("version", "latest", true); // for Chrome only, you can specify version=latest or the real version number like version=74. For Firefox and IE you must always specify the version number.
            Options.AddAdditionalCapability("video", "True", true);


            driver = new RemoteWebDriver(
              new Uri("http://http://192.168.99.100:4546/wd/hub/"), Options.ToCapabilities(), TimeSpan.FromSeconds(600));// NOTE: connection timeout of 600 seconds or more required for time to launch grid nodes if non are available.
                                                                                                                                          // driver = new ChromeDriver(@"C:\\Users\\Ravi\\.nuget\\packages\\selenium.webdriver.chromedriver\\77.0.3865.4000\\driver\\win32");
        }

        [OneTimeTearDown]
        public void closeBrowser()
        {
            driver.Close();
            driver.Quit();
            driver.Dispose();
        }

    }
}
