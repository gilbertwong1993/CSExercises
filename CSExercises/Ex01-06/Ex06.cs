using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Take a program that takes an integer as input and prints the square root of that number.
//Program written by Gilbert Wong
namespace CSExercises
{
    public class Ex06
    {
        public static void Main(string[] args)
        {
            double A, B;
            Console.WriteLine("Enter an integer");
            A = Convert.ToDouble(Console.ReadLine());
            B = System.Math.Sqrt(A);
            Console.WriteLine("The square of the number is {0}", B); 
        }
    }
}
