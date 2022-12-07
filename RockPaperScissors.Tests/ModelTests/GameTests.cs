using Microsoft.VisualStudio.TestTools.UnitTesting;
using RockPaperScissors.Models;

namespace ProjectName.Tests
{
  [TestClass]
  public class GameTests
  {
    [TestMethod]
    public void GameConstructor_CreateInstanceOfGame_Game()
    {      
      Game game = new Game("rock", "scisors");
      Assert.AreEqual(typeof(Game), game.GetType());
    }

    [TestMethod]
    public void GameConstructor_AssignPlayerValues_String()
    {
      string player1 = "rock";
      string player2 = "paper";
      Game game = new Game(player1, player2);
      Assert.AreEqual("Player 1", game.Players[player1]);
      Assert.AreEqual("Player 2", game.Players[player2]);
    }

    [TestMethod]
    public void DetermineResult_ItWillReturnTheWinnerForPaperVsRock_String()
    {
      string player1 = "Paper";
      string player2 = "Rock";
      Game game = new Game(player1, player2);
      string result = "Player 1";
      Assert.AreEqual(result, game.DetermineResult());
    }

    [TestMethod]
    public void DetermineResult_ItWillReturnTheWinnerForRockVsScissors_String()
    {
      string player1 = "Scissors";
      string player2 = "Rock";
      Game game = new Game(player1, player2);
      string result = "Player 2";
      Assert.AreEqual(result, game.DetermineResult());
    }

    [TestMethod]
    public void DetermineResult_ItWillReturnTheWinnerForPaperVsScissors_String()
    {
      string player1 = "Scissors";
      string player2 = "Paper";
      Game game = new Game(player1, player2);
      string result = "Player 1";
      Assert.AreEqual(result, game.DetermineResult());
    }

    [TestMethod]
    public void DetermineResult_ItWillReturnDrawForSimilarHands_String()
    {
      string player1 = "Scissors";
      string player2 = "Scissors";
      Game game = new Game(player1, player2);
      string result = "Draw";
      Assert.AreEqual(result, game.DetermineResult());
    }
  }
}