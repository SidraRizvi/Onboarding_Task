Feature: Join

@Home@Join
Scenario: When I am on Join page and want to SignIn instead of creating an account then SignIn page should be available.
       
Given I am on Join page 
And Sign in link is available
When I Click on SignIn link
Then Directs me to the SignIn page

@Home@Join	 
Scenario: On filling my details on Joining form I should be registered successfully
     
   Given I Launched the application
   And I click on Join Button
   When I fill the form with <Firstname> <Lastname> <Emailaddress> <Password> and <Confirmpassword> 
   And Check the Terms and conditions box
   And I Click the Join button
   Then <Message> should be displayed
   And I should be directed to the SignIn page
        
      | Firstname | Lastname | Emailaddress        | Password   | Confirmpassword | Message                                                 |
      | 123456    | Rizvi    | sidra_riz@yahoo.com | sid6638659 | sid6638659      | Names must contain at least one letter                  |
      | #$%@#     | Rizvi    | sidra_riz@yahoo.com | sid6638659 | sid6638659      | Names must contain at least one letter                  |
      |           | Rizvi    | sidra_riz@yahoo.com | sid6638659 | sid6638659      | This is a required field                                |
      | 123$@^    | Rizvi    | sidra_riz@yahoo.com | sid6638659 | sid6638659      | Names must contain at least one letter                  |
      | Sidra     | Rizvi    | sidra_riz@yahoo.com | sid6638659 | sid6638659      | Registeration sucessful                                 |
      | Sidra     | Rizvi    | sidra_riz@yahoo.com | sid6638659 | sid6638659      | This name has already been used to register an account  |
      | Sidra     | 123456   | sidra_riz@yahoo.com | sid6638659 | sid6638659      | Names must contain at least one letter                  |
      | Sidra     | #$%@#    | sidra_riz@yahoo.com | sid6638659 | sid6638659      | Names must contain at least one letter                  |
      | Sidra     | 123$@^   | sidra_riz@yahoo.com | sid6638659 | sid6638659      | Names must contain at least one letter                  |
      | Sidra     |          | sidra_riz@yahoo.com | sid6638659 | sid6638659      | This is a required field                                |
      | Sidra     | Rizvi    | sidra_riz@yahoo.com | sid6638659 | sid6638659      | This email has already been used to register an account |
      | Sidra     | Rizvi    | abcd@123.com        | 123456     | 123456          | This email is not valid                                 |
      | Sidra     | Rizvi    | abcd123.com         | 123456     | 123456          | Please enter a valid email address                      |
      | Sidra     | Rizvi    |                     | 123456     | 123456          | This is a required field                                |
      | Sidra     | Rizvi    | sidra_riz@yahoo.com | 12345      | 12345           | Password must be at least 6 characters                  |
      | Sidra     | Rizvi    | sidra_riz@yahoo.com |            |                 | These fields are required                               |
      | Sidra     | Rizvi    | sidra_riz@yahoo.com | 1234567    | 123456          | password does not match password                        |
      | Sidra     | Rizvi    | sidr_riz@yahoo.com  | 123&*%     | 123&*%          | Registeration sucessful                                 |
      | Sidra     | Rizvi    | sidra_riz@yahoo.com | 123456     | 1234567         | Does not match password                                 |
 

@Home@ForgotmyPassword
 Scenario: When I forget my password then Forgot Password Link should be available to reset it
     
    Given I Click on Forgot password link
    And Email Verification page is loaded
    When I enter the valid email address
    And Click on Send Verification Email button
    Then password reset email should be sent
    And "Email has been sent" message should be displayed
    And Verify Email is delivered to the correct email address
   
@Home@ForgotmyPassword
Scenario: When I am on Forgot password page I should be directed to Sign in page on recalling password.
    
Given I am on Forgot password link
When I Click Remember your password link?
Then I should be directed to SignIn page
     
@Home@Profile@Signout
Scenario: When I click on Sign out I should be Successfully Sign out from the application
Given I am on Profile Page
And Sign Out page is available
When I Click Sign Out Button 
Then I should be Sign out successfully from the application
    



 
