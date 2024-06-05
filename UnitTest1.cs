
using NUnit.Framework.Internal.Execution;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

namespace Seventeenth_lesson
{
    public class Tests
    {
        IWebDriver driver;
        [SetUp]
        public void Setup()
        {
            driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.desmos.com/scientific?lang=ru");
        }

        [Test]
        public void Test1()
        {
            Thread.Sleep(3000);
            IWebElement buttonSeven = driver.FindElement(By.XPath("//*[@id='main']/div/div/div/div[3]/div[2]/div/div/div[1]/div[5]/span"));
            buttonSeven.Click();

            Thread.Sleep(3000);
            IWebElement buttonPlus = driver.FindElement(By.XPath("//*[@id='main']/div/div/div/div[3]/div[2]/div/div/div[4]/div[8]/span"));
            buttonPlus.Click();

            Thread.Sleep(3000);
            IWebElement buttonFive = driver.FindElement(By.XPath("//*[@id='main']/div/div/div/div[3]/div[2]/div/div/div[2]/div[6]/span"));
            buttonFive.Click();

            Thread.Sleep(3000);
            IWebElement buttonEnter = driver.FindElement(By.XPath("//*[@id='main']/div/div/div/div[3]/div[2]/div/div/div[4]/div[10]/span"));
            buttonEnter.Click();

            Thread.Sleep(5000);
            Assert.Pass();
        }
        [TearDown]
        public void TearDown()
        {
            driver.Quit();
            driver.Dispose();
        }

    }
}