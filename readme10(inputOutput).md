using System;
using System.Collections.Generic;
using System.ComponentModel.Design.Serialization;
using System.Drawing;
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

            // Console.WriteLine("My name is ojik");
            Console.Write("Type your name: ");
            string? name = Console.ReadLine(); //dia akan warning jika tanpa ?, tandanya tidak dapat null jika ada ? berati bisa null.
            // Console.WriteLine(name);

            Console.Write("Type your age: ");
            int age = Convert.ToInt32(Console.ReadLine());
            // string? age = Console.ReadLine();
            // Console.WriteLine(age);
            Console.WriteLine();
            Console.WriteLine("yourname is "+name+" and your age is "+ age);
            Console.ReadLine();   

            
        }
    }
} 