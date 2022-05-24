using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LIB;
using OpenQA.Selenium;

namespace Testing
{
    internal class Testing00 : Class1
    {
        public void test()
        {

            chrome("http://automationpractice.com/index.php");
            IJavaScriptExecutor js = (IJavaScriptExecutor)Driver;

            sleep(2000);
            xpath("//a[@class='login']").Click();
            xpath("//input[@id='email_create']").SendKeys("ltgtt@vusra.com");
            sleep(2000);
            xpath("//button[@id='SubmitCreate']").Click();
            sleep(3000);
            IWebElement female =xpath("//input[@id='id_gender2']");
            js.ExecuteScript("arguments[0].click()", female);
            sleep(2000);
            IWebElement Male =xpath("//input[@id='id_gender1']");
            js.ExecuteScript("arguments[0].click()", Male);
            sleep(2000);
            xpath("//input[@id='customer_firstname']").SendKeys("rahul");
            sleep(2000);
            xpath("//input[@id='customer_lastname']").SendKeys("Kumar");
            sleep(2000);
            xpath("//input[@id='passwd']").SendKeys("123@qwe");
            sleep(2000);
            xpath("//select[@id='days']").Click();
            sleep(2000);
            xpath("//select[@id='days']//option[17]").Click();

            sleep(2000);
            xpath("//select[@id='days']").Click();
            sleep(3000);
            xpath("//select[@id='months']//option[3]").Click();
            sleep(2000);
            xpath("//select[@id='years']").Click();
            sleep(2000);
            xpath("//select[@id='years']//option[10]").Click();
            sleep(2000);
            xpath("//input[@id='newsletter']").Click();
            sleep(2000);
            xpath("//input[@id='optin']").Click();
            sleep(2000);
            xpath("//input[@id='company']").SendKeys("hwl");
            sleep(2000);
            xpath("//input[@id='address1']").SendKeys("roadline");
            sleep(2000);
            xpath("//input[@id='city']").SendKeys("Los Angeles");
            sleep(2000);
            xpath("//div[@id='uniform-id_state']").Click();
            xpath("//select[@id='id_state']//option[6]").Click();
            sleep(2000);
            xpath("//input[@id='postcode']").SendKeys("90001");
            sleep(2000);
            xpath("//textarea[@id='other']").SendKeys("Hello!");
            sleep(2000);
            xpath("//input[@id='phone_mobile']").SendKeys("789654210");
            sleep(2000);
            xpath("//button[@id='submitAccount']").Click();
            sleep(3000);
            exit();
        }
    }
}
