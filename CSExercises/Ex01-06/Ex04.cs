using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program that takes a double precision number as input and prints the square root of the number.
//Program written by Gilbert Wong
namespace CSExercises
{
    public class Ex04
    {
        public static void Main(string[] args)
        {
            double A, B;
            Console.WriteLine("Enter a double precision number");
            A = Convert.ToDouble(Console.ReadLine());
            B = System.Math.Sqrt(A);
            Console.WriteLine("The square root of the number is {0}.", B);
        }
    }
}
