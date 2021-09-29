using System;

namespace CartesianLinesProgram
{
    class Program
    {
        static void Main(string[] args)
        {

            
                Console.WriteLine("enter values of x1 and y1 corrdinates");
                var x1 = Convert.ToDouble(Console.ReadLine());
                var y1 = Convert.ToDouble(Console.ReadLine());
                Console.WriteLine("enter values of x2 and y2 corrdinates");
                var x2 = Convert.ToDouble(Console.ReadLine());
                var y2 = Convert.ToDouble(Console.ReadLine());

           
                var finalResult = UC1.Distance(x1, x2, y1, y2);
                Console.WriteLine("Distance betweens coordinates {0}, {1} and {2}, {3} is {4}", x1, y1, x2, y2, finalResult);
                UC2.Distance(x1, x2, y1, y2);
                UC3.Distance(x1, x2, y1, y2);






        }
    }
}
