

Feature: DataDrivenWithExemple
	Simple calculator for adding two numbers

@mytag
Scenario Outline:Dat Driven With Exemple
	Given I navigate to "https://opensource-demo.orangehrmlive.com/"
	And the user enter the Username "<Username>"
	And the user enter the  password "<Password>"
	When I click on loging
	Then I should be able to loging succefully

	Examples: 

	
	| Username | Password |
	| Admin    | admin123 |