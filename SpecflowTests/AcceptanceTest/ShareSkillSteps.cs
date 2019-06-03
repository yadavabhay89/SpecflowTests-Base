using SpecflowPages.Global;
using System;
using TechTalk.SpecFlow;

namespace SpecflowTests
{
    [Binding]
    public class ShareSkillSteps : Base
    {
        [Given(@"I have successfully logged into the application")]
        public void GivenIHaveSuccessfullyLoggedIntoTheApplication()
        {
            Preconditions();
        }
        
        [When(@"I Add the Share Skill")]
        public void WhenIAddTheShareSkill()
        {
            Addingshareskilldetails();
        }
        
        [Then(@"that Skill should be update in my profile section")]
        public void ThenThatSkillShouldBeUpdateInMyProfileSection()
        {
            ClosingSteps();
        }
    }
}
