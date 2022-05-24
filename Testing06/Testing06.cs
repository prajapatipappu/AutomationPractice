using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LIB;
using OpenQA.Selenium;
using OpenQA.Selenium.Interactions;

namespace Testing06
{
    internal class Testing06 : Class1
    {
        public void test()
        {

            chrome("http://automationpractice.com/index.php");
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;

            sleep(2000);
            xpath("//a[@class='login']").Click();
            sleep(2000);
            xpath("//input[@id='email']").SendKeys("abc3014@top.com");
            sleep(2000);
            xpath("//input[@id='passwd']").SendKeys("1223@a");
            sleep(2000);
            xpath("//button[@id='SubmitLogin']").Click();
            //sleep(2000);
            xpath("//a[@title='Women']").Click();
            sleep(5000);
            IWebElement Tshirt = xpath("//a[@title='Women']");



            Tshirt.Click();
            Actions action = new Actions(Driver);
            action.MoveToElement(xpath("//a[@title='Women']"))
                .KeyDown(Keys.Down)
            .Click()
            .Perform();
            sleep(2000);
            js.ExecuteScript("window.scrollBy(0,800)");

            IWebElement hj = Driver.FindElements(By.XPath("//img[@class='replace-2x img-responsive']"))[2];
            Actions actions1 = new Actions(Driver);
            actions1.MoveToElement(hj)
            .Perform();
            sleep(5000);
            //Findxpath("//img[@id='bigpic']")).Click();
            Driver.FindElements(By.XPath("//a[@title='View']"))[1].Click();
            sleep(2000);
            xpath("//i[@class='icon-plus']").Click();

            sleep(2000);
            IWebElement pro = xpath("//select[@id='group_1']");
            pro.Click();
            Actions actions = new Actions(Driver);

            actions.MoveToElement(xpath("//select[@id='group_1']"))
           .KeyDown(Keys.Down)
           .KeyDown(Keys.Down)
            .Click()
            .Perform();
            sleep(2000);
            xpath("//a[@title='White']").Click();
            sleep(2000);
            js.ExecuteScript("window.scrollBy(0,400)");
            sleep(2000);
            //IWebElement cart = Driver.FindElements(By.XPath("//button[@type='submit']"))[3];
            //js.ExecuteScript("arguments[0].click()", cart);
            xpath("//p[@id='add_to_cart']").Click();
            sleep(3000);
            Driver.FindElements(By.XPath("//i[@class='icon-chevron-right right']"))[1].Click();
            sleep(2000);
            Driver.FindElements(By.XPath("//i[@class='icon-chevron-right right']"))[2].Click();
            sleep(2000);
            js.ExecuteScript("window.scrollBy(0,400)");
            Driver.FindElements(By.XPath("//i[@class='icon-chevron-right right']"))[6].Click();
            sleep(2000);
            xpath("//input[@id='cgv']").Click();
            sleep(2000);
            js.ExecuteScript("window.scrollBy(0,400)");

            Driver.FindElements(By.XPath("//i[@class='icon-chevron-right right']"))[2].Click();
            sleep(2000);
            exit();
        }
    }
}
