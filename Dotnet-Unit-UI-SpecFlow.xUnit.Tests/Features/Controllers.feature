Feature: Controllers
	In order to avoid errors when navigating
	I want that all Controllers action had a correct return

@mytag
Scenario: Check Home controller
	Given I send a request to Index action
	Then the result should be IActionResult

