using System;

namespace ProjetFinal
{
    public class TicTacToe
    {
        private char[,] board; // grille de jeu
        private char currentPlayer; // joueur en cours
        private bool gameover; // statut de la partie

        public TicTacToe()
        {
            board = new char[3, 3]; // initialisation de la grille de jeu
            currentPlayer = 'X'; // le joueur X commence 
            gameover = false; // la partie n'a pas encore commencé
        }
        
        // permet de relancer une partie
        public void StartGame()
        {
            board = new char[3, 3]; // réinitialisation de la grille de jeu
            currentPlayer = 'X';  
            gameover = false; 
        }
        


        public void PlayMove(int x, int y)
        {
            if (gameover || board[x, y] != '\0')
                return; // si la partie est terminée ou la case est déjà occupée, on ne fait rien
            board[x, y] = currentPlayer; // placement du symbole du joueur en cours sur la case
            if (CheckWin()) // si le joueur en cours a gagné la partie
            {
                gameover = true; 
                return;
            }
            if (CheckDraw()) // si la partie est un match nul
            {
                gameover = true; // fin de la partie
                return;
            }
            currentPlayer = currentPlayer == 'X' ? 'O' : 'X'; 
        }

        public char GetCurrentPlayer()
        {
            return currentPlayer;
        }

        public char GetWinner()
        {
            if (!gameover)
                return '\0'; 
            return currentPlayer == 'X' ? 'O' : 'X'; 
        }

        public bool IsGameOver()
        {
            return gameover;
        }


        // permet de voir s'il y a matchnul
        public bool CheckDraw()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    if (board[i, j] == '\0')
                    {
                        return false; // s'il y a encore des cases vides, la partie n'est pas un match nul
                    }
                }
            }
            return true; // toutes les cases sont remplies et aucun joueur n'a gagné, la partie est un match nul
        }


        private bool CheckWin()
        {
            // vérification des lignes
            for (int i = 0; i < 3; i++)
            {
                if (board[i, 0] == board[i, 1] && board[i, 1] == board[i, 2] && board[i, 0] != '\0')
                    return true;
            }

            // vérification des colonnes
            for (int j = 0; j < 3; j++)
            {
                if (board[0, j] == board[1, j] && board[1, j] == board[2, j] && board[0, j] != '\0')
                    return true;
            }

            // vérification de la diagonale principale
            if (board[0, 0] == board[1, 1] && board[1, 1] == board[2, 2] && board[0, 0] != '\0')
                return true;

            // vérification de la diagonale secondaire
            if (board[0, 2] == board[1, 1] && board[1, 1] == board[2, 0] && board[0, 2] != '\0')
                return true;

            return false; 


        
        }
    }
}

