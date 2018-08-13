Feature: FunctionalTestFeature
	Use before title fiture separed with "-":
	 'C' for Chrome;
	 'I' for Internet Explorer;
	 'F' for FireFox Mozilla;
	 Default: Chrome

@AcessPage
Scenario: Access Page
	Given Access to page "https://material.angular.io/components/categories"	
	Then Page loaded with sucess

@Menu
Scenario: Form Controls Validate
Given Access the menu "Form Controls > Autocomplete"
When I typed the letter "T"
Then "2" options were displayed
