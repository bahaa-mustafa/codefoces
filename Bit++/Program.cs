using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bit__
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int X = 0;
            string n;
            int y = Convert.ToInt32(Console.ReadLine());
            for(int i=0; i<y; i++)
            {
                n = Console.ReadLine();
                if(n =="X++" ||  n =="++X")
                    X++;
                else
                    X--;
            }
            Console.WriteLine(X);
            Console.ReadLine();
        }
    }
}
