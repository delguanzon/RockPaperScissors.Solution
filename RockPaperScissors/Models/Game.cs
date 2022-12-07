namespace RockPaperScissors.Models
{
  public class Game
  {
    public string Player1 {get;}
    public string Player2 {get;}

    public Game(string player1, string player2)
    {
      Player1 = player1;
      Player2 = player2;
    }
  }
}