Feature: HomePage
The home page of our example App

@HomePage
Scenario: I can navigate to the Weather Forecast by clicking the Fetch Data link
	When I click on the Fetch Data link
	Then I have navigated to the Weather Forecast page