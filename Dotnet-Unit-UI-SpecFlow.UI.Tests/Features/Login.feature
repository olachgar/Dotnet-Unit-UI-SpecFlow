Feature: Login
	In order to access user account
	As a normal user
	I want to see my profil

@mytag
Scenario: Login as a normal user
	Given I have entered my login into the login page
	And I have entered my passeword into the login page
	When I press validate
	Then the profil page should load
