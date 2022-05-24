using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace LIB
{
    public class Class1
    {


        public IWebDriver Driver;
        // public IJavaScriptExecutor Js;
        public void chrome(string url)
        {
            Driver = new ChromeDriver();
            Driver.Navigate().GoToUrl(url);
            Driver.Manage().Window.Maximize();
        }
        public void sleep(int t)
        {
            Thread.Sleep(t);
        }
        public IWebElement id(string id)
        {

            return Driver.FindElement(By.Id(id));

        }

        public IWebElement xpath(string XPath)
        {
            return Driver.FindElement(By.XPath(XPath));
        }
        public IWebElement xpaths(string XPaths)
        {
            return Driver.FindElements(By.XPath(XPaths))[0];

        }
        public void exit()
        {
            Driver.Close();

            Driver.Quit();


        }
    }
}
