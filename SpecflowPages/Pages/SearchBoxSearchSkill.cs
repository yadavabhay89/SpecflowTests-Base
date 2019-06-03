using OpenQA.Selenium;
using OpenQA.Selenium.Support.PageObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace SpecflowPages.Pages
{
    class SearchBoxSearchSkill
    {
        //Create constructor
        public SearchBoxSearchSkill()
        {
            PageFactory.InitElements(Driver.driver, this);

        }

        //Identify "Search SKill" box
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Search skills']")]
        private IWebElement SearchSkill { set; get; }


        //Identify "Search Icon"
        [FindsBy(How = How.XPath, Using = "//i[@class='search link icon']")]
        private IWebElement SearchIcon { set; get; }



        public void SearchSkillthroughSearchbox()
        {

            //Click on Search Skill textbox
            SearchSkill.SendKeys("I am a Script writer");
            Thread.Sleep(1000);

            //Click on the "Search Icon"
            SearchIcon.Click();
            Thread.Sleep(1000);



            string msg = "Refine Results";

            string Actualmsg = Driver.driver.FindElement(By.XPath("//h3[contains(text(),'Refine Results')]")).Text;

            if (msg == Actualmsg)
             {
                Console.WriteLine("Test Passed");
            
            Thread.Sleep(1000);
            
            }
            else
             {
              Console.WriteLine("Test Failed");
            }



        }
    }
}
