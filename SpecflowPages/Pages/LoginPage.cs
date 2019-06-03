using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.PageObjects;
using RelevantCodes.ExtentReports;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static SpecflowPages.CommonMethods;

namespace SpecflowPages.Pages
{
    public class LoginPage
    {


        //Create Constructor
        public LoginPage()
        {

            PageFactory.InitElements(Driver.driver, this);

        }

        //Identify IWebelemeent "SignIn" Button
        [FindsBy(How = How.XPath, Using = "//a[@class='item']")]
        private IWebElement SignInbutton { set; get; }


        //Identify IWebelement Username textbox
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Email address']")]
        private IWebElement Username { set; get; }


        //Identify IWebelemeent Password textbox
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Password']")]
        private IWebElement Password { set; get; }


        //Identify IWebelemeent "Login" Button
        [FindsBy(How = How.XPath, Using = "//button[@class='fluid ui teal button']")]
        private IWebElement Login { set; get; }



        public void LoginStep()


        {
            //Driver.NavigateUrl();
            //Thread.Sleep(1000);
            //IWebDriver driver = new ChromeDriver();

            //Navigate to the URL
            Driver.driver.Navigate().GoToUrl("http://www.skillswap.pro");


            //Click on Sign In
            //Driver.Driver.FindElement(By.XPath("//a[@class='item']"))
            SignInbutton.Click();
            Thread.Sleep(1000);

            //Enter Username
            //Driver.driver.FindElement(By.XPath("//input[@placeholder='Email address']")).
            Username.SendKeys("abbieroyale@gmail.com");
            Thread.Sleep(1000);
            //Console.WriteLine("Username has been entered");

            //Enter password
            //Driver.driver.FindElement(By.XPath("//input[@placeholder='Password']")).
            Password.SendKeys("abhay@mars");
            //Console.WriteLine("Password has been entered");
            Thread.Sleep(1000);

            //Click on Login Button

            Login.Click();
            Thread.Sleep(1000);

            //Driver.driver.FindElement(By.XPath("/html[1]/body[1]/div[2]/div[1]/div[1]/div[1]/div[1]/div[4]/button[1]")).Click();

            // string msg = "Add New Job";
            //string Actualmsg = Driver.driver.FindElement(By.XPath("//div[@class='ui bottom attached tab segment active tooltip-target']//div[contains(@class,'ui teal button')][contains(text(),'Add New')]")).Text;

            //string Actualmsg = Driver.driver.FindElement(By.XPath("//*[@id='addnewjob']")).Text;

            //if (msg == Actualmsg)
            // {
            //    Console.WriteLine("Test Passed");
            //CommonMethods.ExtentReports();
            //   Thread.Sleep(500);
            //test = CommonMethods.extent.StartTest("Login with valid data");
            //Thread.Sleep(1000);
            //CommonMethods.test.Log(LogStatus.Pass, "Test Passed");
            //SaveScreenShotClass.SaveScreenshot(Driver.driver, "HomePage");
            //}
            //else
            // {
            //   Console.WriteLine("Test Failed");
            //CommonMethods.test.Log(LogStatus.Fail, "Test Failed");
            // }
        }

    }
}
