using System;
using System.Collections.Generic;
using System.Linq;

namespace RemoveNegativesAndReverse
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbersList = Console.ReadLine().Split().Select(int.Parse).ToList();
            numbersList.RemoveAll(number => number < 0);

            numbersList.Reverse();

            if (numbersList.Count > 0)
            {
                Console.WriteLine(string.Join(" ", numbersList));
                return;
            }

            Console.WriteLine("empty");
        }
    }
}