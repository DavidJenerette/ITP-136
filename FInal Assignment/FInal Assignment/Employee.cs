using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FInal_Assignment
{
    public class Employee
    {
        public Employee(int empid, string fullName)
        {
            EmployeeID = empid;
            FullName = fullName;
        }
        public int EmployeeID { get; set; }
        public string FullName { get; set; }
    }
}
