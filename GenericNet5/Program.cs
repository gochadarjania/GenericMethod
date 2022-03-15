using System;
using System.Collections.Generic;

namespace GenericNet5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            int[] numbers = new int[] { 2, 3, 4, 5, 6, 23 };
            string[] names = new string[] { "Gocha","Gio", "Levani"};

            Writer(numbers);
            Writer(names);

        }

        public static void Writer<T>(IEnumerable<T> ar)
        {
            foreach (var item in ar)
            {
                Console.WriteLine(item);
            }
        }
    }
}
