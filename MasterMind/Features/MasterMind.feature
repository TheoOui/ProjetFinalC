
Feature: Mastermind

  
    En tant que joueur, je veux jouer au jeu MasterMind et gagner une partie ( trouver la combinaison secrète ) 
    On a 10 tentatives
    On part du principe qu'il y a 5 couleurs différentes et 4 boules à placer
    On joue contre l'ordinateur ( IA ) 

    

    Scenario: Deviner la combinaison en 10 essais maximum
        Given une combinaison secrète de 4 couleurs choisies par l'ordinateur parmi 5 couleurs possibles
        And le joueur a 10 essais maximum pour deviner la combinaison secrète
        When le joueur propose une combinaison de 4 couleurs
        Then l'ordinateur fournit une réponse qui indique :
        | Résultat              | Signification                                  |
        |-----------------------|-----------------------------------------------|
        | 4 couleurs bien placées | Le joueur a trouvé une couleur à la bonne place |
        | X couleurs bonnes       | Le joueur a trouvé X couleurs correctes, mais pas à la bonne place |
        | Aucune couleur trouvée | Le joueur n'a pas trouvé de couleur correcte    |
        And si le joueur a trouvé la combinaison secrète, il a gagné la partie
        And si le joueur n'a pas trouvé la combinaison secrète après 10 essais, il a perdu la partie

