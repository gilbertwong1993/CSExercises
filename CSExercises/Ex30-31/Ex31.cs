using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//C#Exercises No.31
//Program written by Gilbert Wong
namespace CSExercises
{
    public class Ex31
    {
        public static void Main(string[] args)
        {
            int N;
            for (N = 1; N <= 1000; N++)
            {
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
                    Console.WriteLine(N);
                }

            }
        }
    }
}