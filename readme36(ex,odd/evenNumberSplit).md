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
             /*
             -create two lists with integer data type, one for even, one for odd
             -loop from 0-20
             --if number is even, add to even list
             --if number is odd, add to odd list
             -print even list
             -print odd list

             
             
             */
            List<int> even = new List<int>();
            List<int> odd = new List<int>();

            for (int i = 0; i < 20; i++)
            {
                if (i % 2 == 0)
                {
                    even.Add(i);
                }
                else
                {
                    odd.Add(i);
                }
            }
            Console.WriteLine("All even numbers: ");
            foreach(int num in even)
            {
                Console.Write($"|{num}|");
            }
        Console.WriteLine("\nAll odd numbers: ");
            foreach(int num in odd)
            {
                Console.Write($"|{num}|");
            }

            Console.ReadLine();
        } 
    }
}