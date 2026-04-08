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
              90,12,222,38,4,5  
            };

            Console.Write("enter a number to search: ");
            int num = Convert.ToInt32(Console.ReadLine());

            // int position = Array.IndexOf(number, num);
            // int position = Array.IndexOf(number, num, 2); //with start index
            int position = Array.IndexOf(number, num, 2, 4); //with end index
            //03:51:38
            /* int position = -1;

            for (int i = 0; i < number.Length; i++)
            {
                if (number[i] == num)
                {
                    position = i;
                }
            }*/

            if (position > -1)
            {
            Console.WriteLine($"Number {num} has been found at position {position}"); 
                
            }
            else
            {
                Console.WriteLine($"Number {num} has not been found");
            }
            

            
            Console.ReadLine();
        } 
    }
}