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


namespace MyApp
{
    class Program
    {

        static void Main(string[] args)
        {
            string nameInput = "ojik";
            int ageInput = 22;
            string addressInput = "bengkulu";

            // PrintDetails(nameInput, ageInput, addressInput);//it's always on sequence, if you one to use params not in order you can try bellow:
            PrintDetails(age: ageInput, name: nameInput, address: addressInput);//use named params
            Console.ReadLine();

        } 

        static void PrintDetails(string name, int age, string address)
        {
            Console.WriteLine(name);
            Console.WriteLine(age);
            Console.WriteLine(address);
        }
        
    }
}