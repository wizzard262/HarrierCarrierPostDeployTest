Feature: Harrier Carrier Homepage

Scenario: Harrer Carrier logo loads correctly
    Given I am on the Harrier Carrier Homepage
    Then the image "assets/logo.png" should be visible

Scenario: Clicking Google Play button redirects correctly
    Given I am on the Harrier Carrier Homepage
    When I click the Google Play link
    Then I should be redirected to "https://play.google.com/store/apps/details?id=garmadon.harriercarriercoldwar"

Scenario: Clicking YouTube button redirects correctly
    Given I am on the Harrier Carrier Homepage
    When I click the YouTube link
    Then I should be redirected to "https://www.youtube.com/watch?v=cYc7CPjA33A&list=PLuCq6bBAV6WcZgNZGCp9w08pJYjjWH9J3"

Scenario: Clicking Play Now redirects correctly
    Given I am on the Harrier Carrier Homepage
    When I click the PlayNow link
    Then I should be redirected to "https://www.harriercarrier.com/game/index.htm"

Scenario: Clicking Poster redirects correctly
    Given I am on the Harrier Carrier Homepage
    When I click the Poster link
    Then I should be redirected to "https://www.harriercarrier.com/assets/harrier_carrier_poster.png"

Scenario: Clicking BattleOfHoth redirects correctly
    Given I am on the Harrier Carrier Homepage
    When I click the BattleOfHoth link
    Then I should be redirected to "https://www.harriercarrier.com/battleofhoth/index.html"
