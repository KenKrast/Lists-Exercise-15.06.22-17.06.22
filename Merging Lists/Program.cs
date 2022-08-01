using System;
using System.Collections.Generic;
using System.Linq;

namespace Merging_Lists

{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> numbers2 = Console.ReadLine().Split().Select(int.Parse).ToList();
            List<int> MergedNums = new List<int>();

            int listCount = Math.Max(numbers.Count, numbers2.Count);

            for (int i = 0; i < listCount; i++)
            {
                if (numbers.Count > i)
                {
                    MergedNums.Add(numbers[i]);
                }
                if (numbers2.Count > i)
                {
                    MergedNums.Add(numbers2[i]);
                }
            }

            Console.WriteLine(string.Join(" ", MergedNums));
        }
    }
}