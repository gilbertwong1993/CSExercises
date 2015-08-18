using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Write a program that would take as input the value of x and calculate & output the value of y using the formula:
 y = 2*x*x - 4*x + 3*/
//Program written by Gilbert Wong
namespace CSExercises
{
    public class Ex09
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter x");
            var x = Convert.ToDouble(Console.ReadLine());
            double y = 2 * x * x - 4 * x + 3;
            Console.WriteLine("y = " + y);
        }
    }
}
