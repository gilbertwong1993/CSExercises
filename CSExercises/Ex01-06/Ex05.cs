using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Slight modification to above:
 Write a program that takes a double precision number as input and prints the square root of the number.
 The square root should be rounded to 3 decimal place.*/
//Program written by Gilbert Wong
namespace CSExercises
{
    public class Ex05
    {
        public static void Main(string[] args)
        {
            double A, B;
            Console.WriteLine("Enter a double precision number");
            A = Convert.ToDouble(Console.ReadLine());
            B = System.Math.Sqrt(A);
            Console.WriteLine("The square of the number is {0:.000}",B); 
        }
    }
}
