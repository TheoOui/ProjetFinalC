using System;
using System.Collections.Generic;
using System.Text;
using TicTac
using TechTalk.SpecFlow;

using FluentAssertions;


namespace SpecFlowProject1.Specs.Steps
{
   public class TicTacToeStepsDefinitions
    {
        private TicTacToe _game;

        [Given(@"the game is not started")]
        public void GivenTheGameIsNotStarted()
        {
            _game = new TicTacToeGame();
        }

        [When(@"the player starts a new game")]
        public void WhenThePlayerStartsANewGame()
        {
            _game.StartNewGame();
        }

        [Then(@"the game board should be empty")]
        public void ThenTheGameBoardShouldBeEmpty()
        {
            var board = _game.GetGameBoard();
            for (var i = 0; i < board.GetLength(0); i++)
            {
                for (var j = 0; j < board.GetLength(1); j++)
                {
                    Assert.AreEqual(' ', board[i, j]);
                }
            }
        }

        [Given(@"the game is started")]
        public void GivenTheGameIsStarted()
        {
            _game = new TicTacToeGame();
            _game.StartNewGame();
        }

        [Given(@"it is the player's turn")]
        public void GivenItIsThePlayerSTurn()
        {
            Assert.AreEqual('X', _game.GetCurrentPlayerSymbol());
        }

        [Given(@"it is the other player's turn")]
        public void GivenItIsTheOtherPlayerSTurn()
        {
            Assert.AreEqual('O', _game.GetCurrentPlayerSymbol());
        }

        [Given(@"the selected cell is empty")]
        public void GivenTheSelectedCellIsEmpty()
        {
            Assert.AreEqual(' ', _game.GetCellValue(1, 1));
        }

        [Given(@"the selected cell is not empty")]
        public void GivenTheSelectedCellIsNotEmpty()
        {
            _game.MakeMove(1, 1);
        }

        [When(@"the player makes a valid move")]
        public void WhenThePlayerMakesAValidMove()
        {
            _game.MakeMove(1, 1);
        }

        [Then(@"the selected cell should be marked with the player's symbol")]
        public void ThenTheSelectedCellShouldBeMarkedWithThePlayerSSymbol()
        {
            Assert.AreEqual('X', _game.GetCellValue(1, 1));
        }

        [Then(@"it should be the other player's turn")]
        public void ThenItShouldBeTheOtherPlayerSTurn()
        {
            Assert.AreEqual('O', _game.GetCurrentPlayerSymbol());
        }

        [Then(@"the move should not be accepted")]
        public void ThenTheMoveShouldNotBeAccepted()
        {
            Assert.IsFalse(_game.IsMoveValid(1, 1));
        }

        [Then(@"it should still be the player's turn")]
        public void ThenItShouldStillBeThePlayerSTurn()
        {
            Assert.AreEqual('X', _game.GetCurrentPlayerSymbol());
        }

        [Given(@"the player makes a winning move")]
        public void GivenThePlayerMakesAWinningMove()
        {
            _game.MakeMove(0, 0);
            _game.MakeMove(1, 1);
            _game.MakeMove(0, 1);
            _game.MakeMove(1, 2);
            _game.MakeMove(0, 2);
        }

        [When(@"the player makes the winning move")]
        public void WhenThePlayerMakesTheWinningMove()
        {
            _game.MakeMove(2, 2);
        }

        [Then(@"the game should be over")]
        public void ThenTheGameShould
    }
}
