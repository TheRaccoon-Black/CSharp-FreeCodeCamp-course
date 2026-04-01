using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {

            int age = 22;
            Console.WriteLine("My age is: " + age);
            long bigNumber = 12345678L;
            Console.WriteLine("Big number: " + bigNumber);


            double testD = 23.42D ;
            Console.WriteLine("Decimal test: " + testD);

            Console.WriteLine(double.MaxValue);
            Console.WriteLine(double.MinValue);


            float testF = 23.42F;
            Console.WriteLine("Float test: " + testF);

            Console.WriteLine(float.MaxValue);
            Console.WriteLine(float.MinValue);


            decimal money = 12.5M;
            System.Console.WriteLine("Money: " + money);

            Console.WriteLine(decimal.MaxValue);
            Console.WriteLine(decimal.MinValue);
            Console.ReadLine();

            
        }
    }
}