using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;

//Open chrome browser
IWebDriver cdriver = new ChromeDriver();
cdriver.Manage().Window.Maximize();

//Lauch turnup portal and navigates to login page
cdriver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login");

//Identify username textbox and enter valid username
IWebElement usernametxtbox = cdriver.FindElement(By.Id("UserName"));
usernametxtbox.SendKeys("hari");

//Identify password textbox and enter valid password
IWebElement passwordtxtbox = cdriver.FindElement(By.Id("Password"));
passwordtxtbox.SendKeys("123123");

//Identify login button and click on the button
IWebElement loginbutton = cdriver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
loginbutton.Click();

//Check if the user has logged in successfully
IWebElement hellohari = cdriver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a"));
if(hellohari.Text == "Hello hari!")
{
    Console.WriteLine("User has logged in successfully");
}
else
{
    Console.WriteLine("Invalid Username/Password");
}


