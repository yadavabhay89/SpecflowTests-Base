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
    class AddCertifications
    {
        //Create constructor
        public AddCertifications()
        {
            PageFactory.InitElements(Driver.driver, this);

        }


        //Identify "Certification" link
        [FindsBy(How = How.XPath, Using = "//a[contains(text(),'Certifications')]")]
        private IWebElement Certification { set; get; }

        //Identify the "Add New" Button
        [FindsBy(How = How.XPath, Using = "//div[@class='ui bottom attached tab segment tooltip-target active']//div[contains(@class,'ui teal button')][contains(text(),'Add New')]")]
        private IWebElement AddNew { set; get; }

        //Identify the "Certificate or Award" Button
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Certificate or Award']")]
        private IWebElement CertificateorAward { set; get; }

        //Identify the "Certificate from (eg. Adobe)" Button
        [FindsBy(How = How.XPath, Using = "//input[@placeholder='Certified From (e.g. Adobe)']")]
        private IWebElement Certifiedfrom { set; get; }

        //Identify the "Add New" Button
        [FindsBy(How = How.XPath, Using = "//div[@class='five wide field']//input[contains(@class,'ui teal button')]")]
        private IWebElement Addnewcert { set; get; }





        public void Addcertificationdetails()
        {

            //Click on the "Certification" Link
            Certification.Click();
            Thread.Sleep(1000);

            //Click on "Add New" Button
            AddNew.Click();
            Thread.Sleep(1300);

            //Send data to the "Certification or Award" textbox

            CertificateorAward.SendKeys("New Zealand Student Award for 2019");
            Thread.Sleep(1300);


            //Send data to the "Certified from (eg. Adobe)" textbox

            Certifiedfrom.SendKeys("NZQA New Zealand");
            Thread.Sleep(1300);



            //Click on the "Certified year" Drop down and Select the "Year"
            IWebElement Certifiedyear = Driver.driver.FindElement(By.XPath("//select[@name='certificationYear']"));
            SelectElement Certifiedyear_dd = new SelectElement(Certifiedyear);
            Certifiedyear_dd.SelectByValue("2017");
            Thread.Sleep(1300);


            Addnewcert.Click();
            Thread.Sleep(1300);


        }






    }
}
