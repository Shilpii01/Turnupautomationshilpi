using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TurnupAutomation.Pages;
using NUnit.Framework;
using TurnupAutomation.Utilities;

namespace TurnupAutomation.Tests
{
    [TestFixture]
    public class TMTests : CommonDriver
    {

        [SetUp]
        public void SetUpTM()
        {
             cdriver = new ChromeDriver();

            //LoginPage object initialization and definition
            LoginPage loginPageobj = new LoginPage();
            loginPageobj.LoginActions(cdriver);
           
            //HomePage object initialization and definition
            HomePage homePageobj = new HomePage();
            homePageobj.GoToTMPage(cdriver);
            homePageobj.VerifyUserLogin(cdriver);
        }

        [Test, Order(1), Description(" This test creates a new time/Material record")]
        public void TestCreateTimeRecord()
        {
            //TMPage object initialization and definition
            TMPage tmPageobj = new TMPage();
            tmPageobj.CreateTimeRecord(cdriver);
        }

        [Test, Order(2), Description(" This test Updates a new time/Material record")]
        public void TestEditTimeRecord()
        {
            TMPage tmPageobj = new TMPage();
            tmPageobj.EditTimeRecord(cdriver);
        }

        [Test, Order(3), Description(" This test deletes a new time/Material record")]
        public void TestDeleteTimeRecord()
        {
            TMPage tmPageobj = new TMPage();
            tmPageobj.DeleteTimeRecord(cdriver);
        }

        [TearDown]
        public void CloseTestRun()
        {
            cdriver.Close();
        }











       

      

      
       
       
    }
}
