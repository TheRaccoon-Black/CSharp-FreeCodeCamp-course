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
    //7:00:21 last 
    class Program
    {
        struct Person
        {
            public string name; //add 'public' access modifier to make the fields accessible outside the struct
            public int age;
            public int birthYear;
        }

        static void Main(string[] args)
        {
            /*string name = "ojik";
            int age = 23;
            int birthYear = 2003;

            Person person;

            person.name = "ojik";
            person.age = 23;
            person.birthYear = 2003;
            
            Console.WriteLine($"{name} - {age} - {birthYear}");
            Console.WriteLine($"{person.name} - {person.age} - {person.birthYear}");

            // string? newName = ReturnPerson(out int newAge); //lihat bawah
            string? newName = "";
            int newAge = 0;
            int newBirthYear = 0;

            ReturnPerson(ref newName, ref newAge, ref newBirthYear);
            Console.WriteLine($"{newName} - {newAge} - {newBirthYear}");

            Console.WriteLine("done.."); */

            Person person = ReturnPerson();
            Console.WriteLine($"{person.name} - {person.age} - {person.birthYear}");



          
            Console.ReadLine();

        } 

        static Person ReturnPerson()
        {
            Console.Write("Enter your name : ");
            string? name = Console.ReadLine();

            Console.Write("Enter your age: ");
            int age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your birth year: ");
            int birtYear = Convert.ToInt32(Console.ReadLine());

            Person person;

            person.name = name ?? "";
            person.age = age;
            person.birthYear = birtYear;

            return person;

            
        }

        // static string? ReturnPerson(out int age)
        /*static void ReturnPerson(ref string? name, ref int age, ref int birtYear)
        {
            Console.Write("Enter your name : ");
            // string? name = Console.ReadLine();
            name = Console.ReadLine();

            Console.Write("Enter your age: ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.Write("Enter your birth year: ");
            birtYear = Convert.ToInt32(Console.ReadLine());


            // return name;
        }*/

       
        
        
    }
}