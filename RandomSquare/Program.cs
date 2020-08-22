using System;
using System.Collections.Generic;
using System.Linq;

namespace RandomSquare
{
    class Program
    {
        static void Main(string[] args)
        {
            var randomNumbers = new List<int>();
            
            for (int i = 0; i <= 20; i++)
            {
                randomNumbers.Add(new Random().Next(1, 50));
            }

            var squaredNumbers = randomNumbers.Select(number => number * number);

            var onlyEvenSquaredNumbers = squaredNumbers.Where(number => number % 2 == 0);

            foreach (var x in onlyEvenSquaredNumbers)
            {
                Console.WriteLine(x);
            }
        }
    }
}
