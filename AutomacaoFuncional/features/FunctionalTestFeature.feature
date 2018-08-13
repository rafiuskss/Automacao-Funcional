Feature: C-FunctionalTestFeature
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


@Navigation
Scenario: Navigation Menu
Given Access the menu " Navigation "
And Access the submenu " Menu "
When I clicked the menu
Then Options menus returned


@Layout
Scenario: Layout Stepper
Given Access the menu " Layout "
And Access the submenu " Stepper "
When I clicked the button enable linear mode
Then Iten enebled


@Buttons_&_Indicators
Scenario: Navigation Buttons & Indicators Button Toogle
Given Access the menu " Buttons & Indicators "
And Access the submenu " Button toggle "
When I clicked the buttonToggle
Then ButtonToggle selected


@Buttons_&_Indicators
Scenario: Navigation Buttons & Indicators Chips
Given Access the menu " Buttons & Indicators "
And Access the submenu " Chips "
When Insert new chips "AUTOMACAO FUNCIONAL"
Then Chips inserted successfully the text "AUTOMACAO FUNCIONAL"


@Popups_&_Modals 
Scenario: Navigation Popups & Modals Dialog
Given Access the menu " Popups & Modals "
And Access the submenu " Dialog "
When Insert the text "AUTOMACAO FUNCIONAL"
And Click the button Pick one
Then Dialog opened with the text "AUTOMACAO FUNCIONAL"


@Popups_&_Modals 
Scenario: Navigation Popups & Modals Snackbar
Given Access the menu " Popups & Modals "
And Access the submenu " Snackbar "
When Insert the message snack-bar "AUTOMACAO FUNCIONAL"
And Click the button showsnack-bar
Then Sneck-bar opened with the text "AUTOMACAO FUNCIONAL"


@Data_Table 
Scenario: Data Table Table
Given Access the menu " Data table "
And Access the submenu " Table "
When click to change the page
Then page changed successfully