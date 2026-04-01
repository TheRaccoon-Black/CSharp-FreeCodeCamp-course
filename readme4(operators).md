using System;
using System.Collections.Generic;
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

            int age = 23;

           age++;
        //    age = age +1;
        //    age += 1;

        //that 3 way to increase the value of age by 1
           Console.WriteLine(age);
           age--;
           Console.WriteLine(age);

           string name = "ojik";
           name = name + "is programmer";

           Console.WriteLine(name); 

           char ch = 'a';
        //    ch+= 'b';
            ch++;
              Console.WriteLine(ch);
           Console.ReadLine();   

            
        }
    }
} 