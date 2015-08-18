using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Write a program that would take as input a temperature in Centigrade scale and convert it to Fahrenheit
 - the number can be integer or real.
 Use the formula: F = 1.8C + 32*/
//Program written by Gilbert Wong
namespace CSExercises
{
    public class Ex08
    {
        public static void Main(string[] args)
        {
            double C, F;
            Console.WriteLine("Enter the temperature in Centigrade");
            C = Convert.ToDouble(Console.ReadLine());
            F = 1.8 * C + 32;
            Console.WriteLine("The temperature in Centigrade is {0}.", F);
        }
    }
}
