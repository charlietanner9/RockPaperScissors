using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RockPaperScissors
{
    class Program
    {
        static void Main(string[] args)
        {
            int userWins = 0;
            int oppWins = 0;
            string r = "y";

            while (r == "y")
            {
                //Get user selection
                Console.WriteLine("ROCK PAPER SCISSORS");
                Console.WriteLine("Enter 1 for rock, 2 for paper, 3 for scissors: ");
                int userSelection = int.Parse(Console.ReadLine());

                //Generate opponent selection
                Random random = new Random();
                int opponentChoice = random.Next(1, 4);

                //Determine a winner
                switch (opponentChoice)
                {
                    case 1:
                        if (userSelection == 1)
                        {
                            Console.WriteLine("You both chose rock! It's a tie!");
                        }
                        else if (userSelection == 2)
                        {
                            Console.WriteLine("You win! Opponent chose rock!");
                            userWins += 1;
                        }
                        else if (userSelection == 3)
                        {
                            Console.WriteLine("Opponent wins! Opponent chose rock!");
                            oppWins += 1;
                        }
                        break;
                    case 2:
                        if (userSelection == 1)
                        {
                            Console.WriteLine("Opponent wins! Opponent chose paper!");
                            oppWins += 1;
                        }
                        else if (userSelection == 2)
                        {
                            Console.WriteLine("You both chose paper! It's a tie!");
                        }
                        else if (userSelection == 3)
                        {
                            Console.WriteLine("You win! Opponent chose paper!");
                            userWins += 1;
                        }
                        break;
                    case 3:
                        if (userSelection == 1)
                        {
                            Console.WriteLine("You win! Opponent chose scissors!");
                            userWins += 1;
                        }
                        else if (userSelection == 2)
                        {
                            Console.WriteLine("You lose! Opponent chose scissors!");
                            oppWins += 1;
                        }
                        else if (userSelection == 3)
                        {
                            Console.WriteLine("It's a tie! You both chose scissors!");
                        }
                        break;


                }

                Console.WriteLine("Wins: " + userWins + " | Losses: " + oppWins);
                Console.WriteLine("Play again? (y/n): ");
                r = Console.ReadLine();
            }

           



        }
    }
}
