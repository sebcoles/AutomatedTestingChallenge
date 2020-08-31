# Automated Testing Challenge

Calculator Web is a buggy API and website of a calculator.

Your job is to complete the test suite to validate the functions. Validate both the API endpoints using a HttpClient and the website functionality using selenium.

There is an example of an API and web test included in the project.

You will need to install specflow visual studio extension to complete the acceptance tests. https://marketplace.visualstudio.com/items?itemName=TechTalkSpecFlowTeam.SpecFlowForVisualStudio

You will also need to download chrome web driver from https://chromedriver.chromium.org/downloads and place in 'C:\tools\'

**Calculator/Add**
    
    Scenario 1: Add Happy path
    Given I have the numbers 10 and 5
    When I submit my numbers to the Add API
    Then I should recieve a 200 OK
    And the number 15 should be in the response
    And I should recieve the response within 1 second

    Scenario 2: Add Sad path
    Given I have the letter 'A' and 'B'
    When I submit the letters to the Add API
    Then I should recieve a 400 Bad Request
    And the error should say 'Invalid Parameters A, B: Only numbers can be used in this request"

    Scenario 3: Add Security path
    Given I have the letter '<Script>alert("xss")</script>' and 'B'
    When I submit the letters to the Add API
    Then I should recieve a 400 Bad Request
    And the error should say 'Invalid Parameters &#x3C;Script&#x3E;alert(&#x22;xss&#x22;)&#x3C;/script&#x3E;, B: Only numbers can be used in this request"

**Calculator/Subtract**

    Scenario 1: Subtract Happy path
    Given I have the numbers 10 and 5
    When I submit my numbers to the Subtract API
    Then I should recieve a 200 OK
    And the number 5 should be in the response
    And I should recieve the response within 1 second

    Scenario 2: Subtract Sad path
    Given I have the letter 'A' and 'B'
    When I submit the letters to the Subtract API
    Then I should recieve a 400 Bad Request
    And the error should say 'Invalid Parameters A, B: Only numbers can be used in this request"


**Calculator/Multiply**

    Scenario 1: Multiply Happy path
    Given I have the numbers 10 and 5
    When I submit my numbers to the Multiply API
    Then I should recieve a 200 OK
    And the number 25 should be in the response
    And I should recieve the response within 1 second

    Scenario 2: Multiply Sad path
    Given I have the letter 'A' and 'B'
    When I submit the letters to the Multiply API
    Then I should recieve a 400 Bad Request
    And the error should say 'Invalid Parameters A, B: Only numbers can be used in this request"

**Calculator/Multiply**

    Scenario 1: Divide Happy path
    Given I have the numbers 10 and 5
    When I submit my numbers to Divide API
    Then I should recieve a 200 OK
    And the number 2 should be in the response
    And I should recieve the response within 1 second

    Scenario 2: Divide Sad path 1
    Given I have the letter 'A' and 'B'
    When I submit the letters to the Divide API
    Then I should recieve a 400 Bad Request
    And the error should say 'Invalid Parameters A, B: Only numbers can be used in this request"

    Scenario 3: Divide Sad path 2
    Given I have the number 10 and 0
    When I submit the letters to the Add API
    Then I should recieve a 400 Bad Request
    And the error should say 'Cannot divide by 0"
