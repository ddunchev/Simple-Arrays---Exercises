using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraySymmetry
{
    class Program
    {
        static void Main(string[] args)
        {

#if DEBUG
            Console.SetIn(new System.IO.StreamReader(@"D:\input.txt"));
#endif

            var input = Console.ReadLine();

            string[] myArray = input.Split(' ').ToArray();

            int count = 0;

            for (int i = 0; i < myArray.Length/2; i++)
            {
                if (myArray[i] == myArray[myArray.Length - 1 - i])
                {
                    count += 0;
                }
                else count += 1;
            }

            if (count == 0)
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
