Feature: AddCertification
	In order to add Certification
	As a Skill Trader
	I want to add Certification

@mytag
Scenario: Check if user could be able to add certification
	Given I have logged into the application successfully
	When I add Certification
	Then that added Certification should be diplayed under my profile page
