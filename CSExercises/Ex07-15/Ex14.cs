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
            var a = Convert.ToDouble(Console.ReadLine());
            var b = Convert.ToDouble(Console.ReadLine());
            var c = Convert.ToDouble(Console.ReadLine());
            double s = (a + b + c) * 0.5;
            double AREA = Math.Sqrt(s*(s-a)*(s-b)*(s-c));
            Console.WriteLine("The area of this triangle is {0}.",AREA);
        }
    }
}