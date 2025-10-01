using System;
using System.Numerics;

namespace Week_5_CW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b, total;
            Console.WriteLine("Hello, World!");
            a = 0;
            b = 5;
            while (a <= b)
            {
                Console.WriteLine(a);
                a++;

            }
            for (int k = 0; k < 3; k++)
            {

                Console.WriteLine(k);
            }
            Console.WriteLine("Welcome to the calculator");
            for (int k = 0; k < 5; k++)
            {
                Console.WriteLine("Enter the first number");
                a = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Enter the second number");
                b = Convert.ToInt32(Console.ReadLine());
                total = a + b;
                Console.WriteLine("This is your total " + total);
                Console.ReadKey();
            }
        }
    }
}
