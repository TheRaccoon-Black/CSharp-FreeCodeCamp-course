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
            string name = "Ojik";
            int age = 22;

            Console.WriteLine("Yourname is " + name + ", and your age is " + age + "old");
            Console.WriteLine($"Yourname is {name}, and your age is {age} old");

             

            Console.ReadLine();
        } 
    }
}