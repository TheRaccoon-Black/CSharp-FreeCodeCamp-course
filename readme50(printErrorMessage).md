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

            try
            {
                Console.Write("Enter a number: ");
                int num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(num);
            }catch(Exception e)
            {
                Console.WriteLine($"Something went wrong!! message: {e.Message}");
                
            }
            Console.WriteLine("Good bye!!");
            Console.ReadLine();

        } 
        
        
    }
}