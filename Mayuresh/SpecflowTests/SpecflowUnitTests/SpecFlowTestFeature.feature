Feature: SpecFlowTestsFeature
	Sample Test Cases for the eAppriciation framework

@mytag

#Background: Pre-Conditions
#	Given User is at eAppreciation Home Page
#	And User has logged in with Spider credentials

 Scenario: SLIA-123: Verify that as a user, I should be able to add an appreciation without a media file

	Given User is at eAppreciation Home Page
	And User has logged in with Spider credentials 'Mayuresh Ahirrao'
	
	When I press add
	Then I land at the page 'The Wipfli Way - Add'
	And My name 'Mayuresh Ahirrao' is visible at the 'From' textbox 

	When I add name 'Bhushan Nalawade' to the 'ToField' textbox
	And I select given name from the 'ToField' dropdown
	Then The given name 'Bhushan Nalawade' is shown in 'To' section
	
	When I enter message 'This is a test message, generated automatically to test the Specflow scripts.' into the 'Message' field
	But no media file is selected
	Then the message 'This is a test message, generated automatically to test the Specflow scripts.' is added to the 'Message' field
	
	When I click on 'Save and Close' button
	Then I land at the page 'The Wipfli Way - View'

Scenario: SLIA-124: Verify that as a User, I can add multiple appreciations
	Given User is at eAppreciation Home Page
	And User has logged in with Spider credentials 'Mayuresh Ahirrao'
	
	When I press add
	Then I land at the page 'The Wipfli Way - Add'
	And My name 'Mayuresh Ahirrao' is visible at the 'From' textbox 

	When I add name 'Bhushan Nalawade' to the 'ToField' textbox
	And I select given name from the 'ToField' dropdown
	Then The given name 'Bhushan Nalawade' is shown in 'To' section
	
	When I enter message 'This is a test message, generated automatically to test the Specflow scripts.' into the 'Message' field
	But no media file is selected
	Then the message 'This is a test message, generated automatically to test the Specflow scripts.' is added to the 'Message' field
	
	When I click on 'Save and Add More' button
	Then I land at the page 'The Wipfli Way - Add'

	When I add name 'Amit Agrawal' to the 'ToField' textbox
	And I select given name from the 'ToField' dropdown
	Then The given name 'Amit Agrawal' is shown in 'To' section
	
	When I enter message 'This is a test message, generated automatically to test the Specflow scripts.' into the 'Message' field
	But no media file is selected
	Then the message 'This is a test message, generated automatically to test the Specflow scripts.' is added to the 'Message' field
	
	When I click on 'Save and Close' button
	Then I land at the page 'The Wipfli Way - View'

Scenario: SLIA-125: Verify that as a user, I should be able to add an appreciation with a media file.

	Given User is at eAppreciation Home Page
	And User has logged in with Spider credentials 'Mayuresh Ahirrao'
	
	When I press add
	Then I land at the page 'The Wipfli Way - Add'
	And My name 'Mayuresh Ahirrao' is visible at the 'From' textbox 

	When I add name 'Bhushan Nalawade' to the 'ToField' textbox
	And I select given name from the 'ToField' dropdown
	Then The given name 'Bhushan Nalawade' is shown in 'To' section
	
	When I enter message 'This is a test message, generated automatically to test the Specflow scripts.' into the 'Message' field
	And Media file 'D:\Company Docs\Webinars\Scriptless Automation\click button actions.jpg' is selected
	Then the message 'This is a test message, generated automatically to test the Specflow scripts.' is added to the 'Message' field
	
	When I click on 'Save and Close' button
	Then I land at the page 'The Wipfli Way - View'

#
#| User             | Person To Appreciate | Appreciation Message                                                          | Save Action    | 
#| Mayuresh Ahirrao | Bhushan Nalawade     | This is a test message, generated automatically to test the Specflow scripts. | Save and Close |



