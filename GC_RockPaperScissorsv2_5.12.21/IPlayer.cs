using System;
using System.Collections.Generic;
using System.Text;

namespace GC_RockPaperScissorsv2_5._12._21
{
    interface IPlayer
    {
        
        public string Name { get; set; }

        //Method
        public RPS GenerateRPS();


    }
}
