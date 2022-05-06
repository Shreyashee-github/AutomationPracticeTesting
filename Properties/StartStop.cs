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
    class StartStop
    {
        public static void Start(IWebDriver driver)
        {
            Console.WriteLine("Test Case started: ");
            Thread.Sleep(2000);
            Console.WriteLine("Automation Practice started");
            Thread.Sleep(2000);
            driver.Navigate().GoToUrl("http://automationpractice.com/");
            Thread.Sleep(2000);
            driver.Manage().Window.Maximize();
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;

        }


        //ALREADY REGISTERED
        public static void signup(IWebDriver driver)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;

            driver.FindElement(By.XPath("//a[@class='login']")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//input[@id='email']")).SendKeys("panditkonnagar@gmail.com");
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//input[@id='passwd']")).SendKeys("Shreya@12");
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//button[@id='SubmitLogin']")).Click();
            Thread.Sleep(1000);
            js.ExecuteScript("window.scrollBy(0,200)");
            Thread.Sleep(1000);
        }


        //CREATE AN ACCOUNT
        public static void register(IWebDriver driver)
        {
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;

            driver.FindElement(By.XPath("//input[@id='email_create']")).SendKeys("panditkonnagar@gmail.com");
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//button[@id='SubmitCreate']")).Click();
            Thread.Sleep(4000);

            //Your Personal Information

            //Radio button
            driver.FindElement(By.XPath("//label[@for='id_gender2']")).Click();
            Thread.Sleep(1000);
            //driver.FindElement(By.XPath("//input[@id='id_gender2']")).Click();
            //Thread.Sleep(1000);
            //driver.FindElement(By.XPath("//div[@id='uniform-id_gender2']")).Click();
            //Thread.Sleep(1000);

            driver.FindElement(By.XPath("//input[@id='customer_firstname']")).SendKeys("SHREYASHEE");
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//input[@id='customer_lastname']")).SendKeys("PANDIT");
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//input[@id='passwd']")).SendKeys("Shreya@12");
            Thread.Sleep(2000);

            //Date of Birth
            driver.FindElement(By.XPath("//select[@id='days']")).Click();
            //driver.FindElement(By.XPath("//select[@id='days']")).Clear();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//option[@value='26']")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//select[@id='months']")).Click();
            Thread.Sleep(4000);
            driver.FindElement(By.XPath("//option[@value='1']")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//select[@id='years']")).Click();
            Thread.Sleep(2000);
            driver.FindElement(By.XPath("//option[@value='2000']")).Click();
            Thread.Sleep(1000);

            js.ExecuteScript("window.scrollBy(0,200)");
            Thread.Sleep(1000);

            driver.FindElement(By.XPath("//input[@id='newsletter']")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//input[@id='optin']")).Click();
            Thread.Sleep(1000);

            js.ExecuteScript("window.scrollBy(0,200)");
            Thread.Sleep(1000);

            //Your Address
            driver.FindElement(By.XPath("//input[@id='firstname']")).SendKeys(" ");
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//input[@id='lastname']")).SendKeys(" ");
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//input[@id='company']")).SendKeys("Inceptial Infostructure & Technology LLP");
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//input[@id='address1']")).SendKeys("Kolkata");
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//input[@id='address2']")).SendKeys("West Bengal, India");
            Thread.Sleep(1000);
            js.ExecuteScript("window.scrollBy(0,200)");
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//input[@id='city']")).SendKeys("Kolkata");
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//select[@id='id_country']")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//option[@value='21']")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//select[@id='id_state']")).Click();
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//option[@value='32']")).Click();
            Thread.Sleep(1000);
            js.ExecuteScript("window.scrollBy(0,200)");
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//input[@id='postcode']")).SendKeys("10002");
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//textarea[@id='other']")).SendKeys("9903872722");
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//input[@id='phone']")).SendKeys("5200110025");
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//input[@id='phone_mobile']")).SendKeys("1002552001");
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//input[@id='alias']")).Clear();
            driver.FindElement(By.XPath("//input[@id='alias']")).SendKeys("London,United Kingdom");
            Thread.Sleep(1000);
            driver.FindElement(By.XPath("//span[text()='Register']")).Click();
            Thread.Sleep(1000);
        }

        public static void logout(IWebDriver driver)
        {

            driver.FindElement(By.XPath("//a[@class='home']")).Click();
            Thread.Sleep(2000);

            driver.FindElement(By.XPath("//a[@class='logout']")).Click();
            Thread.Sleep(4000);
        }

        public static void Stop(IWebDriver driver)
        {

            Console.WriteLine("Automation Practice ended");
            Thread.Sleep(1000);
            driver.Manage().Window.Minimize();
            Thread.Sleep(2000);
            driver.Close();
            driver.Dispose();
            driver.Quit();
            Console.WriteLine("Test Case ended: ");
            Thread.Sleep(2000);

        }
    }
}






    
