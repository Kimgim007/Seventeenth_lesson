
using NUnit.Framework.Internal.Execution;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using SeleniumExtras.WaitHelpers;

namespace Seventeenth_lesson
{
    public class Tests
    {
        IWebDriver driver;
        WebDriverWait wait; 
        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.desmos.com/scientific?lang=ru");
            wait = new WebDriverWait(driver,TimeSpan.FromSeconds(10));
        }

        [Test]
        public void Test1()
        {
           
            IWebElement buttonSeven = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='main']/div/div/div/div[3]/div[2]/div/div/div[1]/div[5]/span")));
            IWebElement buttonPlus = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='main']/div/div/div/div[3]/div[2]/div/div/div[4]/div[8]/span")));
            IWebElement buttonFive = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='main']/div/div/div/div[3]/div[2]/div/div/div[2]/div[6]/span")));   
            IWebElement buttonEnter = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='main']/div/div/div/div[3]/div[2]/div/div/div[4]/div[10]/span")));

            buttonSeven.Click();
            buttonPlus.Click();
            buttonFive.Click();
            buttonEnter.Click();

            IWebElement resultElement = wait.Until(ExpectedConditions.ElementIsVisible(By.XPath("//*[@id='main']/div/div/div/div[1]/div[2]/div/div[5]/div[2]/div[1]/span[2]")));
            var resultText = resultElement.Text;
            var result = resultText.Contains("12");

            Thread.Sleep(5000);
            Assert.That(result, Is.True);
        }
        [TearDown]
        public void TearDown()
        {
            driver.Quit();
            driver.Dispose();
        }

    }
}