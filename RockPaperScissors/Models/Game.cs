using System.Collections.Generic;

namespace RockPaperScissors.Models
{
  public class Game
  {
    public Dictionary<string, string> Players;

    public Game(string player1, string player2)
    {

      Dictionary<string, string> _players = new Dictionary<string, string>(){};
      _players[player1.ToLower()] = "Player 1";
      _players[player2.ToLower()] = "Player 2";
      Players = _players;
    }

    public string DetermineResult()
    {
      string result = "";
      List<string> keysList = new List<string>(Players.Keys);
      
      if(keysList.Contains("paper") && keysList.Contains("rock"))
      {
        result = Players["paper"];
      }
      else if (keysList.Contains("scissors") && keysList.Contains("rock")) {
        result = Players["rock"];
      }
      else if (keysList.Contains("paper") && keysList.Contains("scissors")) {
        result = Players["scissors"];
      }
      else 
      {
        result = "Draw";
      }
      return result;
    }
  }
}