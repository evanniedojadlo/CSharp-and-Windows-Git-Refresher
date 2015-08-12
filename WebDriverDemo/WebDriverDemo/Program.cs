using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using OpenQA.Selenium;
using OpenQA.Selenium.Firefox; //Firefox namespace
using OpenQA.Selenium.IE; //IE namespace

namespace WebDriverDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new InternetExplorerDriver();
            driver.Url = "http://www.peddle.com";
        }
    }
}
