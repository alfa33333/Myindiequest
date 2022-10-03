using System;
using System.Collections.Generic;

namespace Mission2
{
    internal class Program
    {
        static string JoinWithAnd(List<string> items, bool useSerialComma = true)
        {
            int count = items.Count;
            string listJoined;
            // Selects the correct cases for strings
            switch (count)
            {
                case 0:
                    listJoined = "";
                    break;
                case 1:
                    listJoined = items[0];
                    break;
                case 2:
                    listJoined = String.Join(" and ", items);
                    break;
                default:
                    // This is when the string is bigger than 2 elements.
                    var itemsCopy = new List<string>(items);
                    if (useSerialComma)
                    {
                        itemsCopy[count - 1] = "and " + itemsCopy[count - 1];
                        listJoined = String.Join(", ", itemsCopy);
                    }
                    else
                    {
                        itemsCopy[count - 2] = String.Join(" and ", items.GetRange(count - 2, 2));
                        itemsCopy.RemoveAt(count-1);
                        listJoined = String.Join(", ", itemsCopy);
                    }
                    break;
            }

            return listJoined;
        }
        static void Main(string[] args)
        {
            var names = new List<string> { "Jazlyn", "Theron", "Dayana", "Rolando"};
            // Test examples
            Console.WriteLine($"The heroes in the party are: {JoinWithAnd(names)}.");
            Console.WriteLine($"The heroes in the party are: {JoinWithAnd(names, false)}.");
            Console.WriteLine($"The heroes in the party are: {JoinWithAnd(names.GetRange(0,2))}.");
            Console.WriteLine($"The heroes in the party are: {JoinWithAnd(names.GetRange(0,1))}.");
        }
    }
}
