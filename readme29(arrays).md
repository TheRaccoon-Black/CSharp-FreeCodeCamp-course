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
             
            // //  int num1 = 5;
            // //  int num2 = 10;
            // //  int num3 = 15;
            
            // int[] numbers = new int[3];

            // /*Console.Write("Enter a number: ");
            // numbers[0] = Convert.ToInt32(Console.ReadLine());
            // Console.Write("Enter a number: ");
            // numbers[1] = Convert.ToInt32(Console.ReadLine());
            // Console.Write("Enter a number: ");
            // numbers[2] = Convert.ToInt32(Console.ReadLine());

            // Console.WriteLine($"{num1} {num2} {num3}");
            // Console.WriteLine($"{numbers[0]} {numbers[1]} {numbers[2]}");*/

            // for (int i = 0; i < numbers.Length; i++)
            // {
            //     Console.Write("Enter a number: ");
            //     numbers[i] = Convert.ToInt32(Console.ReadLine());
            // }

            // for (int i = 0; i < numbers.Length; i++)
            // {
            //     Console.Write($"{numbers[i]} ");
            // }
            // Console.WriteLine();
            // foreach(int num in numbers)
            // {
            //     Console.Write($"{num} ");
            // }

             const int angleCount = 3;
            int[] angles = new int[angleCount];

            for (int i = 0; i < angles.Length; i++)
            {
                Console.Write($"Enter angle {i+1}: ");
                angles[i] = Convert.ToInt32(Console.ReadLine());
            }

            int angleSum = 0;

            foreach(int angle in angles)
            {
                angleSum += angle;
            }

            // if (angleSum == 180)
            // {
            //     Console.WriteLine("valid");
            // }
            // else
            // {
            //     Console.WriteLine("invalid");
            // }
            Console.WriteLine(angleSum == 180? "valid": "invalid");

            Console.ReadLine();
        } 
    }
}