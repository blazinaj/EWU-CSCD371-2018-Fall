using System;
using System.Collections.Generic;
using System.Text;

namespace Assignment3
{
    public class Game
    {
        public string winner = "none";

        public Game(string playerOneType, string playerTwoType)
        {
            
            Player humanPlayer = new Player(playerOneType);
            Player computerPlayer = new Player(playerTwoType);
            
            do
            {
                string humanWeapon = humanPlayer.DrawWeapon();
                Console.WriteLine($"--------------{Environment.NewLine}You have drawn: {humanWeapon}");

                string computerWeapon = computerPlayer.DrawWeapon();
                Console.WriteLine($"The computer has drawn: {computerWeapon}{Environment.NewLine}{Environment.NewLine}");

                var t = new Tuple<string, string>(humanWeapon, computerWeapon);

                if (t.Compare("rock", "rock"))
                {
                    //do nothing
                    Console.WriteLine($"Nobody won this round! You: {humanPlayer.lifePoints} lifepoints. Opponent: {computerPlayer.lifePoints} lifepoints.");
                }
                else if (t.Compare("rock", "paper"))
                {
                    humanPlayer.lifePoints -= 10;
                    Console.WriteLine($"The computer has won this round! You: {humanPlayer.lifePoints} lifepoints. Opponent: {computerPlayer.lifePoints} lifepoints.");
                }
                else if (t.Compare("rock", "scissors"))
                {
                    computerPlayer.lifePoints -= 20;
                    Console.WriteLine($"You have won this round! You: {humanPlayer.lifePoints} lifepoints. Opponent: {computerPlayer.lifePoints} lifepoints.");
                }
                else if (t.Compare("paper", "rock"))
                {
                    computerPlayer.lifePoints -= 10;
                    Console.WriteLine($"You have won this round! You: {humanPlayer.lifePoints} lifepoints. Opponent: {computerPlayer.lifePoints} lifepoints.");
                }
                else if (t.Compare("paper", "paper"))
                {
                    //do nothing
                    Console.WriteLine($"Nobody won this round! You: {humanPlayer.lifePoints} lifepoints. Opponent: {computerPlayer.lifePoints} lifepoints.");
                }
                else if (t.Compare("paper", "scissors"))
                {
                    humanPlayer.lifePoints -= 15;
                    Console.WriteLine($"The computer has won this round! You: {humanPlayer.lifePoints} lifepoints. Opponent: {computerPlayer.lifePoints} lifepoints.");
                }
                else if (t.Compare("scissors", "rock"))
                {
                    humanPlayer.lifePoints -= 20;
                    Console.WriteLine($"The computer has won this round! You: {humanPlayer.lifePoints} lifepoints. Opponent: {computerPlayer.lifePoints} lifepoints.");
                }
                else if (t.Compare("scissors", "paper"))
                {
                    computerPlayer.lifePoints -= 15;
                    Console.WriteLine($"You have won this round! You: {humanPlayer.lifePoints} lifepoints. Opponent: {computerPlayer.lifePoints} lifepoints.");
                }
                else if (t.Compare("scissors", "scissors"))
                {
                    //do nothing
                    Console.WriteLine($"Nobody won this round! You: {humanPlayer.lifePoints} lifepoints. Opponent: {computerPlayer.lifePoints} lifepoints.");
                }
                else
                {
                    //do nothing
                }
                Console.WriteLine($"---------------{Environment.NewLine}");

                if (humanPlayer.lifePoints < 1)
                {
                    if (humanPlayer.computerController)
                    {
                        winner = "Computer Player 2";
                    }
                    else
                    {
                        winner = "Computer Player";
                    }
                }
                else if (computerPlayer.lifePoints < 1)
                {
                    if (humanPlayer.computerController)
                    {
                        winner = "Computer Player 1";
                    }
                    else
                    {
                        winner = "You, the human player";
                    }
                }

            } while (winner == "none");
        }
    }
}
