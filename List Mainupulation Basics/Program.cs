using System;
using System.Collections.Generic;
using System.Linq;

namespace ListManipulationBasics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> numbers = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (true)
            {
                string command = Console.ReadLine();
                if (command == "end")
                {
                    break;
                }

                string[] orders = command.Split();
                string action = orders[0];

                switch (action)
                {
                    case "Add":
                        int AddNumber = int.Parse(orders[1]);
                        numbers.Add(AddNumber);
                        break;
                    case "Remove":
                        int RemoveNumber = int.Parse(orders[1]);
                        numbers.Remove(RemoveNumber);
                        break;
                    case "RemoveAt":
                        int RemoveAtNumber = int.Parse(orders[1]);
                        numbers.RemoveAt(RemoveAtNumber);
                        break;
                    case "Insert":
                        int InsertNumber = int.Parse(orders[1]);
                        int numberPosition = int.Parse(orders[2]);
                        numbers.Insert(InsertNumber,numberPosition);
                        break;
                }

            }
                
            Console.Write(string.Join(" ", numbers));
        }
    }
}