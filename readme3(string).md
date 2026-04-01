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

            string textAge = "22";
            int age = Convert.ToInt32(textAge);
            Console.WriteLine("My age is: " + age);
            string TextBigNumber = "12345678";
            long bigNumber = Convert.ToInt64(TextBigNumber);
            Console.WriteLine("Big number: " + bigNumber);

            string textDouble = "23.42";
            double testD = Convert.ToDouble(textDouble);
            Console.WriteLine("Decimal test: " + testD);

            Console.WriteLine(double.MaxValue);
            Console.WriteLine(double.MinValue);

            string textFloat = "33.54";
            float testF = Convert.ToSingle(textFloat);
            Console.WriteLine("Float test: " + testF);

            Console.WriteLine(float.MaxValue);
            Console.WriteLine(float.MinValue);

            string textDecimal = "45.67";
            decimal money = Convert.ToDecimal(textDecimal);
            System.Console.WriteLine("Money: " + money);

            Console.WriteLine(decimal.MaxValue);
            Console.WriteLine(decimal.MinValue);
            Console.ReadLine();

            
        }
    }
}