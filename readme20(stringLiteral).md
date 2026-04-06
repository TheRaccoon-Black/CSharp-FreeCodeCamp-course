using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Diagnostics.CodeAnalysis;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;


namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
            //\t \n \" \\ = \    
            string speech = "He said \"something\"";
            string path = "C:\\Users\\Coffee\\C# Course\nNew line test";
            Console.WriteLine(speech);
            Console.WriteLine(path);

            // $ +
            // $"testing value {value}"
            // "name with " +  value

            path = @"C:\\Users\\Coffee\\C# Course \n New line test";
            Console.WriteLine(path);

            string name = @"hello "" someone """;
            Console.WriteLine(name);
            string name2 = @"hello ' someone '";
            Console.WriteLine(name2);
            Console.ReadLine();
        } 
    }
}