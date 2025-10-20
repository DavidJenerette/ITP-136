namespace Week_6_CW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int a, b;
            a = 7;
            WelcomeMessage();
            for (int k = 0; k < 3; k++)
            {
                a = AskNumber();
                b = AskNumber();
                AddNumbers(a, b);
            }
            Console.WriteLine("Thank you for using the calculator");
            Console.ReadKey();
        }

        static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to my calculator");

        }

        static int AskNumber()
        {
            int x;
            Console.WriteLine("Please enter a number");
            x = Convert.ToInt32(Console.ReadLine());
            return x;
        }
        
        static void AddNumbers(int num1, int num2)
        {
            int total = num1 + num2;
            Console.WriteLine("Your total is {0} ", total);
        }
    }
}
