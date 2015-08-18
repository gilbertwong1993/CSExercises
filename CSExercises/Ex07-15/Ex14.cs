using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Consider the simple Geometric example of determining the area of a triangle,given the lengths of its three sides a,b and c.
 Use the formula: AREA = SQUAREROOT[s(s-a)(s-b)(s-c)]
 where s = (a+b+c)/2
 Does your program always work? If not alter it to consider situations fro which it fails.*/
//Program writtem by Gilbert Wong
namespace CSExercises
{
    public class Ex14
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the three sides of a triangle");
            double a = Convert.ToDouble(Console.ReadLine());
            double b = Convert.ToDouble(Console.ReadLine());
            double c = Convert.ToDouble(Console.ReadLine());
            double s = (a + b + c) * 0.5;
            double AREA = Math.Sqrt(s * (s - a) * (s - b) * (s - c));
            if (a + b > c && b + c > a && a + c > b)
                Console.WriteLine("The area of this triangle is {0}.",AREA);
            else
                Console.WriteLine("Please enter the correct numbers.");
        }
    }
}