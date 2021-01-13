
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
        IWebElement enter;
        //IWebElement xpathElement = driver.FindElement(By.XPath("/html/body/div[4]/div[1]/div[2]/table/tbody/tr/td[2]/div/div[2]/div[2]/table/tbody/tr/td[1]/div[9]/h3/a"));
        //Console.WriteLine("xpathElement ", xpathElement);

        try
        {
            loginElement = driver.FindElement(By.Id("top-login-uname"));
            enter = driver.FindElement(By.LinkText("Вход"));
            enter.Click();
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
