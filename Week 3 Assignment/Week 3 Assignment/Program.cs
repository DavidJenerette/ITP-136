using System.ComponentModel.DataAnnotations;

namespace Week_3_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double a, b, c;
            double num1 = 0.06;
            double total;
            double subtotal;
            double tax;
            string InputString;
            Console.WriteLine("--Welcome to Herald's Auto Repairs--");
            Console.WriteLine("All repair bills are subject to a 6% tax");
            Console.WriteLine("Please enter the total for the oil change");
            InputString = Console.ReadLine();
            a = Convert.ToDouble(InputString);
            Console.WriteLine("Please enter the total for the new tires");
            InputString = Console.ReadLine();
            b = Convert.ToDouble(InputString);
            Console.WriteLine("Please enter the total for the inspection");
            InputString = Console.ReadLine();
            c = Convert.ToDouble(InputString);
            subtotal = a + b + c;
            tax = subtotal * num1;
            total = subtotal + tax;
            Console.WriteLine("Here is your total before taxes: " + subtotal.ToString("C"));
            Console.WriteLine("Here is your tax: " + tax.ToString("C"));
            Console.WriteLine("Here is your total after taxes: " + total.ToString("C"));
            Console.WriteLine("Thank you for coming");

        }
    }
}
