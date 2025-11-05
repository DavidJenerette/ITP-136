namespace Week_10_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Food food1 = new Food();
            Food food2 = new Food();
            food1.FoodID = 7;
            food1.Name = "Shrimp Scampi";
            food1.Description = " Pasta dish with shrimp in a sauce.";
            food1.Cost = 12.99;
            food2.FoodID = 8;
            food2.Name = "Lobster Mac & Cheese";
            food2.Description = " Smoky mac & cheese with lobster.";
            food2.Cost = 14.49;
            Console.WriteLine("There are 2 seafood options listed on the menu");
            Console.WriteLine("-------------------------------------Seafood-------------------------------------");
            Console.WriteLine("{0,0}{1,13}{2,34}{3,27}", "FoodID", "Name", "Description", "Cost");
            Console.WriteLine("{0,3}{1,20}{2,43}{3,15}", food1.FoodID, food1.Name, food1.Description, food1.Cost.ToString("C"));
            Console.WriteLine("{0,3}{1,24}{2,38}{3,16}", food2.FoodID, food2.Name, food2.Description, food2.Cost.ToString("C"));
            Console.ReadKey();
        }
    }
}
