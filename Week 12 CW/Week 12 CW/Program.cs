using System;

namespace Week_12_CW
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Employee emp1 = new Employee(1313, 50000.99, "Stephens", "David", "Programmer");
            Console.WriteLine(emp1.EmployeeNum + " " + emp1.fName + " " + emp1.lName);

            int numEmp;
            Console.WriteLine("How many employees would you like to enter");
            numEmp = Convert.ToInt32(Console.ReadLine());
            Employee[] empArray = new Employee[numEmp];
            for (int x = 0; x < empArray.Length; x++)
            {
                populateEmployee(ref empArray[x]);
            }
            static void populateEmployee(ref Employee e)
            {
                Console.WriteLine("Please enter employee number");
                int empNum = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Please enter employee salary");
                double a = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("Please enter employee first name");
                string lastName = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Please enter employee last name");
                string firstName = Convert.ToString(Console.ReadLine());
                Console.WriteLine("Please enter employee position");
                string posit = Convert.ToString(Console.ReadLine());
                e = new Employee(empNum, a, firstName, lastName, posit);
            }
            Console.WriteLine("{0,15} {1,20} {2,15} {3,15} {4,20}", "Employee #", "First", "Last", "Salary", "Postion");
            for (int y = 0; y < empArray.Length; y++)
            {
                Console.WriteLine("{0,15}, {1,20}, {2,15}, {3,15}, {4,20}", empArray[y].EmployeeNum, empArray[y].fName, empArray[y].lName, empArray[y].Salary, empArray[y].Position);
            }
            for (int z = 0; z < empArray.Length; z++)
            {
                Console.WriteLine("{0,3}{1,15}{2,20}{3,20}", z + 1, empArray[z].EmployeeNum, z, empArray[z].fName, z, empArray[z].lName);
            }
            Console.WriteLine("Which employee would you like to modify, enter the number below");

            int SelectedEmployee = Convert.ToInt32(Console.ReadLine());
            modifyEmployee (ref empArray[SelectedEmployee - 1]);
            
            static void modifyEmployee(ref Employee e)
            {
                Console.WriteLine("Would you like to update \n 1.Employee Number, \n 2.Last Name, \n 3.First Name, \n 4.Position \n 5.Salary");
                int userInput = Convert.ToInt32(Console.ReadLine());
                if (userInput == 1)
                {
                    Console.WriteLine("What is the corrected Employee Number");
                        int newNum = Convert.ToInt32(Console.ReadLine());
                    e.EmployeeNum = newNum;
                }
                else if (userInput == 2)
                {
                    Console.WriteLine("What is the corrected Last Name");
                    string lname = Console.ReadLine();
                    e.lName = lname;
                }
                else if (userInput == 3)
                {
                    Console.WriteLine("What is the corrected First Name");
                    string fname = Console.ReadLine();
                    e.fName = fname;
                }
                else if (userInput == 4)
                {
                    Console.WriteLine("What is the corrected Position");
                    string Position = Console.ReadLine();
                    e.Position = Position;
                }
                else if (userInput == 5)
                {
                    Console.WriteLine("What is the corrected Salary");
                    double salary = Convert.ToDouble(Console.ReadLine());
                    e.Salary = salary;
                }
                else
                {
                    Console.WriteLine("You did not input a valid number");
                }
            }
        }
    }
}
