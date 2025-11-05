using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_10_CW
{
    public class Employee
    {
        int empID;
        string fName, lName;
        public int EmployeeID
        {
            get { return empID; } //get method
            set { empID = value; } // set method
        }
        public string LastName
        {
            get { return lName; } //get method
            set { lName = value; } // set method
        }
        public string FirstName
        {
            get { return fName; } //get method
            set { fName = value; } // set method
        }
    }
}