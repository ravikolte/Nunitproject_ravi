using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Tests
{
    public class Tests
    {
        IWebDriver driver;

        [SetUp]
        public void startBrowser()
        {
            driver = new ChromeDriver(@"C:\\Users\\Ravi\\.nuget\\packages\\selenium.webdriver.chromedriver\\77.0.3865.4000\\driver\\win32");
        }
        

        [Test]
        public void test()
        {
            driver.Navigate().GoToUrl("https://www.youtube.com");
        }

        [TearDown]
        public void closeBrowser()
        {
            driver.Close();
            driver.Quit();
            driver.Dispose();
        }
    }
}