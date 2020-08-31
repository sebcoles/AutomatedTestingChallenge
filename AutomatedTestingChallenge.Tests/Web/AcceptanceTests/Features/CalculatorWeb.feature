Feature: Calculator
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Add two numbers using the Add website
	Given I browse to the home page
	Given I click the 'Add' link
	And I enter '5' and '10' into the web form
	When I click submit
	Then the I should see the answer '15' appear on the page
	And this should complete within '1000' milliseconds
