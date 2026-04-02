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
            bool success = true;

            while (success)
            {
                Console.Write("Enter a number: ");
                string? numIinput = Console.ReadLine(); //10h

                if(int.TryParse(numIinput, out int num))
                { 
                    success = false;
                    Console.WriteLine(num);
                }
                else
                {
                    Console.WriteLine("Failed to convert! ");

                }

            }

            Console.ReadLine();
        }
    }
}