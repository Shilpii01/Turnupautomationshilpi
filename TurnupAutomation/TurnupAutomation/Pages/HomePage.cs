using NUnit.Framework;
using OpenQA.Selenium;

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
            
                Assert.That( helloHari.Text == "Hello hari!", "Invalid Username/Password");
                    
                
            
           

        }
    }
}
