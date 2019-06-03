using SpecflowPages.Global;
using System;
using TechTalk.SpecFlow;

namespace SpecflowTests
{
    [Binding]
    public class AddEducationSteps : Base
    {
        [Given(@"I have successfully logged into the APplicaiton")]
        public void GivenIHaveSuccessfullyLoggedIntoTheAPplicaiton()
        {
            Preconditions();
        }
        
        [When(@"I add Education")]
        public void WhenIAddEducation()
        {
            AddingEducationDetails();
        }
        
        [Then(@"that Education should be displayed in my listings")]
        public void ThenThatEducationShouldBeDisplayedInMyListings()
        {
            ClosingSteps();
        }
    }
}
