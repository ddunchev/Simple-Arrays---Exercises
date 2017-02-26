using System;
using System.Linq;

namespace IncreasingSequenceOfElements
{
    class Program
    {
        static void Main(string[] args)
        {
            var input = Console.ReadLine();
            int[] myArray = input.Split(' ').Select(x => int.Parse(x)).ToArray();
            Console.WriteLine(GetIncSeqOfElements(myArray));
        }

        static string GetIncSeqOfElements(int[] array)
        {
            string yesOrNot = "Yes";
            int minVal = int.MinValue;

            foreach (var item in array)
            {
                if (item < minVal) yesOrNot = "No";
                minVal = item;
            }
            return yesOrNot;
        }
    }
}
