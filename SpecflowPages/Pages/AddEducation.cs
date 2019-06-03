using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SpecflowPages.Pages
{
    class AddEducation
    {

        //Create constructor
        public AddEducation()
        {
            PageFactory.InitElements(Driver.driver, this);

        }

        //Identify Education link
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Education')]")]
        //[FindsBy(How = How.XPath, Using = "//a[@class='item'][contains(text(),'Education')]")]
        //Using = "//a[@class='item active']")]
        private IWebElement Education { set; get; }

        //Identify "Add New" Button
        [FindsBy(How = How.XPath, Using = "//div[@class='ui bottom attached tab segment tooltip-target active']//div[contains(@class,'ui teal button')][contains(text(),'Add New')]")]
        private IWebElement AddNew { set; get; }

        //Identify College/University Name Textbox

        [FindsBy(How = How.XPath, Using = "//input[@placeholder='College/University Name']")]
        private IWebElement CollegeName { set; get; }

        //Identify dropdown Menu- Country of College/University
        //[FindsBy(How = How.XPath, Using = "//select[@name='country']")]
        //private IWebElement CountryCollege { set; get; }

        //Identify "Degree" textbox
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Degree']")]
        private IWebElement Degree { set; get; }

        //Identify "Add" button

        [FindsBy(How = How.XPath, Using = "//input[contains(@class,'ui teal button')]")]
        private IWebElement AddEduBtn { set; get; }



        public void AddEduDetail()
        {
            //Click on "Education"
            Education.Click();
            Thread.Sleep(1000);

            //Click on "Add New" button
            AddNew.Click();
            Thread.Sleep(1000);

            //Enter the "College Name"
            CollegeName.SendKeys("Weltec");
            Thread.Sleep(1000);

            //Click on the "Country of College Name"
            //CountryCollege.Click();

            //Select the "Country of College Name"
            IWebElement Country_Name = Driver.driver.FindElement(By.XPath("//select[@name='country']"));
            SelectElement Country_dd = new SelectElement(Country_Name);

            Country_dd.SelectByValue("Argentina");
            Thread.Sleep(1000);

            //Click on the "Title" drop down and Select the "Title"
            IWebElement Title = Driver.driver.FindElement(By.XPath("//select[@name='title']"));
            SelectElement Title_dd = new SelectElement(Title);
            Title_dd.SelectByValue("B.Tech");
            Thread.Sleep(1000);

            //Send data to "Degree" textbox
            Degree.SendKeys("Bachelor of Information technology");
            Thread.Sleep(1000);

            //Click on the "Year of Graduation" drop down and Select the "year"
            IWebElement Graduation = Driver.driver.FindElement(By.XPath("//select[@name='yearOfGraduation']"));
            SelectElement Graduation_dd = new SelectElement(Graduation);
            Graduation_dd.SelectByValue("2016");
            Thread.Sleep(1000);

            //Click on "Add" button to Add all the details in it
            AddEduBtn.Click();
            Thread.Sleep(1000);


        }
    }
}
