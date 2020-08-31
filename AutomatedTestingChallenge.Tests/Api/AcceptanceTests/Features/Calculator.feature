Feature: Calculator
	In order to avoid silly mistakes
	As a math idiot
	I want to be told the sum of two numbers

@mytag
Scenario: Add two numbers using the Add API
	Given the first number is '10' and the second number is '5'
	When the two numbers are send to the Add API
	Then the result response should be '15'
	And the request should complete within '1000' milliseconds