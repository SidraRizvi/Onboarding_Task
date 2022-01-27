Feature: Login
As a registered member
I need to login with correct credentials	

@Home
Scenario: I want to access Mars website

Given I Launch Chrome Browser
When I enter the Home URL 
And Presses Enter key
Then Homepage should be displayed
And Sign in link should appear on the Homepage
And Join Button should appear on the Homepage
    
@Home@Login
Scenario: When I enter correct credentials I should be successfully login In

Given I am on the SignIn page
When I enter "sidra_riz@yahoo.com" in username and "sid6638659" in password field
And I Click on Login Button
Then I should successfully login 	

@Home@Login
Scenario: When I check the Remember Me Checkbox my credentials details should be saved for future
   
Given I entered the correct credentials 
When I check the Remember me? Checkbox
And Click on Sign In button
Then Verify my credentials are showing up on next SignIn

@Home@Login
Scenario: When I enter Incorrect Credentials an error message should be displayed
   
 Given I enter <emailaddress> and <password> into the application
 When I click the Login Button
 Then I should be informed that login is unsuccessful by an <error message>
   
    | emailaddress              | password          | error message                    |
    | sidra_riz@yahoo.com       | 123456            | Invalid emailaddress or password |
    | sidra_riz@yahoo.com       | 67*5#sdd          | Invalid emailaddress or password |
    | adc_123@gmail.com         | sid6638659        | Invalid emailaddress or password |
    | sidra_riz@yahoo.com       |                   | password is mandatory            |
    |                           | sid6638659        | emailaddress is mandatory        |
    | sidra_riz@yahoo.com       | sid6628659        | Invalid emailaddress or password |
    | sidra-riz@yahoo.com       | sid6638659        | Invalid emailaddress or password |
    | $%#@#$sidra_riz@yahoo.com | %#*#**#sid6638659 | Invalid emailaddress or password |
    | SIDRA_RIZ@YAHOO.COM       | SID6638659        | Invalid emailaddress or password |      


	

