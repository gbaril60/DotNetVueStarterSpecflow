Feature: Login
	As a Lowe's employee
	In order to use the application
	I need to be able to log into the application

@Login @Invalid
Scenario: Log in with invalid sales id returns friendly error message
	Given my sales id 456789
	When I log in
	Then I should see a friendly error message

@Login @Valid
Scenario: Log in with valid sales id returns a user object
	Given my sales id 123456
	When I log in
	Then a user object with my information should be returned