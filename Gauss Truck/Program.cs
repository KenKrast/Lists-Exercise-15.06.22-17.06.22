using System;
using System.Collections.Generic;
using System.Linq;

namespace Gauss_Truck
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> gaussNumbers = new List<int>();

            int numbersLenght = numbers.Count;
            for (int i = 0; i < numbersLenght / 2; i++)
            {
                int currGaussNumbers = (numbers[i] + numbers[numbers.Count - 1 - i]);
                gaussNumbers.Add(currGaussNumbers);
            }

            if (numbers.Count % 2 != 0)
            {
                gaussNumbers.Add(numbers[numbers.Count / 2]);
            }

            Console.WriteLine(string.Join(" ", gaussNumbers));
        }
    }
}