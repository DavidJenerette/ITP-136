using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Week_13_Assignment
{
    public class Student
    {
        string maj;
        string adv;
        public Student(string Major, string Advisor)
        {
            maj = Major;
            adv = Advisor;
        }
        public string Major
        {
            get { return maj; }
            set { maj = value; }
        }
        public string Advisor
        {
            get { return adv; }
            set { adv = value; }
        }
    }
}
