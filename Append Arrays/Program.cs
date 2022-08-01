using System;
using System.Collections.Generic;
using System.Linq;

namespace AppendArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var inputArray = Console.ReadLine().Split('|').Reverse().ToList();
           List<int> numbers = new List<int>();
           foreach (var number in inputArray)
           {
               numbers.AddRange(number.Split(" ").Select(int.Parse).ToList());
           }
            Console.WriteLine(string.Join(" ", numbers));

        }
    }
}

