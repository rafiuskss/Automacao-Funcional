Feature: I-FunctionalTestFeature
	Use before title fiture separed with "-":
	 'C' for Chrome;
	 'I' for Internet Explorer;
	 'F' for FireFox Mozilla;
	 'E' for Edge;
	 Default: Chrome

@AcessPage
Scenario: Access Page
	Given Access to page "https://material.angular.io/components/categories"	
	Then Page loaded with sucess

@Form_Controls
Scenario: Form Controls Autocomplete
Given Access the menu " Form Controls "
And Access the submenu " Autocomplete "
When I typed the letter "T"
Then "2" options were displayed


@Form_Controls
Scenario: Form Controls Datepicker
Given Access the menu " Form Controls "
And Access the submenu " Datepicker "
When Clicked on the calendar
Then Calendar opened successfully


@Form_Controls
Scenario: Form Controls Input
Given Access the menu " Form Controls "
And Access the submenu " Input "
When I entered a valid email "automacao@teste.com"
Then Validated email


@Form_Controls
Scenario: Form Controls Select
Given Access the menu " Form Controls "
And Access the submenu " Select "
When I select the option "Option 2"
Then Valid the option selected "option2"