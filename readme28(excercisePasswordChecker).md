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
             
            Console.Write("Enter a password: ");
            string? pw = Console.ReadLine();
            Console.Write("Enter your password again: ");
            string? pw2 = Console.ReadLine();

            if(!string.IsNullOrEmpty(pw) && !string.IsNullOrEmpty(pw2))
            {
                if (pw.Equals(pw2))
                {
                    Console.WriteLine("Password Match");
                } else{Console.WriteLine("Password do not match");}
            }else{Console.WriteLine("Plese Enter a password");}
            
            Console.ReadLine();
        } 
    }
}