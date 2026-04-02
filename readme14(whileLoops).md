using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
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
            Console.Write("Enter the first number: ");
            int n1 = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter the second number: ");
            int n2 = Convert.ToInt32(Console.ReadLine());

            int result = n1 * n2;

            Console.WriteLine("what is the Value of " + n1 + " X " + n2 + " ? ");
            int guess = 0;
            while (guess != result)
            {
                Console.Write("enter the answer: ");
                guess = Convert.ToInt32(Console.ReadLine());
                if (guess == result)
                {
                    Console.WriteLine("Booyah, your answer was right!!");
                    break;
                }
                else
                {
                    continue;
                }

            };


            // do
            {
                
            } while (guess != result);

            // if(guess == result)
            // {
            //     Console.WriteLine("Good Jon!!");
            // }
            // else
            // {
            //     Console.WriteLine("Close but still wrong answer!!");
            // }

            Console.ReadLine();


        }
    }
}