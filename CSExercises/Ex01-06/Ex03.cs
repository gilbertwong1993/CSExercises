using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Write a program that takes a double precision number as input and prints the square of that number.
//Program written by Gilbert Wong
namespace CSExercises
{
    public class Ex03
    {
        public static void Main(string[] args)
        {
            double A;
            Console.WriteLine("Enter a double precision number");
            A = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("The square of the number is " + A * A);  
        }
    }
}
