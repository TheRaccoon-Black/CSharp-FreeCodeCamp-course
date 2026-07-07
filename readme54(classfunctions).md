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
            public int number;


            public Person(string name, int age)
            {
                this.name = name;
                this.age = age;
            }

            public string ReturnDetails()
            {
                return $"Name: {name}\n age: {age}";
                
            }

            public void something()
            {
                
            }
            // public Person(string name)
            // {
            //     this.name = name;
            //     this.age = -1;
            // }
            // public Person(int age)
            // {
            //     this.name = "";
            //     this.age = age;
            // }
            // public Person(string name, int age)
            // {
            //     this.name = name;
            //     this.age = age;

            // }

        }    

        static void Main(string[] args)
        {
            
            
            Person person = new Person("ojik",23);
            // Console.WriteLine($"Name: {person.name}\n age: {person.age}");
            // Console.WriteLine(ReturnDetails(person));
            Console.WriteLine(person.ReturnDetails());
            person.something();

            Console.ReadLine();

        } 

        // static string ReturnDetails(string? name, int age)
        // {
        //     return $"Name: {name}\n age: {age}";
            
        // }
        /*static string ReturnDetails(Person person)
        {
            return $"Name: {person.name}\n age: {person.age}";
            
        }*/

        
    }
}