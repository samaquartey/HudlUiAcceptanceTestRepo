@smoke
Feature: Login
	validating logging into hudl.com 

Background: 
	Given I'm on login page


Scenario: 01. login with valid user details
	Given I login with username "valid-username-here" & password "valid-password-here"
	Then I'm able to see my dashboard


Scenario: 02. login with invalid username & invalid password
	Given I login with username "test" & password "test"
	Then a message "We didn't recognize that email and/or password." is displayed


Scenario: 03. login with empty username & password fields
	Given I login with username "" & password ""
	Then a message "We didn't recognize that email and/or password." is displayed


Scenario: 04. login with empty password details
	Given I login with username "demo" & password ""
	Then a message "We didn't recognize that email and/or password." is displayed


Scenario: 05. login with empty username details
	Given I login with username "" & password "test"
	Then a message "We didn't recognize that email and/or password." is displayed

@organization-login
Scenario: 06. login with invalid organization email
	Given I'm on organization login page
	And message "Log into Hudl with your Organization" is displayed
	When I login with organization email "demo@test.com"
	Then error message "This account can't log in with an organization yet. Please log in using your email and password." is displayed