using RelevantCodes.ExtentReports;
using SpecflowPages;
using SpecflowPages.Global;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using TechTalk.SpecFlow;
using static SpecflowPages.CommonMethods;

namespace SpecflowTests.Utils
{
    public class Start : Base
    {
        [BeforeScenario]
        public void SetUp()
        {
            //Launch the browser
            Preconditions();
            Thread.Sleep(500);

            //Call the Login Class            
            //SpecflowPages.Utils.LoginPage.LoginStep();         
                      
        }

        [AfterScenario]
        public void TearDown()
        {
            ClosingSteps();
            Thread.Sleep(500);
            // Screenshot
            //string img = SaveScreenShotClass.SaveScreenshot(Driver.driver, "Report");
            //test.Log(LogStatus.Info, "Snapshot below: " + test.AddScreenCapture(img));

            // end test. (Reports)
            //CommonMethods.extent.EndTest(CommonMethods.test);

            // calling Flush writes everything to the log file (Reports)
            //CommonMethods.extent.Flush();

            //Close the browser
            //Close();
        }

    }
}
