Feature: Language
I want to add language details to my Profile
I should be able to view the added details on visiting my Profile

@Home@Login@Profile
Scenario: I want to access Language Tab 
Given I have registered myself
And I have signed in successfully
And On Profile Page Language Tab is selected by default
When I click on Language Tab
Then Add New Button should be visible
And I should be able to see my previously added Languages on the page

@Home@Profile@LanguageTab@AddNewLanguage
Scenario: I want to add new Language to my Profile

Given I am on Language Tab of my Profile Page
And My previously added Skills are listed below and Add Language Textbox, Choose Language Level Dropdown, Add and Cancel Buttons are visible
When I enter <Add Language> in the Textbox and selects any <Language Level> from Dropdown List
And I Click Add Button 
Then Verify that the Skill has been added successfully to my Skillset
And <Message box> should be displayed
And Message box should disappear within 3 seconds
And Add New Button should be visible for adding another language  

	| Add Language | Language Level | Mesage Box                                           |
	| English      | Basic          | English has been added to your languages             |
	| English      | Conversational | Duplicated Data                                      |
	| English      | Fluent         | Duplicated Data                                      |
	| English      | Native         | Duplicated Data                                      |
	| English      | Basic          | This laguage is already exists in your language list |
	| French       | Basic          | French has been added to your languages              |

 
@Home@Profile@LanguageTab@CancelLanguage
Scenario: I want to Cancel the Add Language request

Given I am on Add New Language page
When I click the Cancel Button
Then Redirects Me to Language Tab on Profile page

@Home@Profile@LanguageTab@EditLanguage
Scenario: I want to update my Language level

Given I am on the Language tab on my Profile page
And I have Clicked the Edit Icon of the record to be edited
When I Enter the updated <Language> OR <Level>
And I Click the Update Button
Then Profile details should be updated
And <Message box> should be displayed 

	| Language | Language Level | Mesage Box                                           |
	|          |                | Please enter language and experience level           |
	| English  |                | Please enter language and experience level           |
	|          | Fluent         | Please enter language and experience level           |
	| English  | Fluent         | English has been added to your languages             |
	| French   | Fluent         | French has been added to your languages              |
	| English  | Fluent         | This laguage is already exists in your language list |
	| French   | Fluent         | Duplicated Data                                      |

	 
@Home@Profile@LanguageTab
 Scenario: The Add New Button should disappear on entering the fourth Language 

Given I am on the Add New Button Tab
When I Enter the fourth Language
Then Verify the Add New Button disappear 

@Home@Profile@LanguageTab@DeleteLanguage
Scenario: I want to delete my previously added Language

Given I am on the Language tab on my Profile page
And I have Clicked the Delete Icon of the record to be deleted
When I Click the Delete Icon
Then Verify the record is deleted
And Message box should be displayed

@Home@Profile@LanguageTab
Scenario: I should be able to view all added languages on my Profile page

Given I have entered the correct credentials
When I logged in the application
Then Language Tab should be active by default
And My previously added Language should be displayed
