using System.Runtime.CompilerServices;

namespace Week_5_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int StartingNumber = 0, EndingNumber = 100, Counter = 0;
            Console.WriteLine("Welcome to the Counter");
            while(StartingNumber <= EndingNumber) 
            {
                Console.WriteLine("The counter has currently counted: " + Counter++ + (" times"));
                Console.WriteLine(StartingNumber++ + (" Sheep."));
                Console.ReadKey();
               
            }
            Console.WriteLine("You Reached " + EndingNumber + ("!!!"));
            Console.ReadKey();
        } 
    }
}
