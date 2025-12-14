using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_13_Assignment
{
    public class Person
    {
        int personID;
        string name;
        string add;

    public Person(int idNum, string FullName, string Address)
        {
            personID = idNum;
            name = FullName;
            add = Address;
        }
        public int idNum
        {
            get { return idNum; }
            set { idNum = value; }
        }
        public string FullName
        {
            get { return FullName; }
            set { FullName = value; }
        }
        public string address
        {
            get { return address; }
            set { address = value; }
        }
    }
}
