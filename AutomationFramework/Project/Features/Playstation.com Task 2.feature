Feature: Playstation task 2

Background: 
Given I start "Playstation Task 2" test


@test 1
Scenario: Verify the image link takes the user to the correct page
	Given I have navigated to the playstion website
	When I click the Right Now On Playstation chevron
	And I click the Your PS Plus games for December image
	And I Verify that the page has loaded correctly
	Then Complete the test
