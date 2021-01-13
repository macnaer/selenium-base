
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Threading;

class EntryPoint
{
    static void Main(string[] args)
    {
        IWebDriver driver = new ChromeDriver();

        driver.Navigate().GoToUrl("http://rutracker.org");

        IWebElement loginElement;

        try
        {
            loginElement = driver.FindElement(By.Id("top-login-uname"));
            if (loginElement.Displayed)
            {
                WriteGreen("Login element is visible: True");
            }
            else
            {
                WriteRed("Login element is visible: False");
            }

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
