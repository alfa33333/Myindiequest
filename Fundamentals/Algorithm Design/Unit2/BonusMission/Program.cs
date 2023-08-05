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

        static void permute(List<string> preserveItems, List<string> items, ref int upCount)
        {
            if (items.Count == 1)
            {
                preserveItems.Add(items[0]);
                Console.Write(upCount+". ");
                Console.WriteLine(string.Join(", ", preserveItems));
                preserveItems.RemoveAt(preserveItems.Count-1);
                upCount++;
            }
            else
            {
                int layer = items.Count;
                for (int i = 0; i < layer; i++)
                {
                    string item = items[i];
                    preserveItems.Add(item);
                    items.RemoveAt(i);
                    permute(preserveItems,items, ref upCount);
                    items.Insert(i,item);
                    preserveItems.RemoveAt(preserveItems.Count-1);
                }
            }
        }

        static void WriteAllPermutations(List<string> items)
        {
            var preserveItem = new List<string>();
            int nlayer = 1;
            permute(preserveItem, items, ref nlayer);

        }
        static void Main(string[] args)
        {
            var shortnames = new List<string>() { "Allie", "Ben", "Claire", "Dan"};
            Console.WriteLine("Signed-up participants: "+String.Join(", ",shortnames));
            Console.WriteLine("Starting orders:");
            WriteAllPermutations(shortnames);

        }
    }
}
