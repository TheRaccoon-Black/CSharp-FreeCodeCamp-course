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


        class Person
        {
            private string name;
            private int age;
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

            // public void SetName(string name)
            // {
            //     /*if (!string.IsNullOrEmpty(name))
            //     {
            //         this.name = name;
            //     }
            //     else
            //     {
            //         this.name = "Invalid name";
            //     }*/

            //     this.name = !string.IsNullOrEmpty(name) ? name : "Invalid name";
            // }

            /*public string GetName()
            {
                return name;
            }*/

            // public void SetAge(int age)
            // {
            //     // if (age > 0 && age < 150)
            //     // {
            //     //     this.age = age;
            //     // }
            //     // else
            //     // {
            //     //     this.age = -1;
            //     // }

            //     // //condition ? true : false

            //     this.age = age > 0 && age < 150 ? age : -1;
            // }

            /*public int GetAge()
            {
                return age;
            }*/

            public void SetName(string name) => this.name = !string.IsNullOrEmpty(name) ? name : "Invalid name";
            public void SetAge(int age) => this.age = age > 0 && age < 150 ? age : -1;
            public string GetName() => name;
            public int GetAge() => age;

        }    

        static void Main(string[] args)
        {
            
            
            Person person = new Person("ojik",23);
            Console.WriteLine(person.ReturnDetails());

            // person.name = "arief";
            // person.age = 25;
            person.SetName("arief");
            person.SetAge(25);
            Console.WriteLine(person.ReturnDetails());

            // Console.WriteLine($"Your name is {person.name}");//error karena name sudah private
            Console.WriteLine($"Your name is {person.GetName()} and your age is {person.GetAge()}");

            Console.ReadLine();

        } 

        
    }
}