using System;
using System.Collections.Generic;
using System.Text;

namespace CartesianLinesProgram
{
    class UC3
    {
        public static double Distance(double x1, double x2, double y1, double y2)
        {
            var temp1 = Math.Pow((x2 - x1), 2);
            var temp2 = Math.Pow((y2 - y1), 2);
            var result = Math.Sqrt(temp1 + temp2);


            if (temp2.CompareTo(temp1) < 0)
            {
                Console.WriteLine("Line1 length is greater");
            }
            else if (temp2.CompareTo(temp1) > 0)
            {
                Console.WriteLine("Line2 length is greater");
            }
            else
            {
                Console.WriteLine("both lines are equal");
            }
            return result;

        }

    }
}
