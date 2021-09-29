using System;
using System.Collections.Generic;
using System.Text;

namespace CartesianLinesProgram
{
    class UC1
    {

        public static double Distance(double x1, double x2, double y1, double y2)
        {
            var temp1 = Math.Pow((x2 - x1), 2);
            var temp2 = Math.Pow((y2 - y1), 2);
            var result = Math.Sqrt(temp1 + temp2);
            
            return result;
        } 
    }
}
