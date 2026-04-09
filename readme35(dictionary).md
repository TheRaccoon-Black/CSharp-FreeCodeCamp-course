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


namespace MyApp
{
    class Program
    {
        static void Main(string[] args)
        {
             
            // Dictionary<int, string> names = new Dictionary<int, string>();
            // names.Add(1, "ojik");
            // names.Add(2, "ojikq");
            // names.Add(3, "ojik3");

                /*Dictionary<int, string> names = new Dictionary<int, string>()
                {
                    //keyValuePair
                    {1, "ojik"},
                    {2, "ojikq"},
                    {3, "ojik3"}
                };

                for ( int i = 0; i < names.Count; i++)
            {
                KeyValuePair<int, string> pair = names.ElementAt(i);
                Console.WriteLine($"{pair.Key} - {pair.Value}");
            }   
            Console.WriteLine(); 

                foreach (var name in names)
                {
                    Console.WriteLine($"Key: {name.Key}, Value: {name.Value}");
                }*/

            Dictionary<string, string> teachers = new Dictionary<string, string>
            {
                {"Math", "ojik"},
                {"History", "alief"},
                {"art", "Dinda"}
            };

            Console.WriteLine(teachers["Math"]);// ojik

            if (teachers.TryGetValue("Math", out string? teacher))//in case accindenly type math instead Math
            {
                Console.WriteLine(teacher);
                teachers["Math"] = "bubu";
            }
            else
            {
                Console.WriteLine("Teacher not found");
            }

            foreach (var item in teachers)
                {
                    Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
                }

                Console.WriteLine();

                // teachers.Remove("Math");

                if (teachers.ContainsKey("Math"))
            {
                teachers.Remove("Math");
            }
            else
            {
                Console.WriteLine("Math not found");
            }
            foreach (var item in teachers)
                {
                    Console.WriteLine($"Key: {item.Key}, Value: {item.Value}");
                }
            Console.ReadLine();
        } 
    }
}