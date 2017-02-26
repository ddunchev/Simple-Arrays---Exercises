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

#if DEBUG
            Console.SetIn(new System.IO.StreamReader(@"E:\input.txt"));
#endif

            string input = Console.ReadLine();
            var number = float.Parse(Console.ReadLine());
            int count = 0;

            float[] myArray = input.Split(' ').Select(x => float.Parse(x)).ToArray();

            foreach (var item in myArray)
            {
                if (item > number) count++;
            }

            Console.WriteLine(count);
        }
    }
}
