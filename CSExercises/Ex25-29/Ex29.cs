using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//C#Exercises No.29
//Program written by Gilbert Wong
namespace CSExercises
{
    public class Ex29
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            double N = Convert.ToDouble(Console.ReadLine());
            double a;
            double c = N;
            for (a = N; a >= 1; a--)
            {
                double b = N / a;
                if (b - Math.Floor(b) == 0)
                {
                    c = c - b;
                }
            }
            if (c + N == 0) 
                {
                   Console.WriteLine("This number is a perfect number.");
                }
            if (c + N != 0)
                {
                   Console.WriteLine("This number is not a perfect number.");
                }
        }
    }
}
