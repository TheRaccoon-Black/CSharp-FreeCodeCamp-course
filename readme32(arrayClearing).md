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

            // Array.Clear(number,0,number.Length);//0,0,0,0,0,0

            // for (int i = 0; i  < number.Length; i++)
            // {
            //     number[i] = default;
            // }

            Array.Clear(number,4,2); //0 1 2 3 0 0
            
            foreach(int num in number)
            {
                Console.Write($"{num} ");
            }
            Console.ReadLine();
        } 
    }
}