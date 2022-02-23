Feature: DataDrivenWithParameter
	Simple calculator for adding two numbers

@mytag
Scenario: Data Driven With Parameter
	Given I navigate to "https://opensource-demo.orangehrmlive.com/"
	And I enter the Username "Admin"
	And I enter the  password "admin123"
	When I click on loging
	Then I should be able to loging succefully