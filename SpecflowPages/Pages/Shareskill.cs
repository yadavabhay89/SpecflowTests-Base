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
    class Shareskill
    {

        //Create Constructor

        public Shareskill()
        {
            PageFactory.InitElements(Driver.driver, this);

        }
        

        //Identify the "Share Skill" link

        //tag[attribute = 'value']

        [FindsBy(How = How.CssSelector, Using = "//a[contains(@class,'ui basic green button')]")]

        //[FindsBy(How = How.XPath, Using = "//a[@class='ui basic green button']")]
        private IWebElement Addshareskill { set; get; }

        //Identify the "Title" textbox
        [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.vertically.padded.ui.grid:nth-child(1) div.row div.ui.twelve.wide.column div.twelve.wide.column div.field:nth-child(1) > input:nth-child(1)")]
        private IWebElement Title { set; get; }

        //Identify the "Description" textbox
        [FindsBy(How = How.XPath, Using = "//textarea[@placeholder='Please tell us about any hobbies, additional expertise, or anything else you’d like to add.']")]
        private IWebElement Description { set; get; }

        //Identify the "Add tag" textbox
        [FindsBy(How = How.CssSelector, Using = "div.ui.container:nth-child(3) div.listing form.ui.form div.tooltip-target.ui.grid:nth-child(3) div.twelve.wide.column div.fields div.five.wide.field:nth-child(1) > select.ui.fluid.dropdown")]
        private IWebElement Addtag { set; get; }

        //Identify the "Service Type" Option and Selecting "One off service" option
        [FindsBy(How = How.XPath, Using = "(//INPUT[@name='locationType'])[2]")]
        private IWebElement Oneoffservice { set; get; }

        //Select the "location type" In which options between (1. Onsite, 2. Off Site), Selecting "Online" option
        [FindsBy(How = How.XPath, Using = "//div[6]//div[2]//div[1]//div[1]//div[1]//input[1]")]
        private IWebElement Onsite { set; get; }

        //Identify the "Available days" option
        [FindsBy(How = How.XPath, Using = "//INPUT[@name='startDate']")]
        private IWebElement Startdate { set; get; }


        //Selecting the "Skill-Exchange" option under "Skill Trade" field
        [FindsBy(How = How.XPath, Using = "(//INPUT[@name='skillTrades'])[1]")]
        private IWebElement Skilltrade { set; get; }


        //Identify the "Skill-Echange, Tag  Textbox"" textbox
        [FindsBy(How = How.XPath, Using = "//div[@class='form-wrapper']//input[@placeholder='Add new tag']")]
        private IWebElement Skillexchange { set; get; }

        //Identify the "Active" option under the "Active" field
        [FindsBy(How = How.XPath, Using = "//div[10]//div[2]//div[1]//div[1]//div[1]//input[1]")]
        private IWebElement Active { set; get; }


        //Identify the "Save" button
        [FindsBy(How = How.XPath, Using = "//input[@class='ui button']")]
        private IWebElement Save { set; get; }






        public void Addshareskilldetails()
        {
            //Click on the "Share Skill" Button
            Addshareskill.Click();
            Thread.Sleep(1000);

            //Send data to the "Title" textbox
            Title.SendKeys("I am the Software test analyst with five years of experience using Selenium");
            Thread.Sleep(1000);

            //Send data to the "Description" textbox
            Description.SendKeys("I love to do projects in the software testing and implementing the Page factory.");
            Thread.Sleep(1000);

            //Click the "Category" and Select the options in it
            IWebElement Category = Driver.driver.FindElement(By.XPath("//select[@name='categoryId']"));
            SelectElement Category_dd = new SelectElement(Category);
            Category_dd.SelectByValue("Business");
            Thread.Sleep(1000);

            //Click the "Sub Category" for "business" and Select the options in it
            IWebElement SubCategory = Driver.driver.FindElement(By.XPath("//select[@name='subcategoryId']"));
            SelectElement SubCategory_dd = new SelectElement(SubCategory);
            SubCategory_dd.SelectByValue("Other");
            Thread.Sleep(1000);


            //Tags
            Addtag.SendKeys(Keys.Enter);
            Thread.Sleep(1000);


            //Select the "service type" in which options between (1.Hourly basis service, 2- One-off service), Selectin "One-off service"
            Oneoffservice.Click();
            Thread.Sleep(1000);
            //IWebElement Servicetype = Driver.driver.FindElement(By.XPath("//select[@name='categoryId']"));
            //SelectElement Servicetype_dd = new SelectElement(Servicetype);
            //Servicetype_dd.SelectByValue("1");



            //Select the "location type" In which options between (1. Onsite, 2. Off Site), Selecting "Online" option
            //IWebElement Locationtype = Driver.driver.FindElement(By.XPath("//select[@name='categoryId']"));
            //SelectElement Locationtype_dd = new SelectElement(Locationtype);
            //Locationtype_dd.SelectByValue("1");
            Onsite.Click();
            Thread.Sleep(1000);

            //Enter data to the "Available Days" 
            Startdate.SendKeys("07132019");
            Thread.Sleep(1000);


            //Select the "Skilltrade"
            //IWebElement Skilltrade = Driver.driver.FindElement(By.XPath("//select[@name='categoryId']"));
            //SelectElement Skilltrade_dd = new SelectElement(Skilltrade);
            //Skilltrade_dd.SelectByValue("1");


            //Select the "Skill-Exchange" option under the "Skill Trade" option
            Skilltrade.Click();
            Thread.Sleep(1000);

            //Sending data in "Skill-Exchange" textbox and press "Enter"
            Skillexchange.SendKeys("Python");
            Skillexchange.SendKeys(Keys.Enter);
            Thread.Sleep(1000);


            //Send data to the "Amount" textbox under the "Credit" field
            //Credit.SendKeys("2");
            //Thread.Sleep(1000);

            //Select the "Active" field in which options (1.Active, 2. Hidden), Selecting "Active" option
            Active.Click();
            Thread.Sleep(1000);
            //IWebElement Active = Driver.driver.FindElement(By.XPath("//h3[contains(text(),'Active')]"));
            //SelectElement Active_dd = new SelectElement(Active);
            //Active_dd.SelectByValue("true");

            //Click on the "Save" Button
            Save.Click();
            Thread.Sleep(1000);

        }
    }

}

