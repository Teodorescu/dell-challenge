using System;
using DellChallenge.B.Models;

namespace DellChallenge.B
{
    class Program
    {
        static void Main(string[] args)
        {
            // Given the classes and interface below, please constructor the proper hierarchy.
            // Feel free to refactor and restructure the classes/interface below.
            // (Hint: Not all species can Fly and/or Swim)

            var human = new Human();
            human.Show();
            human.GetSpecies();
            human.CheckSpecies(Console.ReadLine());

            var bird = new Bird();
            bird.Show();
            bird.GetSpecies();
            bird.CheckSpecies(Console.ReadLine());

            var fish = new Fish();
            fish.Show();
            fish.GetSpecies();
            fish.CheckSpecies(Console.ReadLine());

            Console.ReadLine();            
        }
    }
}

