using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Altitude
{
    class Program
    {
        static void Main(string[] args)
        {

#if DEBUG
            Console.SetIn(new System.IO.StreamReader(@"D:\input.txt"));
#endif


            var input = Console.ReadLine();

            string[] myString = input.Split(' ').ToArray();

            string[] upOrDown = new string[myString.Length];
            int[] high = new int[myString.Length];

            int number = 1, countNum = 0, countString = 0;

            foreach (var item in myString)
            {
                if (int.TryParse(item, out number))
                {
                    high[countNum] = number;
                    countNum++;
                }
                else
                {
                    upOrDown[countString] = item;
                    countString++;
                }
            }

            int altitude = high[0];

            for (int i = 0; i < myString.Length; i++)
            {
                if (upOrDown[i] == "up")
                {
                    altitude += high[i+1];
                }
                else if(upOrDown[i] == "down")
                {
                    altitude -= high[i+1];
                }
            }

            if (altitude > 0)
            {
                Console.WriteLine($"got through safely. current altitude: {altitude}m");
            }
            else
            {
                Console.WriteLine("crashed");
            }
        }
    }
}
