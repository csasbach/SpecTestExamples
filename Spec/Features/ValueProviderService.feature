Feature: ValueProviderService
A service that provides value

@ValueProviderService
Scenario: I can access a string value from the value provider service
	When I access the value property of the value provider
	Then I am returned a value