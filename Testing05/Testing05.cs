using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LIB;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace Testing05
{
    internal class Testing05 : Class1
    {
        public void test()
        {
            chrome("http://automationpractice.com/index.php");
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;

            sleep(2000);
            xpath("//a[@title='Women']").Click();
            sleep(5000);
            IWebElement Tshirt = xpath("//a[@title='Women']");



            Tshirt.Click();
            Actions action = new Actions(Driver);
            action.MoveToElement(xpath("//a[@title='Women']"))
                .KeyDown(Keys.Down)
            .Click()
            .Perform();

            js.ExecuteScript("arguments[0].click()", Tshirt);
            sleep(5000);
            //incompltete
            exit();
        }
    }
}
