using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SpecFlowTicTacToe;
using TechTalk.SpecFlow;
using FluentAssertions;
using ProjetFinal;
using NUnit.Framework;




namespace SpecFlowTicTacToe.Specs.Steps
{
    [Binding]
   public sealed class TicTacToeStepDefinitions
    {
        private readonly ScenarioContext _scenarioContext;
        private TicTacToe game;
        private char currentPlayer;
        private char[,] currentBoard;

       public TicTacToeStepDefinitions(ScenarioContext scenarioContext)
        {
            _scenarioContext = scenarioContext;
            game = new TicTacToe();
            currentBoard = new char[3, 3];
        }


        [Given("une nouvelle partie")]
        public void GivenUneNouvellePartie()
        {
            game = new TicTacToe();
            currentPlayer = 'X';
            currentBoard = new char[3, 3];
        }

        [When(@"le joueur (.*) joue en \((.*),(.*)\)")]
        public void WhenLeJoueurJoueEn(char player, int row, int column)
        {
            game.PlaceSymbol(player, row - 1, column - 1);
            currentPlayer = (currentPlayer == 'X') ? 'O' : 'X';
            currentBoard[row - 1, column - 1] = player;
        }

        [Then(@"la grille de jeu est vide")]
        public void ThenLaGrilleDeJeuEstVide()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 3; j++)
                {
                    Assert.AreEqual('\0', game.board[i, j]);
                }
            }
        }

        [Then(@"la grille de jeu contient un symbole (.*) en \((.*),(.*)\)")]
        public void ThenLaGrilleDeJeuContientUnSymbole(char symbol, int row, int column)
        {
            Assert.AreEqual(symbol, game.board[row - 1, column - 1]);
        }

        [Then(@"c'est au joueur (.*) de jouer")]
        public void ThenCestAuJoueurDeJouer(char player)
        {
            Assert.AreEqual(player, currentPlayer);
        }

        [Then(@"le joueur (.*) remporte la partie")]
        public void ThenLeJoueurRemporteLaPartie(char player)
        {
            Assert.AreEqual(player, game.GetWinner());
        }

        [Then(@"la partie est nulle")]
        public void ThenLaPartieEstNulle()
        {
            Assert.IsNull(game.GetWinner());
        }






    }
}
