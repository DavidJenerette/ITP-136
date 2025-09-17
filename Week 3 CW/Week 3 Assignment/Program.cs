using System.Numerics;

namespace Week_3_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int num1 = 5;
            double num2 = 28.89;
            string FirstName = "David";
            bool bool1 = true;
            char char1 = 'a';
            int num3, num4, num5;
            double a = 0, b = 0, c = 0;
            double var1;
            double total;
            string InputString = "2";
            Console.WriteLine("Enter your first number");
            InputString = Console.ReadLine();
            a=Convert.ToDouble(InputString);
            Console.WriteLine("Enter your second number");
            InputString = Console.ReadLine();
            b=Convert.ToDouble(InputString);
            Console.WriteLine("Enter your third number");
            InputString = Console.ReadLine();
            c=Convert.ToDouble(InputString);
            total = (a + b + c) / 3;
            Console.WriteLine("This is your total: " + total);
            Console.ReadKey();
        }
         
    }
}
