using NUnit.Framework;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

namespace _04._NUnit
{
    [TestFixture]
    public class Tests
    {
        private IWebDriver driver;

        [OneTimeSetUp]
        public void BeforeAllMethods()
        {
            driver = new ChromeDriver();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(10);
        }

        [SetUp]
        public void Setup()
        {
            driver.Navigate().GoToUrl("https://google.com.ua/");
        }

        [OneTimeTearDown]
        public void AfterAllMethods()
        {
            driver.Quit();
        }

        [Test]
        public void TestOne()
        {
            driver.FindElement(By.ClassName("gLFyf")).Click();
            driver.FindElement(By.ClassName("gLFyf")).Clear();
            Thread.Sleep(3000);
            driver.FindElement(By.ClassName("gLFyf")).SendKeys("visual studio code" + Keys.Enter);
            Thread.Sleep(3000);
            driver.FindElement(By.LinkText("Download")).Click();

            IWebElement actual = driver.FindElement(By.LinkText("Visual Studio Code"));
            Assert.True(actual.Text.Contains("Visual Studio Code"));
            Thread.Sleep(3000);

            ITakesScreenshot takeScreenshot = driver as ITakesScreenshot;
            Screenshot screenshot = takeScreenshot.GetScreenshot();
            screenshot.SaveAsFile("d:/selenium/downloadVsCode.png", ScreenshotImageFormat.Png);
        }
    }
}