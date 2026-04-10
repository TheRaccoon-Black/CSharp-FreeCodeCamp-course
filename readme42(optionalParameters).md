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

            int result = Add(1);
            Console.WriteLine(result);

            PrintName("xiaome");
            PrintName();
        
            Console.ReadLine();

        } 

        static void PrintName(string name = "Ojik")
        {
            Console.WriteLine($"Your name is: {name}");
        }
        static int Add(int a, int b = 50)//best practice is using default or 0 value;
        {
            return a + b;
        }
        
    }
}