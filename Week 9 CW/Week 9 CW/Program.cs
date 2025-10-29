using System; using System.Linq;
namespace Week_9_CW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            //string[] names = { "Stephens", "Jordan", "Gretzky", "Ronaldo" };
            //nsole.WriteLine(names[1]);
            //for (int x = 0; x < names.Length; x++)
            {
           //     Console.WriteLine(names[x]);
            }
            int[] nums = { 1, 5, 8 ,9 };
            double[] price = { 12.25, 25.62, 36.75, 42.67 };
            for (int x = 0; x < nums.Length; x++)
            {
                Console.WriteLine(nums[x]);
            }
            for (int x = 0; x < price.Length; x++)
            {
                Console.WriteLine(price[x]);
            }
           // for (int x = 0; x < names.Length; x++)
            {
          //      Console.WriteLine("{0,10}{1,10}", names[x], price[x]);
            }
            string[] names = { "Stephens", "Jordan", "Gretzkey" };
            double[] quiz = new double[3];
            double[] test = new double[3];
            double[] assignment = new double[3];
            for (int x = 0;x < names.Length; x++)
            {
                Console.WriteLine("Please enter the quiz average [0]", names[x]);
                quiz[x] = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please enter the test average [0]", names[x]);
                test[x] = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please enter the assignment average [0]", names[x]);
                assignment[x] = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("{0,15}, {1,20}, {2,10}, {3,10}", "Name", "Quiz", "Test", "Assignment");
                for (int y = 0; y < names.Length; y++)
                {
                    Console.WriteLine("{0,15}, {1,20}, {2,10}, {3,10}", names[y], quiz[y], test[y], assignment[y]);
                }
            }
            int i = 0;
            foreach (var name in names)
            {
                double avg;
                avg = (quiz[i] + test[i] + assignment[i])/ 3;
                Console.WriteLine("{0,10}{1,15}", name, avg.ToString("F2"));
                i++;
            }
            double m = quiz.Max();
            int p = Array.IndexOf(quiz, m);
            Console.WriteLine(names[p] + "has the highest quiz average");
            Array.Sort(names);

            Console.WriteLine(names[0] + " " + names[1] + " " + names[2]);
        }

    }
}
