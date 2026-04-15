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
            
            Console.Write("Enter a number: ");
            int num = Convert.ToInt32(Console.ReadLine());
            // try enter the value with 20000000000000(really big numbers)
            // and you will get exception unhandled
            Console.ReadLine();

        } 
        
        
    }
}