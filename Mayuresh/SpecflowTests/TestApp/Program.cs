using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;
using OpenQA.Selenium.Chrome;
using System.Text.RegularExpressions;


namespace TestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string exp = @"(\W)*";
            char[] nonAlphaNumChar = {';'};

            foreach (char c in nonAlphaNumChar)
            {
                Console.WriteLine(c);
            }

            Console.ReadLine();
            //IWebDriver driver = new ChromeDriver();
            ////IAleort promptHandler;

            //driver.Navigate().GoToUrl("http://ahirram:PythonCanada@17@10.37.1.7/eAppreciations/");

            //Thread.Sleep(10000);

            ////promptHandler = driver.SwitchTo().Alert();
            ////promptHandler.SendKeys("ahirram" + Keys.Tab);
            ////promptHandler.SendKeys("PythonCanada@17");
            ////promptHandler.Accept();

            //driver.Close();
            //driver.Quit();
        }
    }
}
