Feature: NopCommerce
	In order to complete a technical exercise
	As a tester
	I want to implement a simple web and api automation framework

@mytag
Scenario: Register to NopCommerce
	Given I browse to Nopcommerce registration page
	When I enter all the relevant details
	And I apply for registration
	Then the registration to NopCommerce is successful


Scenario: Login to NopCommerce
    Given I am on the login page of nopCommerce
	When I enter my username "Stefano" and my password "Password123!"
	Then I have successfully logged in


