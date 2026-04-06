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
            // string name = string.Empty; //sama dengan string name;

            Console.Write("Enter your name: ");
            string? name = Console.ReadLine();

            if( name != string.Empty)//""
            {
            Console.WriteLine($"Your name is {name}");
            }
            else
            {
                Console.WriteLine("Name is empty");
                
            }



            Console.ReadLine();
        } 
    }
}