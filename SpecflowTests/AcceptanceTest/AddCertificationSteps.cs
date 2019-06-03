using SpecflowPages.Global;
using System;
using TechTalk.SpecFlow;

namespace SpecflowTests.AcceptanceTest
{
    [Binding]
    public class AddCertificationSteps : Base
    {
        [Given(@"I have logged into the application successfully")]
        public void GivenIHaveLoggedIntoTheApplicationSuccessfully()
        {
            Preconditions();
        }
        
        [When(@"I add Certification")]
        public void WhenIAddCertification()
        {
            Addingcertificationdetails();
        }
        
        [Then(@"that added Certification should be diplayed under my profile page")]
        public void ThenThatAddedCertificationShouldBeDiplayedUnderMyProfilePage()
        {
            ClosingSteps();
        }
    }
}
