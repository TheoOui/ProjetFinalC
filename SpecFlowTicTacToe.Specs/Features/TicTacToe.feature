Feature: TicTacToe
 

 En tant que joueur je veux jouer au morpion (TicTacToe) et gagner une partie 
 

  
  Scenario: Nouvelle partie
    Given une nouvelle partie
    Then la grille de jeu est vide
    And c'est au joueur X de jouer

  Scenario: Placement d'un symbole
    Given une nouvelle partie
    When le joueur X joue en (1,1)
    Then la grille de jeu contient un symbole X en (1,1)
    And c'est au joueur O de jouer

  Scenario: Victoire en ligne
    Given une nouvelle partie
    When le joueur X joue en (1,1)
    And le joueur O joue en (2,1)
    And le joueur X joue en (1,2)
    And le joueur O joue en (2,2)
    And le joueur X joue en (1,3)
    Then le joueur X remporte la partie

  Scenario: Victoire en colonne
    Given une nouvelle partie
    When le joueur X joue en (1,1)
    And le joueur O joue en (1,2)
    And le joueur X joue en (2,1)
    And le joueur O joue en (2,2)
    And le joueur X joue en (3,1)
    Then le joueur X remporte la partie

  Scenario: Victoire en diagonale
    Given une nouvelle partie
    When le joueur X joue en (1,1)
    And le joueur O joue en (1,2)
    And le joueur X joue en (2,2)
    And le joueur O joue en (2,1)
    And le joueur X joue en (3,3)
    Then le joueur X remporte la partie

  Scenario: Match nul
    Given une nouvelle partie
    When le joueur X joue en (1,1)
    And le joueur O joue en (1,2)
    And le joueur X joue en (1,3)
    And le joueur O joue en (2,1)
    And le joueur X joue en (2,3)
    And le joueur O joue en (2,2)
    And le joueur X joue en (3,1)
    And le joueur O joue en (3,3)
    And le joueur X joue en (3,2)
    Then la partie est nulle


