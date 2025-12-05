using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week_14_Assignment
{
    internal class CakeOrder
    {
        public CakeOrder(string n, string des, string dec)
        {
            OrderName = n;
            OrderDesign = des;
            OrderDecorations = dec;
        }

        public string OrderName { get; set; }
        public string OrderDesign { get; set; }
        public string OrderDecorations { get; set; }
    }
}
