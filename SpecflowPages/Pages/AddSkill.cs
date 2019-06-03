using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecflowPages.Pages
{
    class Addskill
    {

        //Create constructor
        public Addskill()
        {
            PageFactory.InitElements(Driver.driver, this);

        }

        //Click on "Skill" tab
        [FindsBy(How = How.CssSelector, Using = "div.ui:nth-child(1) div.ui.fluid.container div.ui.grid div.row div.eight.wide.column form.ui.form:nth-child(2) div.ui.top.attached.tabular.menu:nth-child(1) > a.item:nth-child(2)")]
        private IWebElement Skills { set; get; }


        //Identify the "Add New" Button
        [FindsBy(How = How.XPath, Using = "//div[@class='ui teal button']")]
        private IWebElement AddNewButn { set; get; }

        //Identify "Add skill" textbox
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Add Skill']")]
        private IWebElement Addskillbox { set; get; }

        //Identify "Add" button fro SKill
        [FindsBy(How = How.XPath, Using = "//input[contains(@class,'ui teal button')]")]
        private IWebElement SkilllevelAddButn { set; get; }

        public void Addskilldetails()

        {
            //Click on "Add Skill" button for Adding skill
            Skills.Click();

            //Click on "Add New" buttton under "Skills" field
            AddNewButn.Click();


            //Send the data to the "Add Language" textbox
            Addskillbox.SendKeys("I am expert in Selenium, Nunit, C# and Java");

            //Click on the "Choose Skill Level", and Select option "Expert"
            IWebElement Skilllevel = Driver.driver.FindElement(By.XPath("//select[@name='level']"));
            SelectElement Skilllevel_dd = new SelectElement(Skilllevel);
            Skilllevel_dd.SelectByValue("Expert");


            //Click on the "Add" button after adding details in skill tab
            SkilllevelAddButn.Click();


        }









    }
}
