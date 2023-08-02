using System;

namespace Mission2
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
                return n*Factorial(n-1);
            }
        }
        static void Main(string[] args)
        {
            for (int i = 0; i < 11; i++)
            {
                Console.WriteLine("{0}! = {1}", i, Factorial(i));
            }
        }
    }
}
