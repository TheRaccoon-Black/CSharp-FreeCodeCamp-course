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
            Console.Write("Enter a day of week: ");
            int day = Convert.ToInt32(Console.ReadLine());

            switch (day)
            {
                case 1: Console.WriteLine("monday");
                break;
                case 2: Console.WriteLine("Tuesday");
                break;
                case 3: Console.WriteLine("wednesday");
                break;
                case 4: Console.WriteLine("thursday");
                break;
                case 5: Console.WriteLine("Friday");
                break;
                case 6: Console.WriteLine("Saturday");
                break;
                case 7: Console.WriteLine("Sunday");
                break;
                default: Console.WriteLine("Invalid day");
                break;
            }
            
            Console.ReadLine();   

            
        }
    }
}  