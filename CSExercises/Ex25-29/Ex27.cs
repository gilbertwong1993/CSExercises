using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//C#Exercises No.27
//Program written by Gilbert Wong
namespace CSExercises
{
    public class Ex27
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Program a.");//Program a.
            double X,Y;
            Console.WriteLine("X\tY");
            Console.WriteLine("---------------------------");
            for (X = -5; X < 6; X++)
            {
                Y = 2 * X * X - 4 * X + 3;
                Console.WriteLine("{0:0.0}\t{1:0.0}", X, Y);
            }
            Console.WriteLine("================================");
            Console.WriteLine("Program b.");//Program b.
            int M, N, i;
            for (M = 1; M < 21; M++)
            {
                N = 2 * M * M - 4 * M + 3;
                Console.Write("{0:0.0}", M);
                for (i = 1; i <= N; i++)
                {
                    Console.Write("*");
                }
                Console.Write("\n");
            }
        }
    }
}
