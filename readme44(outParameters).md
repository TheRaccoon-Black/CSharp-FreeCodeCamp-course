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


namespace MyApp
{
    class Program
    {

        static void Main(string[] args)
        {
            int num = 0;
            bool success = Test(out num);


            //int tryParse("123", out int result);

            List<string> shoppingList = new List<string>
            {
              "coffee", "milk"  
            };

            Console.WriteLine(shoppingList.IndexOf("coffee"));//0
            // Console.WriteLine(FindInList("coffee",shoppingList,out int index));
            // Console.WriteLine(index);

            if (FindInList("coffee", shoppingList,out int index))
            {
                Console.WriteLine($"Found coffee at index {index}");
            }
            else
            {
                Console.WriteLine("not found");
            }


            Console.ReadLine();

        } 
            //out parameter digunakan untuk mengembalikan nilai dari suatu metode
            //contoh penggunaan out parameter:
            //int result;
            //bool success = Test(out result);
            //Console.WriteLine(result);
            //kapan dipakai kapan tidak ada nilai yang dikembalikan jika metode tidak berhasil memenuhi kondisi yang diinginkan, maka nilai result tidak berubah

        static bool FindInList(string S, List<string> list, out int index)
        {
            index = -1;
            for( int i = 0; i < list.Count(); i++)
            {
                if (list[i].ToLower().Equals(S.ToLower()))
                {
                    index = i;
                }
            }

            return index > -1;
        }

        static bool Test(out int num)
        {
            num = 5;
            return true;
        }
       
        
    }
}