using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;

namespace lab4TS
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl("https://www.google.com");
            driver.FindElement(By.Name("q")).SendKeys("Computer");
            driver.FindElement(By.Name("q")).SendKeys(Keys.Enter);
            bool isPresent = driver.PageSource.Contains("head");
            if (isPresent)
            {
                Console.WriteLine("TEST PASSED");
            }
            else
            {
                Console.WriteLine("TEST FAILED");
            }
            driver.Close();
        }
    }
}
