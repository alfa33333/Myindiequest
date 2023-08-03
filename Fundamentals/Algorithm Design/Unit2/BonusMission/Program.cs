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
            var copyItems = items;
            int total = Factorial(items.Count);
            Console.WriteLine(total);
            for (int i = 0; i <= total-1; i++)
            {
                Console.WriteLine(string.Join(", ", copyItems));
                //(copyItems[i], copyItems[j]) = (copyItems[j], copyItems[i]);
            }
            
        }
        static void Main(string[] args)
        {
            var names = new List<string>() { "Allie", "Ben", "Claire", "Dan", "Eleanor" };
            var shornames = new List<string>() { "Allie", "Ben" };
            WriteAllPermutations(shornames);
        }
    }
}
