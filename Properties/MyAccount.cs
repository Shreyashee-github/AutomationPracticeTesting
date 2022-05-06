using AutomationPractice.Properties;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Interactions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace AutomationPractice.Properties
{
    class MyAccount
    {
        public static void OrderHistory(IWebDriver driver)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;

            driver.FindElement(By.XPath("//a[@title='Orders']")).Click();
            Thread.Sleep(4000);
            js.ExecuteScript("window.scrollBy(0,400)");
            driver.FindElement(By.XPath("//*[@id='columns']/div[1]/a[2]")).Click();
            Thread.Sleep(1000);
            //To return Home
            //driver.FindElement(By.XPath("//a[@title='Return to Home']")).Click();
            //Thread.Sleep(1000);
            driver.FindElement(By.XPath("//a[@title='Credit slips']")).Click();
            Thread.Sleep(1000);
            js.ExecuteScript("window.scrollBy(0,400)");
            driver.FindElement(By.XPath("//*[@id='columns']/div[1]/a[2]")).Click();
            Thread.Sleep(1000);

            js.ExecuteScript("window.scrollBy(0,400)");

            driver.FindElement(By.XPath("//a[@title='Addresses']")).Click();
            Thread.Sleep(1000);
            js.ExecuteScript("window.scrollBy(0,400)");
            driver.FindElement(By.XPath("//*[@id='columns']/div[1]/a[2]")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//a[@title='Information']")).Click();
            Thread.Sleep(1000);
            js.ExecuteScript("window.scrollBy(0,400)");
            driver.FindElement(By.XPath("//*[@id='columns']/div[1]/a[2]")).Click();
            Thread.Sleep(1000);
            js.ExecuteScript("window.scrollBy(0,400)");
            driver.FindElement(By.XPath("//a[@title='My wishlists']")).Click();
            Thread.Sleep(1000);

            js.ExecuteScript("window.scrollBy(0,400)");

            driver.FindElement(By.XPath("//input[@id='name']")).SendKeys("Printed Chiffon Dress");
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//button[@id='submitWishlist']")).Click();
            Thread.Sleep(1000);
            js.ExecuteScript("window.scrollBy(0,400)");
            driver.FindElement(By.XPath("//i[@class='icon-remove']")).Click();
            Thread.Sleep(1000);
            var alert_win = driver.SwitchTo().Alert();
            alert_win.Accept();
            //alert_win.Dismiss();

            driver.FindElement(By.XPath("//a[@class='home']")).Click();
            Thread.Sleep(1000);

        }
    }
}






   

