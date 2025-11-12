namespace Week_11_CW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            int num1, num2;
            double total;
            Console.WriteLine("Please enter the first number");
            num1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter the second number");
            num2 = Convert.ToInt32(Console.ReadLine());
            try
            {
                total = num1 / num2;
                Console.WriteLine("This is your total " + total);
            }
            catch (DivideByZeroException e)
            {
                Console.WriteLine("You cannot divide by zero");
                Console.WriteLine(e.ToString());
            }
            Console.ReadKey();

            string[] numberArray = { "Gretsky", "Jordan", "Ruth" };
            Console.WriteLine("Enter the element you want to see");
            int elementNumber = Convert.ToInt32(Console.ReadLine());
            try
            {
                Console.WriteLine(numberArray[elementNumber]);
            }
            catch (IndexOutOfRangeException e)
            {
                Console.WriteLine("You must enter a number between 0-2");
                Console.WriteLine("Exception Caught: " + e.ToString());
            }
        }
    }
}
