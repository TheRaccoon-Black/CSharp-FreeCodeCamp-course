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
            
            bool looping = true;

            while (looping)
            {
                
                try{
                Console.Write("Enter a number: ");
                int num = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine(num);

                looping = false;
                }
                catch(OverflowException)
                {
                    Console.WriteLine("please only a number less than 2 billion!!");
                }
                catch(FormatException)
                {
                    Console.WriteLine("please only enter numbers!!");
                }
                catch( Exception) //will get all the errors are
                {
                    Console.WriteLine("something went wrong");
                }

            }
            Console.WriteLine("good bye"); 
            Console.ReadLine();

        } 
        
        
    }
}