using System.Collections.Generic;
using ObjectsFromCSV;

namespace Week_14_CW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Orders> orders = new List<Orders>();
            Console.WriteLine("Welcome to the ice cream shop");
            Console.WriteLine("You will be able to pick one flavor and topping each");

            char moreItems = 'y';
            int counter = 0;
            while (moreItems == 'y')
            {
                Console.WriteLine("Let's get the items for item {0}", counter + 1);
                collectOrder(ref orders);
                counter++;
                Console.WriteLine("Would you like to continue y/n");
                moreItems = Convert.ToChar(Console.ReadLine());
            }
            Console.WriteLine("{0,-15}{1,-20}{2,-20}", "NAME", "FLAVOR", "TOPPING");
            foreach (Orders o in orders)
            {
                Console.WriteLine("{0,-15}{1,-20}{2,-20}", o.OrderName, o.OrderFlavor, o.OrderTopping);
            }
            Console.ReadKey();
        }
            public static void collectOrder(ref List<Orders> o)
             {
                var ListOfFlavors = File.ReadLines("Flavors.csv").Select(line => new Flavors(line)).ToList();
                var ListOfToppings = File.ReadLines("Toppings.csv").Select(line => new Toppings(line)).ToList();
                Console.WriteLine("Name for this orer item");
                string name = Console.ReadLine();
                Console.WriteLine("Which flavor would you like: ");
                foreach (Flavors f in ListOfFlavors) 
                {
                Console.WriteLine($"{f.FlavorID}\t{f.FlavorName}");
                }
                int a = Convert.ToInt32(Console.ReadLine());
                string flavor = ListOfFlavors[a - 1].FlavorName;
                
                Console.WriteLine("Which topping would you like: ");
                foreach (Toppings t in ListOfToppings)
                {
                Console.WriteLine($"{t.ToppingID}\t{t.ToppingName}");
                }
                int b = Convert.ToInt32(Console.ReadLine());
                string topping = ListOfToppings[b - 1].ToppingName;
                o.Add(new Orders (name, flavor, topping));
            }
        }
    }
