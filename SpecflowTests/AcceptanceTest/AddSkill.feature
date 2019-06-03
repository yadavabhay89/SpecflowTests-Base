Feature: AddSkill
	In order to add Skills
	As a Skill Trader
	I want to Add Skill in my profile

@mytag
Scenario: Check if user is able to Add Skills
	Given I have logged into the application
	When I add Skills
	Then Added skills is disoplayed under my profile page
