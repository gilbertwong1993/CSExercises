using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Write a program that reads the (x,y) coordinates of two points.
 You can ask the user to enter four real values(do it in order of x1,y1,x2,y2).
 Compute the distance between the two points using the formula:
 Distance = Square root of [(x2-x1)^2+(y2-y1)^2] */
//Program written by Gilbert Wong
namespace CSExercises
{
    public class Ex10
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter four real values");
            double x1 = Convert.ToDouble(Console.ReadLine());
            double y1 = Convert.ToDouble(Console.ReadLine());
            double x2 = Convert.ToDouble(Console.ReadLine());
            double y2 = Convert.ToDouble(Console.ReadLine());
            double A = (x2 - x1) * (x2 - x1) + (y2 - y1) * (y2 - y1);
            double B = System.Math.Sqrt(A);
            Console.WriteLine("Distance = "+B);
        }
    }
}
