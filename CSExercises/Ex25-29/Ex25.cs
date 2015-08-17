using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//C#Exercises No.25
//Program written by Gilbert Wong
namespace CSExercises
{
    public class Ex25
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            double N = Convert.ToInt32(Console.ReadLine());
            double a;
            for (a = N; a >= 1; a--)
            {
                double b = N / a;
                if (b - Math.Floor(b) == 0)
                    Console.WriteLine(b + " is a factorial of the number.");
            }
            Console.WriteLine("================================");
            for (a = 1; a <= N; a++)
            {
                double b = N / a;
                if (b - Math.Floor(b) == 0)
                    Console.WriteLine(b + " is a factorial of the number.");
            }
        }
    }
}
