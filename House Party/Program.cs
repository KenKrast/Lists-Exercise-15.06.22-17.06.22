using System;
using System.Collections.Generic;
using System.Linq;

namespace HouseParty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num = int.Parse(Console.ReadLine());
            var listOfNames = new List<string>();
            for (int i = 0; i < num; i++)
            {
                var command = Console.ReadLine().Split();
                var currName = command[0];
                if (listOfNames.Contains(currName) && command[2] == "going")
                {
                    Console.WriteLine($"{currName} is already in the list");
                }
                else if (listOfNames.Contains(currName) && command[2] == "not")
                {
                    listOfNames.Remove(currName);
                }
                else if (!listOfNames.Contains(currName) && command[2] == "not")
                {
                    Console.WriteLine($"{currName} is not on the list!");
                }
                else
                {
                    listOfNames.Add(currName);
                }

            }

            foreach (var curName in listOfNames)
            {
                Console.WriteLine(curName);
            }
        }
    }
}