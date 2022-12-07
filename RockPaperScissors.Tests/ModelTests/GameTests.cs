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
    public void GameConstructor_AssignPlayerValues_Sting()
    {
      string player1 = "Rock";
      string player2 = "Paper";
      Game game = new Game(player1, player2);
      Assert.AreEqual(player1, game.Player1);
      Assert.AreEqual(player2, game.Player2);
    }   

  }
}