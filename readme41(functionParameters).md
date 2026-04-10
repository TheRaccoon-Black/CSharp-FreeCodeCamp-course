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
            
            Console.WriteLine(Add(12,1));

            // Console.Write("Enter a number: ");
            // int num  = Convert.ToInt32(Console.ReadLine());
            int num = ReadInt("Enter a number: ");
            Console.WriteLine(num);

            int num1 = ReadInt("Enter a angle: ");
            Console.WriteLine(num1);


            int firstNum = ReadInt("Enter first number: ");
            int secondNum = ReadInt("Enter second number: ");

            Console.WriteLine(Add(firstNum, secondNum));

            string? testing = ReadString("enter a name: ");
            Console.WriteLine(testing);


            Console.ReadLine();
        } 

        static int ReadInt(string message)
        {
            Console.Write(message);
            return Convert.ToInt32(Console.ReadLine());
        }
        static int Add(int a, int b)
        {
            return  a+b;
        }

        static string? ReadString(string message)
        {
            Console.Write(message);
            return Console.ReadLine();
        }

        
    }
}