using System;

namespace Lesmoment1.Deel1
{
    class Program
    {
        static int Sum(int x, int y) => x + y;


        static void Main(string[] args)
        {
            Func<int, int, int> add = Sum;

            int result = add(10, 10);

            Console.WriteLine(result);


            //2de

            Func<int> getRandomNumber = delegate ()
            {
                Random rnd = new Random();
                return rnd.Next(1, 100);
            };

            //3de
            //Action<int> printActionDel = Console.Print;
            //printActionDel(10);


            //or

            //(s) => { return s.Age > 12 && s.Age < 20 };

            //s => s.Age > 12 && s.Age < 20;

            //s => s.Age > 12 && s.Age < 20;

            //() => Console.WriteLine("Parameter less lambda expression");


            //(s, youngAge) => s.Age > youngAge;

            //(Student s, int youngAge) => s.Age >= youngAge;


            //(s, youngAge) =>
            //{
            //    Console.WriteLine("");

            //}

            Console.WriteLine("Hello World");
            string x = "hello";
            

        }
    }
    public static class StringExtension
    {
        public static string SurroundWith(this string s, string extra) => extra + s + extra;
    }
}
