Feature: RestApi
	In order to check rest api endpoints
	As a tester
	I want to implement a rest api simple test code

@mytag
Scenario: Rest Api
	Given I need to check "https://jsonplaceholder.typicode.com/posts" endpoint
	When I make a rest request to the endpoint and fecth the results
	Then the expected results are retrieved

