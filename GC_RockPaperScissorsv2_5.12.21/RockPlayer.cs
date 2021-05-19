using System;
using System.Collections.Generic;
using System.Text;

namespace GC_RockPaperScissorsv2_5._12._21
{
    class RockPlayer : IPlayer
    {
        public string Name { get; set; }

        //Constructor
        public RockPlayer()
        {
            Name = "Cat";                   
        }

        //Methods
        public RPS GenerateRPS()
        {
            //generate & return a RPS

            RPS value = RPS.rock;
            return value;
            
        }

        
        
    }
}
