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
        }
    }
}
