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

        static void permute(List<string> preserveItems, List<string> permuteItems)
        {
            if (permuteItems.Count == 1)
            {
                Console.WriteLine(String.Join(", ", preserveItems));
            } else
            {
                foreach (string item in preserveItems)
                {
                    preserveItems.Add(item);
                    permute(preserveItems, permuteItems);
                }
                
            }
        }

        static void WriteAllPermutations(List<string> items)
        {
            var preItems = new List<string>();
            if (items.Count == 1)
            {
                Console.WriteLine(string.Join("", items));
            }
            else
            {
                for (int i = 0; i < items.Count; i++)
                {
                    string item = items[i];
                    Console.Write(item + ", ");
                    items.RemoveAt(i);
                    WriteAllPermutations(items);
                    items.Insert(i, item);
                }
            }

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
