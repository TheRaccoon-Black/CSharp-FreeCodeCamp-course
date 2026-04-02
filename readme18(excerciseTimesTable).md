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
            Console.Write("Enter a number to times table: ");
            int num = Convert.ToInt32(Console.ReadLine());

            for ( int i = 1; i <= 10; i++)
            {
                Console.WriteLine("|{0} x {1} | = {2} ", i, num, i*num);
            }



            Console.ReadLine();
        }
    }
}