Feature: Check Collision


Background: 
    Given a dummy RequestModel exists:
        | id | name | description | price | quantity |
 
Scenario: Check Collision
    Given I have a RequestModel
    When I check the collision
    Then I should get a collision result

    