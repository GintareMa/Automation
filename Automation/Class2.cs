using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Automation
{
    internal class Class2
    {
        [Test]

        public static void openDemoQA()
        {
            IWebDriver driver = new ChromeDriver();
              driver.Url = "https://demoqa.com/text-box";

              IWebElement inputFullName1 = driver.FindElement(By.Id("userName"));
              IWebElement inputFullName2 = driver.FindElement(By.XPath("//*[@id='userName']"));
              inputFullName2.SendKeys("Gintare");

              string actualInput = inputFullName2.Text;
            
        }

        [Test]

        public static void parseUserAgent()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Url = "https://developers.whatismybrowser.com/";

            driver.FindElement(By.XPath("//*[@type='submit']")).Click();

            string parsedText = driver.FindElement(By.XPath("//*[@class='simple-major']")).Text;
            string actualText = "Chrome 102 on Windows 10";

            Assert.AreEqual(parsedText, actualText);

            driver.Close();

        }
    }

}
