using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace atermelon_solve_c_sharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int w= Convert.ToInt16(Console.ReadLine());

            if (w > 2)
            {
                if(w%2==0)
                {
                    Console.WriteLine("YES");
                }

                else
                    Console.WriteLine("NO");


            }
            else if(w==0 || w==1 || w==2 )
            { Console.WriteLine("NO"); }

            else
                Console.WriteLine("enter a right value please");

            Console.ReadLine();

        }
    }
}
