Feature: Check Collision


    Background:
        Given a dummy RequestModel exists:
            | name              | WallCollision | SelfCollision | OtherCollision |
            | RequestModelOne   | false         | false         | false          |
            | RequestModelTwo   | true          | false         | false          |
            | RequestModelThree | false         | true          | false          |
            | RequestModelFour  | false         | false         | true           |

    Scenario: Check Collision
        When I check the collision of the RequestModel RequestModelOne
        Then the collision should be false

