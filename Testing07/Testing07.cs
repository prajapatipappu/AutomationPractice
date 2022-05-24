using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LIB;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;

namespace Testing07 
{
    public  class Testing07 : Class1
    {
        public void test()
        {
            chrome("http://automationpractice.com/index.php");
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;
           
            sleep(2000);
            IWebElement Tshirt =xpath("//a[@title='Women']");



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
            Driver.FindElements(By.XPath("//a[@title='View']"))[1].Click();
            sleep(2000);
            js.ExecuteScript("window.scrollBy(0,500)");
            sleep(2000);
            xpath("//a[@id='wishlist_button']").Click();





            sleep(2000);
            exit();

        }
    
       

    }
}
