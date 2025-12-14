using System.Net.NetworkInformation;

namespace FInal_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
            /* This is program that is currently in testing to help organize and manage a company's employees by being able to quickly
             * add and view current employees. An example list of 5 employees will be displayed at the beginning to show the layout of the list.
             * You will then be able to add employee ID's, Names, and Departments. Since this program is in a beta state there may be problems or
             * missing common features. Please contact the email provided within the program for any suggestions, help, and bug reports.*/
        {
            Console.WriteLine("Welcome to the Employee Viewer (Beta ver. 0.7.2)");
            Console.WriteLine("Please report any problems to ReynoldsTech@gmail.com");
            DepartmentList();
            Console.ReadKey();
            Console.WriteLine("Thank you for using the employee viewer");
            Console.ReadKey();
        }
        static void DepartmentList()
        {
            List<Department> depList = new List<Department>();
            depList.Add(new Department(1, "Helen Davis", "Marketing"));
            depList.Add(new Department(2, "Steven Johson", "CEO"));
            depList.Add(new Department(3, "John Doe", "Sales"));
            depList.Add(new Department(4, "Jane Doe", "Sales"));
            depList.Add(new Department(5, "Leon Jones", "HR"));
            foreach (Department de in depList)
            {
                Console.WriteLine(de.EmployeeID + "\t" + de.FullName + "\t" + de.Depart);
            }
            Console.WriteLine("Please enter the number of employees you wish to add");
            int Amount = Convert.ToInt32(Console.ReadLine());
            for (int x = 0; x < Amount; x++)
            {
                try
                {
                    Console.WriteLine("Enter the Employee ID");
                    int empID = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Enter the Full Name");
                    string fullName = Console.ReadLine();
                    Console.WriteLine("Enter the Department");
                    string department = Console.ReadLine();
                    depList.Add(new(empID, fullName, department));
                }
                catch (Exception e)
                {
                    Console.WriteLine("Invalid Input, Please Restart and Try Again");
                    Console.WriteLine("Exception Caught " + e.ToString());
                }
            }
            Console.ReadKey();
            foreach (Department de in depList)
            {
                Console.WriteLine(de.EmployeeID + "\t" + de.FullName + "\t" + de.Depart);
            }
        }
}
}
    