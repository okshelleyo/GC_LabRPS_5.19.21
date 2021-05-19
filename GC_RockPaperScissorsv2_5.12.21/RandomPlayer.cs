using System;
using System.Collections.Generic;
using System.Text;

namespace GC_RockPaperScissorsv2_5._12._21
{
    class RandomPlayer : IPlayer
    {
        public string Name { get; set; }

        //Default Constructor
        public RandomPlayer()
        {
            Name = "Dog";
            
        }

        
        //Methods
        public RPS GenerateRPS()
        {
            //generate & return a RPS
            Random random = new Random();

            Type type = typeof(RPS);
            Array values = type.GetEnumValues();
            int index = random.Next(values.Length);

            RPS value = (RPS)values.GetValue(index);
            return value;
        }

       
    }
}
