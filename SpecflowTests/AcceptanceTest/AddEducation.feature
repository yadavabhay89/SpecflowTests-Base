Feature: AddEducation
	In order to add Education
	As a Skill Trader
	I want to Add Education to my profile page

@mytag
Scenario: Check if user could be able to Add Education
	Given I have successfully logged into the APplicaiton
	When I add Education
	Then that Education should be displayed in my listings
