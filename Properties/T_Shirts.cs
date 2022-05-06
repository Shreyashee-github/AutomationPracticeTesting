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
    class T_Shirts
    {
        
        public static void Choice(IWebDriver driver)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;

            driver.FindElement(By.XPath("//*[@id='block_top_menu']/ul/li[3]/a")).Click();
            Thread.Sleep(1000);
            js.ExecuteScript("window.scrollBy(0,400)");
            driver.FindElement(By.XPath("//*[@id='columns']/div[1]/a[1]")).Click();
            Thread.Sleep(2000);
        }
    }

}

