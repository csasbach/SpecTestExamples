Feature: WeatherForecastApi
The API endpoints for WeatherForecast

@WeatherForecastApi
Scenario: I can get the weather forecast data from the WeatherForecast API GET endpoint
	When I make a valid request to the GET endpoint of the WeatherForecast API
	Then I retrieve the weather forecast data