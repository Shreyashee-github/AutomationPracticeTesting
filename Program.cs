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

namespace AutomationPractice
{
    class Program
    {

        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            IJavaScriptExecutor js = (IJavaScriptExecutor)driver;
            Actions action = new Actions(driver);


            StartStop.Start(driver);
            //StartStop.register(driver);
            StartStop.signup(driver);

            MyAccount.OrderHistory(driver);

            Dresses.Choice(driver);
            T_Shirts.Choice(driver);


            Women.Choice(driver);
            Women.size(driver);
            Women.AddToWishlist(driver);
            Women.AddToCart(driver);
            Women.PaymentProcess(driver);
            //Women.PaymentBankWire(driver); 
            Women.PaymentCheck(driver);

            StartStop.logout(driver);
            StartStop.Stop(driver);
        }
    }

}
