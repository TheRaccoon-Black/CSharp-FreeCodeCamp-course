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
             double value = 100D / 12.34;

             Console.WriteLine(value);
            //  Console.WriteLine(string.Format("{0} {1}", value, 1000));  //8,103727714748784 1000
             Console.WriteLine(string.Format("{0:0}", value)); //8
             Console.WriteLine(string.Format("{0:0.0}", value)); //8,1
             Console.WriteLine(string.Format("{0:0.00}", value)); //8,10
             Console.WriteLine();

            //  double money = 10D / 3D; //3,3333333
             double money = -10D / 3D; //3,3333333
            Console.WriteLine(money);
            // Console.WriteLine(string.Format("my money is $ {0:0.00}", money));
            Console.WriteLine(string.Format("-Rp10/Rp3 =  Rp {0:0.00}", money)); //-$10/$3 =  $ -3,33
            Console.WriteLine(money.ToString("C")); //-Rp3
            Console.WriteLine(money.ToString("C0")); //-Rp3
            Console.WriteLine(money.ToString("C1")); //-Rp3,3
            Console.WriteLine(money.ToString("C2")); //-Rp3,33

            Console.WriteLine();
            Console.WriteLine(money.ToString("C",CultureInfo.CurrentCulture)); //-Rp3
            Console.WriteLine(money.ToString("C", CultureInfo.CreateSpecificCulture("en-GB"))); //-£3.33
            Console.WriteLine(money.ToString("C", CultureInfo.CreateSpecificCulture("en-US"))); //-$3.33
            Console.WriteLine(money.ToString("C", CultureInfo.CreateSpecificCulture("en-UA"))); // UAH3.33

            


             Console.ReadLine();
        }
    }
}