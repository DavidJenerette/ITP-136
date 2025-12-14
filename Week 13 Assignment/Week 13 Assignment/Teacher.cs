using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_13_Assignment
{
    public class Teacher
    {
        double sal;
        int yos;
        public Teacher(double Salary, int YearsOfService)
        {
            sal = Salary;
            yos = YearsOfService;
        }
        public double Salary
        {
            get { return sal; }
            set { sal = value; }
        }
        public int YearsOfService
        {
            get { return yos; }
            set { yos = value; }
        }
    }
}
