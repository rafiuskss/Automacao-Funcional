Feature: 2-FunctionalTestFeature
	Use before title fiture separed with "-":
	 0 for Chrome;
	 1 for Internet Explorer;
	 2 for FireFox Mozilla;
	 Default: Chrome

@mytag
Scenario: Access Page
	Given Access to page "https://material.angular.io/components/categories"		
	Then Page loaded with sucess
