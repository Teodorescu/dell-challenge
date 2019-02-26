using System;
using DellChallenge.B.Models.Base;

namespace DellChallenge.B.Models
{
    class Bird : Species
    {
        public override void Show()
        {            
            Eat();
            Drink();
            Fly();
            Console.WriteLine();
        }
    }
}
