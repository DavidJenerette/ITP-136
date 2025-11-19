using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_12_CW
{
    public class Employee
    {
        int employeeNum;
        double salary;
        string lname, fname, position;
        public Employee(int empNum, double s, string ln, string fn, string pos)
        {
            employeeNum = empNum;
            salary = s;
            lname = ln;
            fname = fn;
            position = pos;
        }
        public int EmployeeNum
        {
            get { return employeeNum; }
            set { employeeNum = value; }
        }
        public double Salary
        {
            get { return salary; }
            set { salary = value; }
        }
        public string fName
        {
            get { return fname; }
            set { fname = value; }
        }
        public string lName
        {
            get { return lname; }
            set { lname = value; }
        }
        public string Position
        {
            get { return position; }
            set { position = value; }
        }
    }
}
