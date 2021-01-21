
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

class EntryPoint
{
    static void Main(string[] args)
    {
        IWebDriver driver = new ChromeDriver();
        

        driver.Navigate().GoToUrl("https://www.bing.com/");
        IWebElement search = driver.FindElement(By.Id("sb_form_q"));
        search.SendKeys("YWT");

        try
        {
            Thread.Sleep(3000);
            //IWebElement play_button = driver.FindElement(By.ClassName("ytp-play-button"));
            //Thread.Sleep(2000);
            //play_button.Click();
            //Thread.Sleep(60000);
            driver.Quit();
        }
        catch (NoSuchElementException)
        {
            WriteRed("This element not found");
        }


        Thread.Sleep(15000);

        driver.Quit();
    }

    private static void WriteRed(string message)
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine(message);
        Console.ForegroundColor = ConsoleColor.White;
    }

    private static void WriteGreen(string message)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine(message);
        Console.ForegroundColor = ConsoleColor.White;
    }
}
