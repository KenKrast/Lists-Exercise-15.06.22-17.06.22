using System;
using System.Collections.Generic;
using System.Linq;

namespace ChangeList
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine().Split().Select(int.Parse).ToList();
            string command = Console.ReadLine();
            while (command != "end")
            {
                string[] tokens = command.Split().ToArray();
                string order = tokens[0];
                if (order == "Delete")
                {
                    int element = Convert.ToInt32(tokens[1]);
                    input.RemoveAll(el => el == element);
                }
                else if (order == "Insert")
                {
                    int element = Convert.ToInt32(tokens[1]);
                    int index = Convert.ToInt32(tokens[2]);
                    input.Insert(index, element);
                }
                command = Console.ReadLine();
            }
            Console.WriteLine(string.Join(" ", input));

        }

    }
}