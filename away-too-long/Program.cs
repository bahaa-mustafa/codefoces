using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace away_too_long_c_sharp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] words = new string[n];
            for(int i=0;i<n;i++)
            {
                words[i] = Console.ReadLine();

            }
            for(int i=0; i<n; i++)
            {
                if (words[i].Length > 10)
                {
                    Console.WriteLine($"{words[i].First()}{words[i].Length - 2}{words[i].Last()} ");
                }

                else
                    Console.WriteLine(words[i]);
            }
           





            Console.ReadLine();
        }
    }
}
