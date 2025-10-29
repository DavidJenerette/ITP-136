using System; using System.Linq;
namespace Week_9_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] CarManufacturer = new string[3];
            string[] CarModel = new string[3];
            double[] CarCost = new double[3];
                for (int x = 0; x < 3; x++)
                {
                    Console.WriteLine("Please enter the manufacturer of the car [0]", CarManufacturer[x]);
                    CarManufacturer[x] = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Please enter the model of the car [0]", CarModel[x]);
                    CarModel[x] = Convert.ToString(Console.ReadLine());
                    Console.WriteLine("Please enter the cost of the car [0]", CarCost[x]);
                    CarCost[x] = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine("{0,10}, {1,10}, {2,10}", "Manufacturer", "Model", "Cost");
                    for (int y = 0; y < 3; y++)
                    {
                        Console.WriteLine("{0,10}, {1,10}, {2,12}", CarManufacturer[y], CarModel[y], CarCost[y]);
                    }
                }  
                double m = CarCost.Max();
                int p = Array.IndexOf(CarCost, m);
                Console.WriteLine(CarManufacturer[p] + " cost's the most");
        }
    }
}
