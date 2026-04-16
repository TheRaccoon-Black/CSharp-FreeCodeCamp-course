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
using System.Net;


namespace MyApp
{
    class Program
    {

        static void Main(string[] args)
        {

           /*
           - create a int and try to convert any string to an int
           - notice the error, write a try..catch handler around it
           - catch the error and output the error message
           - without changing the current code
           -
           - why is this a bad situation and how can we now if its been converted
           -
           - create a custom try parse function
           - find the real function and copy return type/params
           - read the tooltip it gives you, to give you ideas on what to do
           */
          /* bool success = false;

            try{
                Console.Write("enter a number: ");
                int num = Convert.ToInt32(Console.ReadLine());
                success = true;

            }catch(Exception e)
            {
                Console.WriteLine($"Error: {e.Message}");
            }

            Console.WriteLine(success? "yey": "oh nooo");*/
            if (TryParse(Console.ReadLine() ?? "",out int result))
            {
                Console.WriteLine("yey "  + result);
            }
            else
            {
                Console.WriteLine("Ohhh no");
            }
            Console.ReadLine();

        } 

        static bool TryParse(string input, out int result)
        {
            result = -1;
            try
            {
                result = Convert.ToInt32(input);
                return true;
            }catch(Exception)
            {
                return false;
            }
        }
        //06:25:59
        
    }
}