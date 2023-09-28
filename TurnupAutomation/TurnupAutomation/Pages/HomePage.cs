using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurnupAutomation.Pages
{
    public class HomePage
    {
        public void GoToTMPage(IWebDriver cdriver)
        {
            //Navigate to the administration dropdown 

            IWebElement administrationdropdown = cdriver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
            administrationdropdown.Click();

            //Select time & materials module 

            IWebElement timematerialoption = cdriver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
            timematerialoption.Click();
        }

        public void VerifyUserLogin(IWebDriver cdriver)
        {
            //Verify if the user has logged in successfully
            IWebElement helloHari = cdriver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a"));
            if (helloHari.Text == "Hello hari!")
            {
                Console.WriteLine("User has logged in successfully");
            }
            else
            {
                Console.WriteLine("Invalid Username/Password");
            }

        }
    }
}
