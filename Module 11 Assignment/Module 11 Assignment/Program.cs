
namespace Module_11_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            decimal x, y;
            
            decimal total;
            int option;
            Console.WriteLine("Please input a number for variable 'x'");
            x = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Please input a number for variable 'y'");
            y = Convert.ToDecimal(Console.ReadLine());
            Console.WriteLine("Please select which operation you want to use");
            Console.WriteLine("1: Addition, 2: Subtraction, 3: Multiplication, 4: Division");
            option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    option = 1;
                    try
                    {
                        total = x + y;
                        Console.WriteLine("This is your total " + total);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("There was an error with your input");
                        Console.WriteLine(e.ToString());
                    }
                    Console.ReadKey();
                    break;
                case 2:
                    option = 2;
                    try
                    {
                        total = x - y;
                        Console.WriteLine("This is your total " + total);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("There was an error with your input");
                        Console.WriteLine(e.ToString());
                    }
                    Console.ReadKey();
                    break;
                case 3:
                    option = 3;
                    try
                    {
                        total = x * y;
                        Console.WriteLine("This is your total " + total);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("There was an error with your input");
                        Console.WriteLine(e.ToString());
                    }
                    Console.ReadKey();
                    break;
                case 4:
                    option = 4;
                    try
                    {
                        total = x / y;
                        Console.WriteLine("This is your total " + total);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine("There was an error with your input");
                        Console.WriteLine(e.ToString());
                    }
                    Console.ReadKey();
                    break;
            }
        }
    }
}
