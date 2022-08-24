using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area_Calculator
{
     public class AreaMathForm
     {
        public static decimal SqureArea(decimal length)
        {
            return length*length;
        }
        public static decimal RecArea(decimal length, decimal width)
        {
            return length * width;
        }
        public static decimal TriArea(decimal width, decimal height)
        {
            return width * height/2;
        }
        public static decimal RoundArea(decimal diam)
        {
            return (decimal)3.1415926*(diam/2) * (diam / 2);
        }
    }
}
