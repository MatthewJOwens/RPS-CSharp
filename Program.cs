using System;

namespace RPS_CSharp
{
  class Program
  {
    static void Main(string[] args)
    {
      Console.WriteLine("Welcome to RPS-CSharp! Play a game? Y/N");
      string startGame = Console.ReadLine();
      bool playing = startGame.ToLower() == "y" || startGame.ToLower() == "yes";
      int playerWins = 0;
      int playerLosses = 0;
      int playerDraws = 0;
      while (playing)
      {
        Console.WriteLine("Rock, Paper, or Scissors?");
        string userChoice = Console.ReadLine();
        bool playsRock = userChoice.ToLower() == "rock";
        bool playsPaper = userChoice.ToLower() == "paper";
        bool playsScissors = userChoice.ToLower() == "scissors";
        Random random = new Random();
        int opponentPlays = random.Next(1, 3);
        string[] choices = { "rock", "paper", "scissors" };
        string opponentChoice = choices[opponentPlays];
        var results = "";
        if (playsRock && opponentChoice == "rock")
        {
          playerDraws++;
          results = "Tie";
        }
        else if (playsRock && opponentChoice == "paper")
        {
          playerLosses++;
          results = "Lose";
        }
        else if (playsRock && opponentChoice == "scissors")
        {
          playerWins++;
          results = "Win";

        }
        if (playsPaper && opponentChoice == "rock")
        {
          playerWins++;
          results = "Win";

        }
        else if (playsPaper && opponentChoice == "paper")
        {
          playerDraws++;
          results = "Draw";

        }
        else if (playsPaper && opponentChoice == "scissors")
        {
          playerLosses++;
          results = "Lose";

        }
        if (playsScissors && opponentChoice == "rock")
        {
          playerLosses++;
          results = "Lose";

        }
        else if (playsScissors && opponentChoice == "paper")
        {
          playerWins++;
          results = "Win";

        }
        else if (playsScissors && opponentChoice == "scissors")
        {
          playerDraws++;
          results = "Tie";
        }
        if (!playsRock && !playsPaper && !playsScissors)
        {
          Console.WriteLine("No cheating! Try again.");
          continue;
        }
        Console.WriteLine($"Opponent plays {opponentChoice}! {results}! W-{playerWins} L-{playerLosses} D-{playerDraws} Play again?");
        string playAgain = Console.ReadLine();
        if (playAgain.ToLower() == "y" || playAgain.ToLower() == "yes")
        {
          continue;
        }
        else
        {
          playing = false;
          Console.WriteLine("Thanks for playing!");
        }
      }
    }
  }
}
