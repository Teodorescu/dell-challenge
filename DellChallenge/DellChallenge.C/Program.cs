using System;
using DellChallenge.C.Extensions;

namespace DellChallenge.C
{
    class Program
    {
        static void Main(string[] args)
        {
            // Please refactor the code below whilst taking into consideration the following aspects:
            //      1. clean coding
            //      2. naming standards
            //      3. code reusability, hence maintainability

            int number1 = 1; //Convert.ToInt32(Console.ReadLine());
            int number2 = 3; //Convert.ToInt32(Console.ReadLine());
            int number3 = 5; //Convert.ToInt32(Console.ReadLine());

            ShowSum(number1, number2);
            ShowSum(number1, number2, number3);

            Console.ReadKey();
        }

        //

        private static void ShowSum(int number1, int number2, int number3 = 0)
        {
            int sum = MyMath.Sum(number1, number2, number3);
            Console.WriteLine(sum);
        }
    }
}
