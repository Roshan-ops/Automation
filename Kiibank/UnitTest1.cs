using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System.Xml.Linq;

namespace Kiibank
{

    public class Tests
    {
        IWebDriver driver;

        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver(); // Initialize ChromeDriver
            driver.Manage().Window.Maximize();
        }

        [Test]
        public void Test1()
        {

            driver.Navigate().GoToUrl("https://kiibankweb.moneyfex.net/login");
            IWebElement webElement = driver.FindElement(By.XPath("/html/body/app-root/app-login/mat-card/div[2]/div/p/button"));
            webElement.Click();
            IWebElement inputElement = driver.FindElement(By.XPath("//*[@for='mat-input-3']"));
            inputElement.SendKeys("Roshan");


        }
     /*   [TearDown]
        public void TearDown()
        {
            if (driver != null)
            {
                driver.Quit(); // Close the browser after each test
                driver.Dispose(); // Dispose of the driver object
            }*/
        }
    }
}