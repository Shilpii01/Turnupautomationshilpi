using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using TurnupAutomation.Pages;


//Open chrome browser


public class Program
{
    private static void Main(string[] args)
    {
        IWebDriver cdriver = new ChromeDriver();

        //LoginPage object initialization and definition
        LoginPage loginPageobj = new LoginPage();
        loginPageobj.LoginActions(cdriver);

        //HomePage object initialization and definition
        HomePage homePageobj = new HomePage();
        homePageobj.GoToTMPage(cdriver);
        homePageobj.VerifyUserLogin(cdriver);

        //TMPage object initialization and definition
        TMPage tmPageobj = new TMPage();
        tmPageobj.CreateTimeRecord(cdriver);
        tmPageobj.EditTimeRecord(cdriver);
        tmPageobj.DeleteTimeRecord(cdriver);
    }
}