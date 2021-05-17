using System;
using _3SumConsoleApp.Models;

namespace _3SumConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new[] { -1, 0, 1, 2, -1, -4 };
            var result = SuperArray.GetThreeSum(numbers);

            foreach (var outer in result)
            {
                Console.Write("[");

                foreach (var inner in outer)
                {
                    Console.Write($"{inner},");
                }

                Console.Write("]");
            }
        }
    }
}
