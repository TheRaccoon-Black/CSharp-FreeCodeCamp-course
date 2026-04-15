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


namespace MyApp
{
    class Program
    {

        static void Main(string[] args)
        {
            /*
            -ask user for width and height, store them
            -create function to calculate the area
            -function should calculate the area using : (height * weight ) / 2
            -call in main and print out the area of the triangle
            */

            Console.Write("Enter the weight: ");
            int weight = Convert.ToInt32(Console.ReadLine());
            Console.Write("Enter the height: ");
            int height = Convert.ToInt32(Console.ReadLine());

            int result = Triangle(weight,height);
            Console.WriteLine($"Result of triangle is : {result}");
            
            Console.ReadLine();

        } 
        static int Triangle(int weight, int height)
        {
            int result = (weight * height) / 2;
            return result;
            
        }
        
        
    }
}