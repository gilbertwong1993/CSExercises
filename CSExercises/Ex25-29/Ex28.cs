using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//C#Exercises No.28
//Program written by Gilbert Wong
namespace CSExercises
{
    public class Ex28
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            int N = Convert.ToInt32(Console.ReadLine());
            double a;
            double M = 0;
            for (a = N; a >= 1; a--)
            {
                if (N % a == 0) 
                    M = M + 1;
            }
            if (M >= 3 || N == 1)
            {
                Console.WriteLine("This number is not a prime.");
            }
            else
            {
                Console.WriteLine("This number is a prime.");
            }
        }
    }
}
