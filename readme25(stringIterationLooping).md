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


namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
             
            string message = "C# is awesome";
            // char[]
            // Console.WriteLine(message[0]); //C
            // Console.WriteLine(message[1]); //#
            // Console.WriteLine(message[2]); //
            // Console.WriteLine(message[3]); //i

            for (int i = 0; i < message.Length; i++)
            {
                Console.Write(message[i]);//C# is awesome
                Thread.Sleep(250); 
            }
            Console.WriteLine();
            Console.WriteLine(message.Contains("C"));

             bool contains = message.Contains("C");

             for (int i = 0; i < message.Length; i++)
            {
                if (message[i] == 'C')
                {
                    Console.WriteLine("Found C at index " + i);
                }
            }

            Console.ReadLine();
        } 
    }
}