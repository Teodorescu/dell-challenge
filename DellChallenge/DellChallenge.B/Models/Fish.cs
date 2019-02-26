using System;
using DellChallenge.B.Models.Base;

namespace DellChallenge.B.Models
{
    class Fish : Species
    {        
        public override void Show()
        {            
            Eat();
            Swim();
            Drink(); //Only salt water fish drink water.
            Console.WriteLine();
        }
    }
}
