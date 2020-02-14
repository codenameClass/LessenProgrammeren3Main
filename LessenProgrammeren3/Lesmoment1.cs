using System;
using System.Collections.Generic;
using System.Text;

namespace Lesmoment1
{
    class Program
    {
        public delegate void Print(int value);

        static void Main()
        {
            Print printDel = PrintNumber;
            printDel(1000);
            printDel(2000);
            printDel(30000);
            printDel(500000);

        }

        public static void PrintNumber(int num) => Console.WriteLine("Number: {0,-12:N0}", num);
    }
}
