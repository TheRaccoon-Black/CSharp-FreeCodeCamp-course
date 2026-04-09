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
             
           int[] numbers = new int[4]
           {
              1,2,3,4
           };

        //    List<int> listNumbers = new List<int>() // list dont care about count
        //    {
        //        1,2,3 
        //    };
        //     listNumbers.Add(1);
        //     listNumbers.Add(2);
        //     listNumbers.Add(3);

           List<int> listNumbers = new List<int>();

           for (int i = 0; i < 3; i++)
            {
                Console.Write("Enter a number : ");
                int num = Convert.ToInt32(Console.ReadLine());
                listNumbers.Add(num);
            }

            foreach(int i in listNumbers)
            {
                Console.Write($"{i} ,");
            }//1,2,3,

            listNumbers.RemoveAt(0);
            for (int i = 0; i < listNumbers.Count; i++)
            {
                Console.Write($"{listNumbers[i]} ,");
            }//2,3
            

            
            Console.ReadLine();
        } 
    }
}