using System;
using System.Collections.Generic;
using System.Text;

namespace GC_RockPaperScissorsv2_5._12._21
{
    class HumanPlayer : IPlayer
    {
        private string name;
        public string Name { get { return name; } set { name = value; } }


        public HumanPlayer(string _name)
        {
            name = HumanPlayer.AskUserName();
        }

        //Methods
        public RPS GenerateRPS()
        {
            bool keepLooping = true;
            RPS playerSelection = RPS.scissors;


            while (keepLooping)
            {
                Console.WriteLine("Do you want to play rock, paper, or scissors?");
                string input = Console.ReadLine().Trim().ToLower();
                bool isValid = Enum.TryParse<RPS>(input, true, out playerSelection);

                if (isValid == true && playerSelection == RPS.paper)
                {
                    keepLooping = false;
                }
                else if (isValid == true && playerSelection == RPS.rock)
                {
                    keepLooping = false;
                }
                else if (isValid == true && playerSelection == RPS.scissors)
                {
                    keepLooping = false;
                }
                else
                {
                    keepLooping = true;
                }
            }

            return playerSelection;
        }

        public static string AskUserName()
        {
            Console.Write("Enter your name: ");
            string name = Console.ReadLine();
            return name;
        }
    }
}
