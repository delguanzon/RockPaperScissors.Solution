using System;
using RockPaperScissors.Models;

 public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to Rock, Paper, Scisors");
      Console.WriteLine("Player 1, enter your hand: ");
      string player1 = Console.ReadLine();
      Console.WriteLine("Player 2, enter your hand: ");
      string player2 = Console.ReadLine();

      Game game = new Game(player1, player2);

      if (game.DetermineResult() != "Draw"){
      Console.WriteLine("The winner is {0}", game.DetermineResult());
      } else {
        Console.WriteLine("It is a draw!");
      }
    }
  }