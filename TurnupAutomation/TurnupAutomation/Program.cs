using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;


//Open chrome browser


IWebDriver cdriver = new ChromeDriver();
cdriver.Manage().Window.Maximize();
//Launch turnup portal and navigate to login page 
cdriver.Navigate().GoToUrl("http://horse.industryconnect.io/Account/Login");

//Identify Username textbox and enter valid username
IWebElement usernametxtbox = cdriver.FindElement(By.Id("UserName"));
usernametxtbox.SendKeys("hari");
//Identify password textbox and enter valid password
IWebElement passwordtxtbox = cdriver.FindElement(By.Id("Password"));
passwordtxtbox.SendKeys("123123");
//Identify login button and click on the button
IWebElement loginbutton = cdriver.FindElement(By.XPath("//*[@id=\"loginForm\"]/form/div[3]/input[1]"));
loginbutton.Click();

//Verify if the user has logged in successfully
IWebElement helloHari = cdriver.FindElement(By.XPath("//*[@id=\"logoutForm\"]/ul/li/a"));
if(helloHari.Text == "Hello hari!")
{
    Console.WriteLine("User has logged in successfully");
}
else 
{
    Console.WriteLine("Invalid Username/Password");
}

//Navigate to the administration dropdown 
IWebElement administrationdropdown = cdriver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/a"));
administrationdropdown.Click();

//Select time & materials module 
IWebElement timematerialoption = cdriver.FindElement(By.XPath("/html/body/div[3]/div/div/ul/li[5]/ul/li[3]/a"));
timematerialoption.Click();

//Click on the Create new button for creating a new record in the time & materials module
IWebElement createnewbutton = cdriver.FindElement(By.XPath("//*[@id=\"container\"]/p/a"));
createnewbutton.Click();

//Select the type code 

IWebElement tnmoption = cdriver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span"));
tnmoption.Click();
Thread.Sleep(1000);

IWebElement tmoption = cdriver.FindElement(By.XPath("//*[@id=\"TypeCode_listbox\"]/li[2]"));
tmoption.Click();

//Enter the code in the Code textbox
IWebElement codetxtbox = cdriver.FindElement(By.Id("Code"));
codetxtbox.SendKeys("New record");

// Enter description in the description textbox
IWebElement descriptiontxtbox = cdriver.FindElement(By.Id("Description"));
descriptiontxtbox.SendKeys("data new record");


//Enter the price per unit for the new record
IWebElement pricetxtbox = cdriver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
pricetxtbox.SendKeys("321.45");

//Click on the Save button 
IWebElement savebutton = cdriver.FindElement(By.Id("SaveButton"));
savebutton.Click();

Thread.Sleep(6000);

//Check whether the new record is created successfully 
IWebElement lastpagebutton = cdriver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
lastpagebutton.Click();

IWebElement newrecord = cdriver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
if (newrecord.Text == "New record")
{
    Console.WriteLine("User has been created successfully");
}
else
{
    Console.WriteLine("no record created");
}

//Edit the new created record
IWebElement editbutton = cdriver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[5]/a[1]"));
editbutton.Click();

//Edit the type code to material from time
IWebElement editTypecode = cdriver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[1]/div/span[1]/span/span[1]"));
editTypecode.Click();

IWebElement edit1Typecode = cdriver.FindElement(By.XPath("//*[@id=\"TypeCode_listbox\"]/li[1]"));
edit1Typecode.Click();

//Edit the code textbox 
IWebElement editcodetextbox = cdriver.FindElement(By.Id("Code"));
editcodetextbox.Clear();
editcodetextbox.SendKeys("Edited code");

//Edit the description textbox
IWebElement editdescriptiontextbox = cdriver.FindElement(By.Id("Description"));
editdescriptiontextbox.Clear();
editdescriptiontextbox.SendKeys("Edited description");
Thread.Sleep(2000);

//Edit price textbox
IWebElement editpriceoverlappingtag = cdriver.FindElement(By.XPath("//*[@id=\"TimeMaterialEditForm\"]/div/div[4]/div/span[1]/span/input[1]"));
IWebElement editpricetextbox = cdriver.FindElement(By.Id("Price"));
editpriceoverlappingtag.Click();
editpricetextbox.Clear();
editpriceoverlappingtag.Click();

editpricetextbox.SendKeys("980.76");

//Download the edited record 
IWebElement downloadbutton = cdriver.FindElement(By.Id("downloadButton"));
downloadbutton.Click();

//Save the edited record
IWebElement editsavebutton = cdriver.FindElement(By.Id("SaveButton"));
editsavebutton.Click();

Thread.Sleep(6000);

//Check if the last record is edited successfully 
IWebElement endpagebutton = cdriver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[4]/a[4]/span"));
endpagebutton.Click();

IWebElement editedrecord = cdriver.FindElement(By.XPath("//*[@id=\"tmsGrid\"]/div[3]/table/tbody/tr[last()]/td[1]"));
if (editedrecord.Text == "Edited code")
{
    Console.WriteLine("User has been edited successfully");
}
else
{
    Console.WriteLine("no record edited");
}

//delete the last created record 