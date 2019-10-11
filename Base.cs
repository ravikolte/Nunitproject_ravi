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
        [Obsolete]
        public void startBrowser()
        {

            DesiredCapabilities Capabilities = new DesiredCapabilities();
            Capabilities.SetCapability(CapabilityType.BrowserName, "chrome");

            //ChromeOptions Options = new ChromeOptions();
           

            driver = new RemoteWebDriver(
              new Uri("http://192.168.99.100:4546/wd/hub/"), Capabilities, TimeSpan.FromSeconds(600));// NOTE: connection timeout of 600 seconds or more required for time to launch grid nodes if non are available.
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
