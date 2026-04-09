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
             - define and initialize two integers (num, length)
             - (7, 5) -> [7, 14, 21, 28, 35]
             - create int array with size of length
             -loop through and insert the (loop counter x num) into the array
             - print the final array
             */
            Console.Write("Input number: ");
            int num =  Convert.ToInt32(Console.ReadLine());
            Console.Write("Input Length: ");
            int length =  Convert.ToInt32(Console.ReadLine());

            int[] result = new int[length];
            for (int i = 0; i < length; i++)
            {
                result[i] = (i+1)*length;
            }

            foreach(int item in result)
            {
                Console.Write($"{item} ");
            }
            Console.ReadLine();
        } 
    }
}