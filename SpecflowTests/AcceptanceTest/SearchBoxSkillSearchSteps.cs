using SpecflowPages.Global;
using System;
using TechTalk.SpecFlow;

namespace SpecflowTests.AcceptanceTest
{
    [Binding]
    public class SearchBoxSkillSearchSteps : Base
    {
        [Given(@"I have logged into the applications")]
        public void GivenIHaveLoggedIntoTheApplications()
        {
            Preconditions();
        }
        
        [When(@"I entered the input in Search box")]
        public void WhenIEnteredTheInputInSearchBox()
        {
            SearchSkillthroughSearchbox();
        }
        
        [Then(@"that Result should be displayed in the Search results")]
        public void ThenThatResultShouldBeDisplayedInTheSearchResults()
        {
            ClosingSteps();
        }
    }
}
