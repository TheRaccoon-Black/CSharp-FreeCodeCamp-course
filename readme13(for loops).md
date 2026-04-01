using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Diagnostics.Metrics;
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
            Console.Write("How many times do yo wanti to say hi?: ");
            int counter = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("What do you want to repeat?: ");
            string? hai = Console.ReadLine();

            if (counter <= 0)
            {
                Console.WriteLine("Please input above 0");
            }

            for (int i = 0; i < counter; i++)
            {
                Console.WriteLine(hai);
            }
            Console.ReadLine();
        }
    } 
}  