namespace Week_14_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
                List<CakeOrder> order = new List<CakeOrder>();
                Console.WriteLine("Welcome to the Reynolds Cake Castle");
                Console.WriteLine("You will be able to pick one design and decoration for each order.");

                char moreOrders = 'y';
                int counter = 0;
                while (moreOrders == 'y')
                {
                    Console.WriteLine("Please pick the options for order #{0}", counter + 1);
                    collectOrder(ref order);
                    counter++;
                    Console.WriteLine("Would you like to continue y/n");
                    moreOrders = Convert.ToChar(Console.ReadLine());
                }
                Console.WriteLine("{0,-15}{1,-20}{2,-20}", "Name", "Design", "Decoration");
                foreach (CakeOrder co in order)
                {
                    Console.WriteLine("{0,-15}{1,-20}{2,-20}", co.OrderName, co.OrderDesign, co.OrderDecorations);
                }
                Console.ReadKey();
            }
            public static void collectOrder(ref List<CakeOrder> co)
        {
            var ListOfDesigns = File.ReadLines("Design.csv").Select(line => new Designs(line)).ToList();
            var ListOfDecorations = File.ReadLines("Decorations.csv").Select(line => new Decorations(line)).ToList();
            Console.WriteLine("What is the name this order is for");
            string name = Console.ReadLine();
            Console.WriteLine("Which design would you like: ");
            foreach (Designs des in ListOfDesigns)
            {
                Console.WriteLine($"{des.DesignID}\t{des.DesignName}");
            }
            int a = Convert.ToInt32(Console.ReadLine());
            string design = ListOfDesigns[a - 1].DesignName;

            Console.WriteLine("Which decoration would you like: ");
            foreach (Decorations dec in ListOfDecorations)
            {
                Console.WriteLine($"{dec.DecorationID}\t{dec.DecorationName}");
            }
            int b = Convert.ToInt32(Console.ReadLine());
            string decoration = ListOfDecorations[b - 1].DecorationName;
            co.Add(new CakeOrder(name, design, decoration));
        }
    }
}
