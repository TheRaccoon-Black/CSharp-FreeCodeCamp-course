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
           string name = "ojik";
           int age = 22;

           Console.WriteLine("Name: " + name);
           Console.WriteLine("Age : " + age);

           Console.WriteLine();

           Console.WriteLine("Name: " + name + "\nAge : " + age);
           Console.WriteLine("Your name is "+ name + ", and your age is "+ age);

            Console.WriteLine("Your name is {0}, and your age is {1}", name, age);
            Console.WriteLine("Name : {0} \nAge : {1}", name, age);

            Console.ReadLine();
        } 
    }
}