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
    class Women
    {
        public static void Choice(IWebDriver driver)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;

            driver.FindElement(By.XPath("//a[@title='Women']")).Click();
            Thread.Sleep(1000);
            js.ExecuteScript("window.scrollBy(0,200)");
            Thread.Sleep(1000);
            js.ExecuteScript("window.scrollBy(0,500)");
            Thread.Sleep(2000);

            driver.FindElement(By.XPath("//a[@title='Printed Summer Dress']")).Click();
            Thread.Sleep(4000);
            //driver.FindElement(By.XPath("//span[text()='View larger']")).Click();
            //Thread.Sleep(1000);
            //driver.SwitchTo().ActiveElement();
            //Thread.Sleep(2000);

            //driver.FindElement(By.XPath("//*[@id='product']/div[2]/div/a")).Click();
            //Thread.Sleep(1000);
            driver.SwitchTo().ActiveElement();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//a[@name='Orange']")).Click();
            Thread.Sleep(1000);
        }



        public static void size(IWebDriver driver)
        {
            //size select
            driver.FindElement(By.XPath("//select[@name='group_1']")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//option[@value='2']")).Click();
            Thread.Sleep(1000);
        }

        public static void AddToWishlist(IWebDriver driver)
        {
            //Add to wishlist
            //driver.FindElement(By.XPath("//a[@id='wishlist_button']")).Click();
            //Thread.Sleep(1000);
            //var alert_win1 = driver.SwitchTo().Alert();
            //alert_win1.Dismiss();
            //driver.FindElement(By.XPath("//*[@id='product']/div[2]/div/div/a")).Click();
            //driver.FindElement(By.XPath("//a[@title='Close']")).Click();
        }

        public static void AddToCart(IWebDriver driver)
        {
            //add to cart
            driver.FindElement(By.XPath("//button[@name='Submit']")).Click();
            Thread.Sleep(1000);

            //driver.FindElement(By.XPath("//a[@title='Proceed to checkout']")).Click();
            driver.FindElement(By.XPath("//*[@id='layer_cart']/div[1]/div[2]/div[4]/a")).Click();
            Thread.Sleep(2000);
        }

        public static void PaymentProcess(IWebDriver driver)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;

            js.ExecuteScript("window.scrollBy(0,400)");

            //driver.FindElement(By.XPath("//a[@title='Proceed to checkout']")).Click();
            driver.FindElement(By.XPath("//*[@id='center_column']/p[2]/a[1]")).Click();
            Thread.Sleep(2000);

            js.ExecuteScript("window.scrollBy(0,400)");

            //driver.FindElement(By.XPath("//a[@title='Proceed to checkout']")).Click();
            driver.FindElement(By.XPath("//*[@id='center_column']/form/p/button")).Click();
            Thread.Sleep(2000);

            js.ExecuteScript("window.scrollBy(0,400)");

            driver.FindElement(By.XPath("//input[@id='cgv']")).Click();
            Thread.Sleep(1000);
            //driver.FindElement(By.XPath("//a[@title='Proceed to checkout']")).Click();
            driver.FindElement(By.XPath("//*[@id='form']/p/button")).Click();
            Thread.Sleep(2000);
            js.ExecuteScript("window.scrollBy(0,400)");
        }

        public static void PaymentBankWire(IWebDriver driver)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;


            driver.FindElement(By.XPath("//a[@class='bankwire']")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//*[@id='cart_navigation']/button")).Click();
            Thread.Sleep(2000);
            js.ExecuteScript("window.scrollBy(0,200)");
        }


        public static void PaymentCheck(IWebDriver driver)
        {
            driver.FindElement(By.XPath("//a[@class='cheque']")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//*[@id='cart_navigation']/button")).Click();
            Thread.Sleep(2000);
        }

    }

}


    

