Feature: Tic Tac Toe

  As a player
  I want to play Tic Tac Toe
  So that I can have fun and win the game

  Scenario: Start a new game
    Given the game is not started
    When the player starts a new game
    Then the game board should be empty

  Scenario: Player makes a valid move
    Given the game is started
    And it is the player's turn
    And the selected cell is empty
    When the player makes a valid move
    Then the selected cell should be marked with the player's symbol
    And it should be the other player's turn

  Scenario: Player makes an invalid move
    Given the game is started
    And it is the player's turn
    And the selected cell is not empty
    When the player makes a move on the selected cell
    Then the move should not be accepted
    And it should still be the player's turn

  Scenario: Player wins the game
    Given the game is started
    And it is the player's turn
    And the player makes a winning move
    When the player makes the winning move
    Then the game should be over
    And the player should be declared as the winner

  Scenario: Game ends in a draw
    Given the game is started
    And all cells are filled with valid moves
    When the last move is made
    Then the game should be over
    And no player should be declared as the winner