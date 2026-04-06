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
using System.Threading;


namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
             
            Console.Write("Enter your name: ");
            string? name = Console.ReadLine();

            // if  (name != "")
            // {
            //     Console.WriteLine("0");
            // }
            // if (!name.Equals(""))
            // {
            //     Console.WriteLine("1");
            // }
            if (!string.IsNullOrEmpty(name)) //Null ""
            {
                if (name.Equals("ojik"))
                {
                    Console.WriteLine("correct");
                }
                Console.WriteLine("2");
            }
            
            Console.ReadLine();
        } 
    }
}