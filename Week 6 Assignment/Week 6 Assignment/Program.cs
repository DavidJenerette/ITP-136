using System.Net.NetworkInformation;
using System.Reflection.PortableExecutable;

namespace Week_6_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WelcomeStatement();
            Console.ReadKey();
            MagicNumber();
            Console.ReadKey();
            FindArea();
            Console.ReadKey();
            Console.WriteLine("Your local tax rate is {0} ", LocalTaxRate() + ("%"));
            Console.ReadKey();
        }

        static void WelcomeStatement()
        {
            Console.WriteLine("Welcome to My Method Examples");
        }

        static int MagicNumber()
        {
            int SecretNumber = 82;
            Console.WriteLine("The magic number is {0} ", SecretNumber);
            return SecretNumber;
        }

        static void FindArea()
        {
            int x, y, total;
            Console.WriteLine("Please enter the first number");
            x = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the second number");
            y = Convert.ToInt32(Console.ReadLine());
            total = x * y;
            Console.WriteLine("Your total is {0} ", total);
        }

        static int LocalTaxRate()
        {
            int LocalTax;
            Console.WriteLine("Please enter your local tax rate");
            LocalTax = Convert.ToInt32(Console.ReadLine());
            return LocalTax;
        }
    }
}
