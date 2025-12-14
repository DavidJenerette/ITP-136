using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FInal_Assignment
{
    public class Department : Employee
    {
        public Department(int id, string fullname, string department) : base (id, fullname)
        {
            Depart = department;
        }
        public string Depart { get; set; }
    }
}
