using System;

namespace Assignment3
{
    class RockPaperScissors
    {
        static void Main(string[] args)
        {
            bool again = true;

            do
            {
                Console.WriteLine($"Hello, welcome to Rock Paper Scissors. {Environment.NewLine}--------------{Environment.NewLine}You each start with 100 lifepoints. {Environment.NewLine}Rock: 20 damage. {Environment.NewLine}Scissors: 15 damage. {Environment.NewLine}Paper: 10 damage.{Environment.NewLine}--------------{Environment.NewLine}");
                // Human vs computer / Human vs Human / Computer vs computer
                Game game = new Game("human", "computer");

                Console.WriteLine($"-------------{Environment.NewLine}{game.winner} won the game!------------{Environment.NewLine}");
                Console.Write("Would you like to play again? (y/n): ");

                string goAgain = Console.ReadLine();

                switch (goAgain)
                {
                    case "y":
                        again = true;
                        break;
                    case "n":
                        again = false;
                        break;
                    default:
                        again = false;
                        break;
                }
            } while (again);
        }
    }
}
