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
            const int vat = 20;

            const double percentVit= vat /100D;

            int balance = 1000;

            Console.WriteLine(balance * (vat/percentVit)); 
            Console.WriteLine(vat);

            const string verision = "1.0.0";
            Console.WriteLine(verision);
            Console.ReadLine();   

            
        }
    }
} 