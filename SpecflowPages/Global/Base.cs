using NUnit.Framework;
using OpenQA.Selenium.Chrome;
using SpecflowPages.Pages;
//using SpecflowPages.Utils;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecflowPages.Global
{
    public class Base
    {


        //Preconditions
        [SetUp]
        public void Preconditions()

        {
            //Launching the browser

            Driver.driver = new ChromeDriver();

            // Calling the Loginpage Class
            LoginPage obj = new LoginPage();
            obj.LoginStep();
        }


        //Test Case 1
        [Test]
        public void AddingEducationDetails()
        {
            //Calling the AddEducation Class
            AddEducation obj1 = new AddEducation();
            obj1.AddEduDetail();
        }


        //Test Case 2
        [Test]
        public void Addingcertificationdetails()
        {
            //Calling the Addcertification Class
            AddCertifications obj2 = new AddCertifications();
            obj2.Addcertificationdetails();

        }


        //Test Case 3
        [Test]

        public void Addingshareskilldetails()
        {
            //Calling the Share skill Class
            Shareskill obj3 = new Shareskill();
            obj3.Addshareskilldetails();

        }


        //Test Case 4
        [Test]
        public void Addlanguagedetails()
        {
            //Calling the Addlanguage Class
            AddLanguage obj4 = new AddLanguage();
            obj4.Addlanguagedetails();

        }


        //Test Case 5
        [Test]
        public void Addskilldetails()
        {
            //Calling the Addskill Class
            Addskill obj5 = new Addskill();
            obj5.Addskilldetails();

        }


        //Test Case 6
        [Test]
        public void SearchSkillthroughSearchbox()
        {
            //Calling Search SKill
            SearchBoxSearchSkill obj6 = new SearchBoxSearchSkill();
            obj6.SearchSkillthroughSearchbox();


        }


        //Conclusion
        [TearDown]
        public void ClosingSteps()
        {
        //Close the browser
        Driver.driver.Close();
        }



    }
}
