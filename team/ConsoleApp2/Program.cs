using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {


            //DisplayResult(RemoveWhiteSpace(yourName));
            //Console.Write("enter num of loops do you want: ");
            int n = Convert.ToInt32(Console.ReadLine());
           // string[] answers = new string[n];
            int trueans = 0;
            for(int i=0; i<n; i++)
            {
                //Console.Write("Enter your name: ");
                string yourName = Console.ReadLine();

                //Console.WriteLine($"hello {yourName}!");
                yourName = yourName.Replace(" ", "");
                int value1 = 0;


                foreach (char o in yourName)
                {

                   // Console.WriteLine(o);
                    int newnum = int.Parse(o.ToString());
                    //Console.WriteLine($"by int value: {newnum}.");
                    if (newnum == 1)
                        value1++;


                }

                //Console.WriteLine("num of 1: " + value1);
                if(value1 >= 2)
                {
                    //Console.WriteLine("yes");
                    trueans++;
                    //answers[i] = "yes";
                }
                //else
                //{
                //    //Console.WriteLine("no");
                //    answers[i] = "no";
                //}
                //Console.WriteLine(" ------------------ ");
            }
            //foreach(string ans in answers)
            //{
            //    //Console.WriteLine($" the total answer:");
            //    Console.WriteLine(ans);

            //}
            Console.WriteLine(trueans);
            // Console.WriteLine(" ------------------ ");



            // Console.ReadLine();

        }
        //private static string RemoveWhiteSpace(string message)
        //{
        //    return message.Replace(" ", "");
        //}

        //private static void DisplayResult(string message)
        //{
        //    Console.WriteLine($"Your modified string is: {message}");
        //}
    }
}
