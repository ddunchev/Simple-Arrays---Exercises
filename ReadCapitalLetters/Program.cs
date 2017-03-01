using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReadCapitalLetters
{
    class Program
    {
        static void Main(string[] args)
        {

#if DEBUG
            Console.SetIn(new System.IO.StreamReader(@"D:\input.txt"));
#endif


            var input = Console.ReadLine();
            int count = 0;
            char myItem; 
            foreach (string item in input.Split(' '))
            {
                //Console.WriteLine((int)item);

                if (char.TryParse(item, out myItem))
                {
                    if ((int)myItem >= 65 & (int)myItem <= 90)
                    {
                        count++;
                    }
                }


            }
            Console.WriteLine(count);
        }
    }
}
