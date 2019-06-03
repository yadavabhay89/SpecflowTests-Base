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
    class AddLanguage
    {

        //Create constructor
        public AddLanguage()
        {
            PageFactory.InitElements(Driver.driver, this);

        }


        //Identify "Language" link
        //[FindsBy(How = How.XPath, Using = "//a[contains(text(),'Languages')]")]
        //private IWebElement Education { set; get; }

        //Click on "Add New" button
        [FindsBy(How = How.CssSelector, Using = "div.ui:nth-child(1) div.ui.fluid.container div.ui.grid div.row div.eight.wide.column form.ui.form:nth-child(2) div.ui.bottom.attached.tab.segment.active.tooltip-target:nth-child(2) div.row div.twelve.wide.column.scrollTable div.form-wrapper table.ui.fixed.table thead:nth-child(1) tr:nth-child(1) th.right.aligned:nth-child(3) > div.ui.teal.button")]
        private IWebElement Addnewlang { set; get; }

        //Identify "Add Language" textbox
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Add Language']")]
        private IWebElement LanguageAdd { set; get; }

        //Identify "Add" button for Language textbox
        [FindsBy(How = How.XPath, Using = "(//INPUT[@type='button'])[1]")]
        private IWebElement LanguageAddFinButn { set; get; }




        public void Addlanguagedetails()

        {
            //Click on "Add New" button for Adding language
            Addnewlang.Click();


            //Send the data to the "Add Language" textbox
            LanguageAdd.SendKeys("Chinese and Russian");

            //Click on the "Choose Language Level", and Select option "Fluent"
            IWebElement Languagelevel = Driver.driver.FindElement(By.XPath("//select[@name='level']"));
            SelectElement Languagelevel_dd = new SelectElement(Languagelevel);
            Languagelevel_dd.SelectByValue("Fluent");


            //Click on the "Add" button after adding details in language tab
            LanguageAddFinButn.Click();


        }






    }
}