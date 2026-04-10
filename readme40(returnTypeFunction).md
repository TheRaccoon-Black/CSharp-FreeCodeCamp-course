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

        // static string name = "ojik";
        static void Main(string[] args)
        {
            Console.Title = $"{ReturnName()}--{ReturnAge()}";
            
            PrintIntroduction();

            int[] numbers = new int[3];

            for (int i = 0; i < numbers.Length; i++)
            {
                // Console.Write("Enter a number: ");
                // numbers[i] = Convert.ToInt32(Console.ReadLine());
                numbers[i] = ReturnNumberFromConsole();
            }

            foreach(int i in numbers)
            {
                Console.Write($"{i} ");
            }

            int[] ranNumbers = CreateRandomArray();

            foreach(int i in ranNumbers)
            {
                Console.Write($"{i} ");
            }
            Console.ReadLine();
        } 

        static string ReturnName()
        {
            return "ojik";
        }

        static int ReturnAge()
        {
            return 23;
        }

        static int ReturnNumberFromConsole()
        {
            Console.Write("Enter a number: ");
            return Convert.ToInt32(Console.ReadLine());
        }

        static int[] CreateRandomArray()
        {
            // int[] numbers = new int[4]
            // {
            //     0,2,4,1
            // };

            // return numbers;
            return new int [4]{3,2,3,1};
        }

        static void PrintIntroduction()
        {
            Console.WriteLine(ReturnName());

            string name = ReturnName();
            int age = ReturnAge();

            Console.WriteLine($"Helloo my name is {name} and my age is {age}");
            Console.WriteLine($"Helloo my name is {ReturnName()} and my age is {ReturnAge()}");
    } 
}
}