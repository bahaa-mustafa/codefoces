using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace domino_biling
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declare varibale and input
            string[] firstLine = Console.ReadLine().Split(' ');
            int m = Convert.ToInt16(firstLine[0]);
            int n = Convert.ToInt16(firstLine[1]);
             int resultOfMultible = m * n; // (Convert.ToInt16(firstLine[0])) * (Convert.ToInt16(firstLine[0]));
            
            // main code
            if (resultOfMultible % 2 > 1)
            {
                Console.WriteLine((resultOfMultible / 2) + 1);
            }
            else
                Console.WriteLine(resultOfMultible / 2);

            // ouput
            Console.ReadLine();
        }
    }
}
