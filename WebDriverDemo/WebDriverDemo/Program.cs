using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenQA.Selenium;
using OpenQA.Selenium.Firefox; //Firefox namespace
using OpenQA.Selenium.IE; //IE namespace
using OpenQA.Selenium.Chrome; //Chrome namespace

namespace WebDriverDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver(@"C:\Users\Evan\Documents\github\CSharp-and-Windows-Git-Refresher\WebDriverDemo\");
            driver.Url = "http://www.google.com";

            var searchBox = driver.FindElement(By.Id("lst-ib"));
            searchBox.SendKeys("Peddle");

            var searchButton = driver.FindElement(By.ClassName("lsb"));
            searchButton.Click();

            driver.Manage().Timeouts().ImplicitlyWait(TimeSpan.FromSeconds(10)); //if it doesn't find the element wait 10 seconds or throw exception

            //var imagesLink = driver.FindElements(By.CssSelector("a.q.qs"))[0];
            //imagesLink.Click();

            var selectPeddleLink = driver.FindElement(By.LinkText("Peddle: Sell Your Car Instantly"));
            selectPeddleLink.Click();

            var validateHeaderText = driver.(By.Name("Car selling as it should be.")); //this just finds the text we want to assert true/false

            Assert.IsTrue(text.Contains("Test"));

            
        }
    }
}
