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
            int N = Convert.ToInt32(Console.ReadLine());
            int a;
            int b = N;
            for (a = N; a >= 1; a--)
            {
                if (N % a == 0) 
                {
                    b = b - a;
                }
            }
            if (b + N == 0)
            {
                Console.WriteLine("This number is a perfect number.");
            }
            if (b + N != 0)
            {
                Console.WriteLine("This number is not a perfect number.");
            }
        }
    }
}
