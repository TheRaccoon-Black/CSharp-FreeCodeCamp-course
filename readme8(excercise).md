using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
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

            //write name, phone number, and age with variabel, also print that result
            //for extra print it to with var keyword

            string name = "ojik";
            string phone = "085764343434";//use string cause zero on front
            int age = 22;

            Console.WriteLine(name);
            Console.WriteLine(phone);
            Console.WriteLine(age);

            var testing = "string";
            Console.WriteLine(testing);
            Console.ReadLine();   

            
        }
    }
} 