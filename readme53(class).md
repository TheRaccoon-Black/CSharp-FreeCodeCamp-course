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
using System.Collections;


namespace MyApp
{
    //7:00:21 last 
    class Program
    {

        /*struct Person
        {
            public string name;
            public int age;

            public Person(string name, int age)
            {
                this.name = name;
                this.age = age;
            }
        }   */

        //THE DIFFERENCES between struct and class is that class don't need default values

        class Person
        {
            public string name;
            public  int age;


            public Person()
            {
                
            }
            public Person(string name)
            {
                this.name = name;
                this.age = -1;
            }
            public Person(int age)
            {
                this.name = "";
                this.age = age;
            }
            public Person(string name, int age)
            {
                this.name = name;
                this.age = age;

            }

        }    

        static void Main(string[] args)
        {
            Console.Write("Enter your name: ");
            string? name = Console.ReadLine();

            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            
            Person person = new Person(name,age);


            Console.WriteLine(person.name);
            Console.WriteLine(person.age);


            Console.WriteLine("Done....");
            Console.ReadLine();

        } 

        
    }
}