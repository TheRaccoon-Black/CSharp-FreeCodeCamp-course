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


namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            CreatedAndPrintArray(); //void function doesn't return anything after call the function
            // numbers;
            Console.ReadLine();
        } 

        static void CreatedAndPrintArray()
        {
            int[] numbers = new int[3]{1,2,3};

            foreach(int num in numbers)
            {
                Console.Write($"{num} ");
            }

            // return x;
        }
    } 
}