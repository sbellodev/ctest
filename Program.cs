// See https://aka.ms/new-console-template for more information
using System;

namespace ctest
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            int [,] arr2d = new int[2,2];
            int [,] arr3x2 = { {1,2}, {3,4}, {5,6} };

            // Console.WriteLine(arr3x2[0, 0]);

            // for (int i = 0; i < arr3x2.GetLength(0); i++)
            // {
            //     for (int j = 0; j < arr3x2.GetLength(1); j++)
            //     {
            //         Console.WriteLine(arr3x2[i, j]);
            //     }
            // }
            Book book = new Book("C# Programming", "S.N. Narayana Murthy");
            Book book2 = new Book();
            Console.WriteLine(Book.count);
            // data types: string, char, int, double, bool, float
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Hello World!");
        }
    }
}