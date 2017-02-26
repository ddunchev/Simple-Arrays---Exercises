using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CountOfGivenElementInArray
{
    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            var number = int.Parse(Console.ReadLine());
            int count = 0;

            int[] myArray = input.Split(' ').Select(x => int.Parse(x)).ToArray();

            foreach (var item in myArray)
            {
                if (item == number) count++;
            }

            Console.WriteLine(count);
        }
    }
}
