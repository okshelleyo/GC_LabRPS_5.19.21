using System;
using System.Collections.Generic;
using System.Text;

namespace GC_RockPaperScissorsv2_5._12._21
{
    class RPSApp
    {
        public HumanPlayer HumanPlayer { get; set; }
        public RockPlayer RockPlayer { get; set; }
        public RandomPlayer RandomPlayer { get; set; }
        public string OpponentName { get; set; }
                
        public RPSApp(HumanPlayer humanPlayer, RockPlayer rockPlayer, RandomPlayer randomPlayer)
        {
            HumanPlayer = humanPlayer;
            RockPlayer = rockPlayer;
            RandomPlayer = randomPlayer;
            
        }

        public string UserSelection()
        {
            bool keepLooping = true;
            string input = "";
            
            while (keepLooping)
            {
                Console.WriteLine("Who do you want to play? Cat or Dog?");
                input = Console.ReadLine().Trim().ToLower();
                if (input == "cat")
                {
                    keepLooping = false;
                    OpponentName = RockPlayer.Name;

                } else if (input == "dog")
                {
                    keepLooping = false;
                    OpponentName = RandomPlayer.Name;
                } else
                {
                    Console.WriteLine("Invalid input.");
                    keepLooping = true;
                }
                                
            } 

            return input;

        }


        public RPS ChooseOpponent()
        {
            RPS opponentSelection;
                                 
            if (UserSelection() == "cat")
            {                
                opponentSelection = RockPlayer.GenerateRPS();   //rock selecting play & storing it in a variable

            }
            else 
            {
                opponentSelection = RandomPlayer.GenerateRPS();
            }                       

            return opponentSelection;
                       
        }
                        
    }
}
