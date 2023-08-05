using System;
using System.Collections.Generic;
using System.Linq;

namespace BonusMission
{
    internal class Program
    {
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

        static void permute(List<string> preserveItems, List<string> items)
        {
            if (items.Count == 1)
            {
                preserveItems.Add(items[0]);
                Console.WriteLine(string.Join(", ", preserveItems));
                preserveItems.RemoveAt(preserveItems.Count-1);
            }
            else
            {
                int layer = items.Count;
                for (int i = 0; i < layer; i++)
                {
                    string item = items[i];
                    preserveItems.Add(item);
                    items.RemoveAt(i);
                    permute(preserveItems,items);
                    items.Insert(i,item);
                    preserveItems.RemoveAt(preserveItems.Count-1);
                }
            }
        }

        static void WriteAllPermutations(List<string> items)
        {
            var preserveItem = new List<string>();
            permute(preserveItem, items);

        }
        static void Main(string[] args)
        {
            var names = new List<string>() { "Allie", "Ben", "Claire", "Dan", "Eleanor" };
            var shortnames = new List<string>() { "Allie", "Ben", "Claire" };
            WriteAllPermutations(shortnames);
            Console.WriteLine(string.Join(", ", shortnames));
        }
    }
}
