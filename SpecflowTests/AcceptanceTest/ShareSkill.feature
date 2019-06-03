Feature: ShareSkill
	In order to Addd Share SKill
	As a Skill Trader
	I want to add SHare SKill Details under my profile page

@mytag
Scenario: Check oif user could be able to add the Share skill
	Given I have successfully logged into the application
	When I Add the Share Skill 
	Then that Skill should be update in my profile section
