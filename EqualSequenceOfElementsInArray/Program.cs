using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualSequenceOfElementsInArray
{
    class Program
    {
        static void Main(string[] args)
        {

#if DEBUG
            Console.SetIn(new System.IO.StreamReader(@"D:\input.txt"));
#endif

            string input = Console.ReadLine();

            int[] arrayOfNumbers = input.Split(' ').Select(x => int.Parse(x)).ToArray();

            int start = arrayOfNumbers[0];
            foreach (var item in arrayOfNumbers)
            {
                if (item == start)
                {
                    start = item;
                }
                else start = 0;
            }

            if (start == arrayOfNumbers[0])
            {
                Console.WriteLine("Yes");
            }
            else
            {
                Console.WriteLine("No");
            }
        }
    }
}
