using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace next_round
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // declare varible
            string[] firstLine = Console.ReadLine().Split(' ');
            string[] secondLine = Console.ReadLine().Split();
            int n = Convert.ToInt16( firstLine[0]);
            int k = Convert.ToInt16(firstLine[1]);
            int l = Convert.ToInt16(secondLine[k-1]);
            int c = 0;

            // test .split() code
           /* Console.WriteLine(n + ", " + k );
            foreach(string c in secondLine)
            {
                Console.WriteLine( c );
            }
            */

            // main code
            for( int i = 0; i < n; i++ ) 
            {
                if (int.Parse(secondLine[i]) >= l && int.Parse(secondLine[i])!= 0)
                {
                    c++; 
                }
                
            }

            // return result
            Console.WriteLine(c);

            Console.ReadLine();

        }
    }
}
