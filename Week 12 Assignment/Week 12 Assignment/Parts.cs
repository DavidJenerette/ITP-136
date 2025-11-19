using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_12_Assignment
{
    public class Parts
    {
        int partNum;
        double partCost;
        string partName, partDescription;
        public Parts(int PNum, double Cost, string PName, string PDesc)
        {
            partNum = PNum;
            partCost = Cost;
            partName = PName;
            partDescription = PDesc;
        }
        public int PartNum
        {
            get { return partNum; }
            set { partNum = value; }
        }
        public double PartCost
        {
            get { return partCost; }
            set { partCost = value; }
        }
        public string PartName
        {
            get { return partName; }
            set { partName = value; }
        }
        public string PartDescription
        {
            get { return partDescription; }
            set { partDescription = value; }
        }
    }
}
