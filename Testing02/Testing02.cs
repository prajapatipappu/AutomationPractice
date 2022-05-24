using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LIB;
using OpenQA.Selenium;

namespace Testing02
{
    internal class Testing02 : Class1
    {
        public void test2()
        {

            chrome("http://automationpractice.com/index.php");
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;

            sleep(2000);
            xpath("//a[@class='login']").Click();
            xpath("//input[@id='email_create']").SendKeys("hfej@.com");
            sleep(2000);
            xpath("//button[@id='SubmitCreate']").Click();
            sleep(3000);
            exit();
        }
    }
}
