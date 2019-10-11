using NUnit.Framework;
using Nunitproject_ravi;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Tests
{
    public class Tests : Base
    {
        [Test]
        public void test()
        {
            driver.Navigate().GoToUrl("https://www.youtube.com");
        }

       
    }
}