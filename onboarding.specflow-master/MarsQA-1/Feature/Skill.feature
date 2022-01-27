Feature: Skill
I want to add Skills to my profile
On adding them it should be reflected on his dashboard

@Home@Profile@SkillTab@AddNewSkill
Scenario: I want to add new Skills to my Profile and all the added Skills should be displayed on my Skill list
	      
    Given I am on Skill Tab of my Profile
    When I enter <SkillName> in txt box
    And I enter <SkillLevel> in dropdown
    And I Click Add Button 
    Then Verify the <Message> should be available on screen
    
  | SkillName         | SkillLevel               |       Message                                  |
  |                   | Choose Skill Level       | Please enter skill and experience level        |
  | Graphic Design    | Choose Skill Level       | Please enter skill and experience level        |
  |                   | Expert                   | Please enter skill and experience level        |
  | Graphic Design    | Beginner                 | Graphic Deign has been added to your skills    |
  | Digital Marketing | Beginner                 | Digital Marketing has been added to your skills|
  | Graphic Design    | Beginner                 | This skill already exist in your skill list    |
  | Graphic Design    | Intermediate             | Duplicated Data                                |
 


@Home@Profile@SkillTab@CancelSkill
Scenario: I want to Cancel the Add Skill request

Given I am on Add New Skill page
When I click the Cancel Button
Then Redirects Me to Skill Tab on Profile page

@Home@Profile@SkillTab@EditSkill
Scenario: I want to update my skills 

Given I am on the Skill tab on my Profile page
And I have Clicked the Edit Icon of the record to be edited
When I Enter the updated <Skill> OR <Level>
And Clicks the Update Button
Then Profile details should be updated
And <Message box> should be displayed saying the skill has been updated
  | SkillName      | SkillLevel         | Message                                       |
  | Graphic Design | Intermediate       | Graphic Deign has been updated to your skills |
  | Graphic Design | Intermediate       | This skill already exist in your skill list   |
  | Graphic Design | Choose Skill Level | Please enter skill and experience level       |
  |                | Expert             | Please enter skill and experience level       |
  | Graphic Design | Beginner           | Graphic Deign has been added to your skills    |
  
 
@Home@Profile@SkillTab@DeleteSkill
Scenario: I want to delete my previously added Skill

Given I am on the Skill tab on my Profile page
And I have Clicked the Delete Icon of the record to be deleted
When I Click the Delete Icon
Then Verify the record is deleted
And Message box should be displayed

@Home@Profile@SkillTab
Scenario: I should be able to view all added skills on my Profile page

Given I am on my Profile page after successfully Signed In
And Language Description form is available
When I Click on Skills Tab
Then My previously added Skills should be displayed
And Add new Button should be visible
And Edit/Delete Icons should be visible


 
 Scenario: I want to delete added Skill record and the record should not exist on deletion

  Given I Launched the application 
  And I Click Login link
  When I enter "sidra_riz@yahoo.com" in username and "sid6638659" in password field
  And I click on Login Button
  Then I should be directed to profile page     
  Given I am on Skill Tab of my Profile
  When I click Delete Icon of last added Skill
  Then verify that record has been deleted
 
 