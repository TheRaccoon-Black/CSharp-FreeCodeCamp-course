using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;


namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            string message = "Hello";
            string compare = "Hello";

            // if (message == compare)
            if(message.Equals(compare))
            {
                Console.WriteLine("same");
            }
            else
            {
                Console.WriteLine("diff");
            }

            Console.Write("enter your name: ");
            string? name = Console.ReadLine();
            //if ( name != "");
            if (name != string.Empty)
            {
                Console.WriteLine($"Your name is {name}");
            }
            else
            {
                Console.WriteLine("empty"); 
            }

            Console.ReadLine();
        } 
    }
}