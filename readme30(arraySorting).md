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


namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
             
            int[] numbers = new int[] 
            {
                3,2,12,4,5,6,7,8,9
            };

            Array.Sort(numbers);

            foreach(int num in numbers)
            {
                Console.Write($"{num} ");
            }

            Console.ReadLine();
        } 
    }
}