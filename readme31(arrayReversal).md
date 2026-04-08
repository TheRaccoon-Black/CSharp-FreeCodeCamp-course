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


namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
             
            int[] number = new int[]
            {
              0,1,2,3,4,5  
            };

            int[] sortedNumbers = new int[number.Length];

            int x = 0;

            for (int i = number.Length - 1; i >= 0; i--)
            {
                sortedNumbers[x] = number[i];
                x++;
            }

            foreach(int num in sortedNumbers)
            {
                Console.Write($"{num} ");
            }


            // Array.Reverse(number);

            // foreach(int num in number)
            // {
            //     Console.Write($"{num} "); 
            // }
            Console.ReadLine();
        } 
    }
}