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
             
            Console.Write("Type a message: ");
            string? message = Console.ReadLine();

            for (int i = message.Length; i > 0; i--)
            {
                Console.Write(message[i-1]);
                Thread.Sleep(200);
            }
            
            Console.ReadLine();
        } 
    }
}