using System;
using System.Reflection.Metadata.Ecma335;

namespace Mission3
{
    internal class Program
    {
        static string OrdinalNumber(int number)
        {
            var lastDigit = number % 10;
            var secondLast = 0;
            string numEnd = "th";
            if (number > 10)
            {
                secondLast = (number/10) % 10;
            }
            if (secondLast != 1)
            {
                switch (lastDigit)
                {
                    case 1:
                        numEnd = "st";
                        break;
                    case 2:
                        numEnd = "nd";
                        break;
                    case 3:
                        numEnd = "rd";
                        break;
                    default:
                        break;
                }
            }
            return number.ToString() + numEnd;
        }
        static void Main(string[] args)
        {
            int[] testNum = {1, 2, 3, 10, 11, 12, 13, 21, 101, 111, 121};
            for(int i = 0; i < testNum.Length; i++)
            {
                Console.WriteLine(OrdinalNumber(testNum[i]));
            }
        }
    }
}
