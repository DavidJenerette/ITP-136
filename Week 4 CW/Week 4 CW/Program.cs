using System.ComponentModel.Design;

namespace Week_4_CW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //if and nested if
            Console.WriteLine("Hello, World!");
            int first = 5;
            int second = 3;
            if (first == second)
            {
                Console.WriteLine("These numbers are equal");
            }
            else
            {
                if (first > second)
                {
                    Console.WriteLine("The first number is greater than the second");
                }
            }
            //Sequence if
            char ch = 'i';
            if (ch == 'A' || ch == 'a')
            {
                Console.WriteLine("vowel");
            }
            else if (ch == 'E' || ch == 'e')
            {
                Console.WriteLine("vowel");
            }
            else if (ch == 'I' || ch == 'i')
            {
                Console.WriteLine("vowel");
            }
            else if (ch == 'O' || ch == 'o')
            {
                Console.WriteLine("vowel");
            }
            else if (ch == 'U' || ch == 'u')
            {
                Console.WriteLine("vowel");
            }
            else
            {
                Console.WriteLine("Consonant");
            }

            //switch statement
            int option, a, b, total;
                Console.WriteLine("Please enter your first number");
                a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please enter your second number");
                b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("1 - add numbers, 2 - subtract, 3 - multiply, 4 - divide");
            option = Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1:
                    total = (a + b);
                    Console.WriteLine("The numbers added are {0} ", total);
                    break;
                case 2:
                    total = (a - b);
                    Console.WriteLine("The numbers subtracted are ", total);
                    break;
                case 3:
                    total = (a * b);
                    Console.WriteLine("The numbers multiplied are ", total);
                    break;
                case 4:
                    total = (a / b);
                    Console.WriteLine("The numbers divided are ", total);
                    break;
                default:
                    Console.WriteLine("You picked a wrong number");
                    break;
            }

            Console.ReadKey();
        }
    }
}
