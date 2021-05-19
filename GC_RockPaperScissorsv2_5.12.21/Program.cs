using System;

namespace GC_RockPaperScissorsv2_5._12._21
{
    class Program
    {
        static void Main(string[] args)
        {
            bool keepPlaying = true;

            Console.WriteLine("Welcome to Rock, Paper, Scissors!");

            RandomPlayer playRandom = new RandomPlayer();  // creating an object of randomplayer
            RockPlayer playRock = new RockPlayer(); // creating an object of rock player

            HumanPlayer player1 = new HumanPlayer("player 1");
            //creating a human player which asks their name & stores it in the variable name player1

            while (keepPlaying)
            {

                RPSApp playGame = new RPSApp(player1, playRock, playRandom);  //creating an object of RPSApp

                RPS opponentSelection = playGame.ChooseOpponent(); //returns the rock/paper/scissors

                RPS playerSelection = player1.GenerateRPS();  // player1 selecting play & storing in a variable                       


                Console.WriteLine($"{player1.Name}: {playerSelection}\n{playGame.OpponentName}: {opponentSelection}");  // writing out the results of the two RPS events


                //if statements to determine winner

                if (playerSelection == RPS.rock && opponentSelection == RPS.paper)
                {
                    Console.WriteLine("You lose!");
                }
                else if (playerSelection == RPS.rock && opponentSelection == RPS.scissors)
                {
                    Console.WriteLine("You win!");
                }
                else if (playerSelection == RPS.paper && opponentSelection == RPS.scissors)
                {
                    Console.WriteLine("You lose");
                }
                else if (playerSelection == RPS.paper && opponentSelection == RPS.rock)
                {
                    Console.WriteLine("You win!");
                }
                else if (playerSelection == RPS.scissors && opponentSelection == RPS.rock)
                {
                    Console.WriteLine("You lose!");
                }
                else if (playerSelection == RPS.scissors && opponentSelection == RPS.paper)
                {
                    Console.WriteLine("You win!");
                }
                else
                {
                    Console.WriteLine("It's a draw!");
                }

                //do you want to continue?


                string userPlay = ValidateInput();
                                   
                if (userPlay == "y")
                {
                     keepPlaying = true;
                }
                else if (userPlay == "n")
                {
                      keepPlaying = false;
                }
                                                      
            }

        }

        public static string ValidateInput()
        {
            bool keepLooping = true;
            string input = "";


            while (keepLooping)
            {                
                Console.WriteLine("Do you want to play again? Y/N");
                input = Console.ReadLine().ToLower();

                if (input == "y")
                {
                    keepLooping = false;
                }
                else if (input == "n")
                {
                    keepLooping = false;
                }
                else
                {
                    Console.WriteLine("Invalid input.");
                    keepLooping = true;
                }

            } 

            return input;

        }
    }
}
