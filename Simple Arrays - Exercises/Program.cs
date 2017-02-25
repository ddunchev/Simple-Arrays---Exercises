using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Simple_Arrays___Exercises
{
    class Program
    {
        static void Main(string[] args)
        {
            //Get the max length of an array and publish to GitHub

            var input = int.Parse(Console.ReadLine());
            int[] myArray = new int[input];

            for (int i = 0; i < input; i++)
            {
                myArray[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine(getMaxNumFromarray(myArray));
        }

        static int getMaxNumFromarray(int[] array)
        {
            int max = int.MinValue;
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > max)
                {
                    max = array[i];
                }
            }
            return max;
        }
    }
}
