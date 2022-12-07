using System.Collections.Generic;

namespace RockPaperScissors.Models
{
  public class Game
  {
    public Dictionary<string, string> Players;

    public Game(string player1, string player2)
    {
      
      Dictionary<string, string> _players = new Dictionary<string, string>(){};
      _players[player1] = "Player 1";
      _players[player2] = "Player 2";
      Players = _players;
      
    }

    public string DetermineResult()
    {
      string result = "";
      List<string> keysList = new List<string>(Players.Keys);
      
      if(keysList.Contains("Paper") && keysList.Contains("Rock"))
      {
        result = Players["Paper"];
      }
      else if (keysList.Contains("Scissors") && keysList.Contains("Rock")) {
        result = Players["Rock"];
      }
      else if (keysList.Contains("Paper") && keysList.Contains("Scissors")) {
        result = Players["Scissors"];
      }
      else 
      {
        result = "Draw";
      }
      return result;
    }
  }
}