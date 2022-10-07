using System;
using System.Collections.Generic;
using System.Security.Claims;

namespace Mission1
{
    internal class Program
    {

        static void ShuffleList(List<string> items)
        {
            Random rnd = new Random();
            for (int i = items.Count - 1; i >= 1; i--)
            {
                int j = rnd.Next(0, i + 1);
                (items[i], items[j]) = (items[j], items[i]);
            }

        }
        static void Main(string[] args)
        {
            var names = new List<string>() { "Allie", "Ben", "Claire", "Dan", "Eleanor" };
            Console.WriteLine("Signed - up participants: " + String.Join(", ", names));
            Console.WriteLine("Generating starting order ...");
            ShuffleList(names);
            Console.WriteLine("Starting order: " + String.Join(", ", names));
        }
    }
}
