using System;
using System.IO;
using System.Linq;
using System.Collections.Generic;

namespace CustomDicitonary
{

    public class Program
    {
        public static void Main()
        {
            MyDicitonary<string, string>
            test = new MyDicitonary<string, string>();
            test.Add("ad", "Ekber");
            test.Add("soyad", "quliyev");
            //test.Add("ad","Elnur");
            Console.WriteLine(test.Length);
            foreach (var key in test.Keys)
            {
                Console.WriteLine(key);
            }
        }
    }
}