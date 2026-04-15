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
using System.IO.Pipelines;
using System.Net;


namespace MyApp
{
    class Program
    {

        static void Main(string[] args)
        {
            /*
            - create and iintialise int array of numbers
            - create function SumOfNumbers with int return type
            - int array params
            - function shouldn return tota of all numbers
            - call in main and output the total
            - extra: check array length
            -- return -1 if array empty
            -- chek return in main and output message
            -- do wen need to return -1, how else can we make this?
            */

            int[] numbers = new int[]
            {
                2,5,3,1,2
            };

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write(numbers[i]);
            }

            int result = SumOfNumbers(numbers);

            if (result > 0)
            {
                Console.WriteLine($"result from sum array of numbers is : {result}");
            }
            else
            {
                Console.WriteLine("Array is empty");
            }
            Console.ReadLine();

        } 
        
        static int SumOfNumbers(int[] array)
        {   if(array.Length > 0)
            {
                    int sum = 0;
                for (int i = 0; i < array.Length - 1; i++)
                {
                    sum += array[i];
                }
                return sum;
            }
            else
            {
                return -1;
            }
            
        }
        //SOLUTION FROM VIDEO
        // static bool SumOfNumbersFromVideo(int[] array, out int total)
        // {
        //     total = 0;

        //     if( array.Length > 0)
        //     {
        //         foreach(int num in array)
        //         {
        //             total += num;
        //         }
        //         return true;
        //     }
        //     return false;
        // }
        
    }
}