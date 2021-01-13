
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

class enrtyPoint
{
    static void Main()
    {
        IWebDriver driver = new ChromeDriver();

        driver.Navigate().GoToUrl("http://rutracker.org");

    }
}
