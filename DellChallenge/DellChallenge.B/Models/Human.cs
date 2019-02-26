using System;
using DellChallenge.B.Models.Base;

namespace DellChallenge.B.Models
{
    class Human : Species
    {
        //public override void Fly()
        //{
        //    Console.Write("I can fly at low cost, normal or business class. ");
        //}

        public override void Show()
        {            
            Eat();
            Drink();
            Swim();
            //Fly();
            Console.WriteLine();
        }
    }
}
