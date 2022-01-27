Feature: Education
I want to add, edit and delete Education details to his profile
On adding them it should be reflected on his dashboard

@Home@Profile@SkillTab
Scenario: I should be able to view all added skills on my Profile page

Given I am on my Profile page after successfully Signed In
And Language Description form is available
When I Click on Skills Tab
Then My previously added Skills should be displayed
And Add new Button should be visible
And Edit/Delete Icons should be visible

@Home@SignIn@Profile
Scenario: I want to access Education Tab 
Given I have registered myself
And I have signed in successfully
And On Profile Page Language Tab is selected by default
When I click on Education Tab
Then Add New Button should be visible
And I should be able to see my previously added Education on the page

@Home@Profile@EducationTab@AddNewEducation
Scenario: I want to add new Education to my Profile
Given I am on Education Tab of my Profile Page
And My previously added Educational Background are listed below
When I enter <College/University Name> in the Textbox and selects <Country of University>
And I enter <Title> from Dropdown <degree> in Textbox <Year of Graduation> from Dropdown
And I Click Add Button 
Then Verify that the education details have been added successfully to my Skillset
And <Message box> should be displayed
And Message box should disappear within 3 seconds
And Add New Button should be visible for adding another 
		
	| University | Country     | Title  | Degree   | Graduation Year | Message                            |
	| Massey     | New Zealand |MBA     | Bachelor | 2015            | Education has been added           |
	|            | New Zealand |B.E     | Bachelor | 2020            | Please enter all the fields        |
	| Massey     | New Zealand |BA      | Bachelor | 2018            | This information is already exist. |
	| Massey     | New Zealand |MBA     | Bachelor | 2015            | Duplicated data                    |
	
@Home@Profile@EducationTab@EditEducation
Scenario: Update Education in my Profile details
		Given I click on Edit icon
		When  I enter <University>, <Country>, <Title>, <Degree>, <Graduation Year>
		And click on Update button
		Then I should see the message <Message> 
		And updated details <University>, <Country>, <Title>, <Degree>, <Graduation Year> should see on my profile page
		
	| University | Country     | Title | Degree   | Graduation Year | Message                            |
	| Massey     | New Zealand | B.A   | Master   | 2018            | Education has been updated         |
	| Massey     | New Zealand | B.A   | Master   | 2018            | This information is already exist. |
  	
 @Home@Profile@EducationTab@CancelEducation
Scenario: I want to Cancel the AddEduaction request
Given I am on Add Education page
When I click the Cancel Button
Then Redirects Me to Education Tab on Profile page
	

@Home@Profile@SkillTab@DeleteEducation
Scenario: I want to delete my previously added Education details
Given I am on the Education tab on my Profile page
And I have Clicked the Delete Icon of the record to be deleted
When I Click the Delete Icon
Then Verify the record is deleted
And Message box should be displayed

@Home@Profile@EducationTab
Scenario: I should be able to view all added education details on my Profile page

Given I am on my Profile page after successfully Signed In
And Language Description form is available
When I Click on Education Tab
Then My previously added Education details should be displayed
And Add new Button should be visible
And Edit/Delete Icons should be visible

