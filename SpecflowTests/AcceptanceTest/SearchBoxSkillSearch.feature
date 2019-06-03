Feature: SearchBoxSkillSearch
	In order to Search Skills and see my profile in Search Results
	As a Skill trader
	I want to Search SKillls through Search box

@mytag
Scenario: Check if user could be able to Search throguh Search box and See required results
	Given I have logged into the applications
	When I entered the input in Search box
	Then that Result should be displayed in the Search results
