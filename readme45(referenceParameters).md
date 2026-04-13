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
using System.Transactions;
using System.Runtime.ExceptionServices;
using System.Security.Cryptography.X509Certificates;
using System.Data;
using System.Reflection;


namespace MyApp
{
    class Program
    {

        static void Main(string[] args)
        {
            
            /*int num = 10;
            string? name = "alex";
            // Assign(ref num);//20
            Assign(ref num, ref name);
            Console.WriteLine(num);
            Console.WriteLine(name);*/
            string name = "aleks";
            Console.Write("Enter your new name: ");
            string? newName = Console.ReadLine();
        
            // ChangeName(ref name, newName);
            if(ChangeName(ref name, newName))
            {
             Console.WriteLine($"Your new name is {newName}");
            }
            else
            {
                Console.WriteLine("New name cannot be empty or Null")
            }
            Console.ReadLine();

        } 
        static bool ChangeName(ref string name, string  newName)
        {
            if (!string.IsNullOrEmpty(newName))
            {
                name = newName;
                return true;
            }
            
                return false;
            
        }
        //if using out you need to provide the new value 
        //if using ref we can pass the assign params

        // static void Assign(out int num)
        // {
        //     num = 20;
        // }
        static void Assign(ref int num, ref string name)
        {
            name = "ojik";
        }
            
        
    }
}