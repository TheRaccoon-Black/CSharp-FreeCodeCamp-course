using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;


namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Fizzbuzz game");
            int num = Convert.ToInt32(Console.ReadLine());

            bool threeDiv = false;
            bool fiveDiv =false;

            for (int i = 1; i <=num; i++)
            {
                threeDiv = i % 3 == 0;
                fiveDiv = i % 5 == 0;
                if ( threeDiv && fiveDiv )
                {
                    Console.WriteLine("FizzBuzz");
                } else if (threeDiv)
                {
                    Console.WriteLine("Fizz");
                }else if (fiveDiv)
                {
                    Console.WriteLine("Buzz");
                }
                else
                {
                    Console.WriteLine(i);
                }
            }


            Console.ReadLine();
        }
    }
}