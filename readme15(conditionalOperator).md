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
            int age = 10;

            // if (age >= 10)
            // { 
            //     Console.WriteLine("Valid");
            // }
            // else
            // {
            //     Console.WriteLine("Invalid");
            // }

            //conditinal operator
            //condition ? true : false

            string result = age >=10 ? "valid": "invalid";
            Console.WriteLine(result);
            Console.ReadLine();
        }
    }
}