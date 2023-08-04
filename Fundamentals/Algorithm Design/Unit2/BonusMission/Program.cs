using System;
using System.Collections.Generic;

namespace BonusMission
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

        static int Factorial(int n)
        {
            if (n == 0)
            {
                return 1;
            }
            else
            {
                return n * Factorial(n - 1);
            }
        }

        static void WriteAllPermutations(List<string> items)
        {
            //Console.WriteLine(string.Join(", ", items.GetRange(1, items.Count - 1)));

            if (items.Count == 1)
            {
                Console.WriteLine(String.Join(", ", items));
            }
            //else
            //{
            //    foreach (string item in items)
            //    {
            //        Console.WriteLine(WriteAllPermutations());
            //    }
            //}
            //var copyItems = items;
            //int total = Factorial(items.Count);
            //Console.WriteLine(total);

            //if (total == 1)
            //{
            //    Console.WriteLine(items);
            //} else
            //{
            //    (copyItems[i], copyItems[j]) = (copyItems[j], copyItems[i]);
            //    WriteAllPermutations()
            //}

            //for (int i = 0; i <= total-1; i++)
            //{
            //    Console.WriteLine(string.Join(", ", copyItems));
            //    (copyItems[i], copyItems[j]) = (copyItems[j], copyItems[i]);
            //}

        }
        static void Main(string[] args)
        {
            var names = new List<string>() { "Allie", "Ben", "Claire", "Dan", "Eleanor" };
            var shortnames = new List<string>() { "Allie", "Ben" };
            WriteAllPermutations(shortnames);
            Console.WriteLine(string.Join(", ", shortnames));
        }
    }
}
