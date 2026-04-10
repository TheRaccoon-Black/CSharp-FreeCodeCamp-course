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
    class Test2
    {
        public void somethingg()
        {
            Console.WriteLine("this is without static so need new instance");
        }
    }
    class Test
    {
        public static void something() //public mean everything has access it
        {
            Console.WriteLine("this is test public");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Test2 test2 = new Test2();
            test2.somethingg();// we create new instance because we dont use static keyword
            Test.something();//if we use public and static we can access like this

            WelcomeMessage();
            Console.ReadLine();
        } 
        static void WelcomeMessage()//static mean we can call this method without creating an instance of the class anywhere and everywhere in the program
        {
            Console.WriteLine("Welcome to my application!");
        }
    }
}