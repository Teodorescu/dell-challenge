using System;
using DellChallenge.B.Interfaces;

namespace DellChallenge.B.Models.Base
{
    class Species : ISpecies
    {
        public virtual void GetSpecies()
        {
            Console.WriteLine($"What species am I? (human / bird / fish)");
        }

        public virtual void Eat()
        {
            Console.Write("I can eat. ");
        }

        public virtual void Drink()
        {
            Console.Write("I can drink. ");
        }

        public virtual void Fly()
        {
            Console.Write("I can fly. ");
        }

        public virtual void Swim()
        {
            Console.Write("I can swim. ");
        }

        public virtual void CheckSpecies(string species)
        {
            var className = this.GetType().Name;
            var equal = String.Equals(className, species, StringComparison.CurrentCultureIgnoreCase);
            Console.WriteLine(equal ? "Yes" : "No");
        }

        public virtual void Show()
        {            
            Eat();
            Drink();
            Fly();
            Swim();
            Console.WriteLine();
        }
    }
}
