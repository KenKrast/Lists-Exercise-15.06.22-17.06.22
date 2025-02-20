﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace BombNumbers
{
    class Program
    {
        public static void Main(string[] args)
        {
            var numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            var tokens = Console.ReadLine().Split().Select(int.Parse).ToArray();
            var bombNumber = tokens[0];
            var power = tokens[1];
            for (int i = 0; i < numbers.Count; i++)
            {
                int target = numbers[i];
                if (target == bombNumber)
                {
                    BombNumber(numbers, power, i);
                }
            }

            Console.WriteLine(numbers.Sum());
        }

        static void BombNumber(List<int> numbers, int power, int index)
        {
            int start = Math.Max(0, index - power);
            int end = Math.Min(numbers.Count - 1, index + power);
            for (int i = start; i <= end; i++)
            {
                numbers[i] = 0;
            }
        }

    }
}