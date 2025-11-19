namespace Week_12_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int PNum;
            Console.WriteLine("How many parts would you like to enter");
            PNum = Convert.ToInt32(Console.ReadLine());
            Parts[] PartArray = new Parts[PNum];
            for (int x = 0; x < PartArray.Length; x++)
            {
                populateParts(ref PartArray[x]);
            }
            static void populateParts(ref Parts p)
            {
                Console.WriteLine("Please enter part number");
                int PNum = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter part name");
                string PName = Convert.ToString(Console.ReadLine()); 
                Console.WriteLine("Please enter part cost");
                double Cost = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please enter part description");
                string PDesc = Convert.ToString(Console.ReadLine());
                p = new Parts(PNum, Cost, PName, PDesc);
            }
            Console.WriteLine("{0,15} {1,10} {2,15} {3,15}", "Part #", "Name", "Cost", "Description");
            for (int y = 0; y < PartArray.Length; y++)
            {
                Console.WriteLine("{0,15} {1,10} {2,15} {3,15}", PartArray[y].PartNum, PartArray[y].PartName, PartArray[y].PartCost, PartArray[y].PartDescription);
            }
            Console.ReadKey();
            Console.WriteLine("Select a part you would like to view?");

            int SelectedPart = Convert.ToInt32(Console.ReadLine());
            PartSelected(ref PartArray[SelectedPart - 1]);

            static void PartSelected(ref Parts p)
            {
                Console.WriteLine("Serial Number: " + p.PartNum);
                Console.WriteLine("Part Name: " + p.PartName);
                Console.WriteLine("Cost: " + p.PartCost.ToString("C"));
                Console.WriteLine("Description: " + p.PartDescription);
            }
            Console.ReadKey();
        }
    }
}
