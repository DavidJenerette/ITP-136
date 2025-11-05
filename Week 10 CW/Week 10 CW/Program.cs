namespace Week_10_CW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee();
            Employee emp2 = new Employee();
            emp1.EmployeeID = 1234;
            emp1.FirstName = "David";
            emp1.LastName = "Jenerette";
            Console.WriteLine("Enter EmployeeID");
            emp2.EmployeeID = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter First Name");
            emp2.FirstName = Console.ReadLine();
            Console.WriteLine("Enter Last Name");
            emp2.LastName = Console.ReadLine();
            /*emp2.EmployeeID = 2323;
            emp2.FirstName = "Micheal";
            emp2.LastName = "Jordan";*/
            Console.WriteLine("{0,10}{1,10}{2,10}", "EmployeeID", "First", "Last");
            Console.WriteLine("{0,10}{1,10}{2,10}", emp1.EmployeeID, emp1.FirstName, emp1.LastName);
            Console.WriteLine("{0,10}{1,10}{2,10}", emp2.EmployeeID, emp2.FirstName, emp2.LastName);
            emp1.LastName = "Smith";
            Console.WriteLine("{0,10}{1,10}{2,10}", emp1.EmployeeID, emp1.FirstName, emp1.LastName);
            Console.ReadKey();
        }
    }
}
