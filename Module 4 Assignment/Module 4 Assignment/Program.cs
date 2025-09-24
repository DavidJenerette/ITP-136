using System.ComponentModel.Design;
using System.Numerics;

namespace Module_4_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int option;
            double AdultApp = 75, AdultCU = 100, ChildCU = 75, ChildApp = 50, Labs = 25, total, subtotal;
            Console.WriteLine("Hello");
            Console.WriteLine("Please Select an option");
            Console.WriteLine("1 - Sick Appointment, 2 - Check-up");
            option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    option = 1;
                    Console.WriteLine("You chose a Sick Appointment");
                    break;
                case 2:
                    option = 2;
                    Console.WriteLine("You chose a Check-up");
                    break;

            }
            if (option == 1)
            {
                Console.WriteLine("Is the patient an Adult or Child");
                Console.WriteLine("3 - Adult ($75), 4 - Child ($50)");
                option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 3:
                        option = 3;
                        subtotal = AdultApp;
                        Console.WriteLine("Adult Fee = {0}", subtotal.ToString("C"));
                        Console.WriteLine("Were labs done during the visit?");
                        Console.WriteLine("5 - Yes (+$25), 6 - No");
                        option = Convert.ToInt32(Console.ReadLine());

                        switch (option)
                        {
                            case 5:
                                option = 5;
                                total = subtotal + Labs;
                                Console.WriteLine("This is your bill = {0}", total.ToString("C"));
                                break;
                            case 6:
                                option = 6;
                                total = subtotal;
                                Console.WriteLine("This is your bill = {0}", total.ToString("C"));
                                break;
                        }
                        break;
                    case 4:
                        option = 4;
                        subtotal = ChildApp;
                        Console.WriteLine("Child Fee = {0}", subtotal.ToString("C"));
                        Console.WriteLine("Were labs done during the visit?");
                        Console.WriteLine("5 - Yes (+$25), 6 - No");
                        option = Convert.ToInt32(Console.ReadLine());
                        switch (option)
                        {
                            case 5:
                                option = 5;
                                total = subtotal + Labs;
                                Console.WriteLine("This is your bill = {0}", total.ToString("C"));
                                break;
                            case 6:
                                option = 6;
                                total = subtotal;
                                Console.WriteLine("This is your bill = {0}", total.ToString("C"));
                                break;

                        }
                        break;
                }
            }
            if (option == 2)
            {
                Console.WriteLine("Is the patient an Adult or Child");
                Console.WriteLine("7 - Adult ($100), 8 - Child ($75)");
                option = Convert.ToInt32(Console.ReadLine());
                switch (option)
                {
                    case 7:
                        total = AdultCU;
                        Console.WriteLine("This is your bill = {0}", total.ToString("C"));
                        break;
                    case 8:
                        total = ChildCU;
                        Console.WriteLine("This is your bill = {0}", total.ToString("C"));
                        break;
                }

            }
        }
    }
}