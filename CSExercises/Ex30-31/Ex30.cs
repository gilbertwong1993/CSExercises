using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//C#Exercises No.30
//Program written by Gilbert Wong
namespace CSExercises
{
    public class Ex30
    {
        public static void Main(string[] args)
        {
            int a, N;
            for (N = 5; N <= 10000; N++)
            {
                int M = 0;
                for (a = 1; a <= N; a++)
                {
                    if (N % a == 0)
                    {
                        M++;
                    }
                }
                    if (M <= 2) 
                    {
                        Console.WriteLine(N);
                    }
             }
         }
     }
}
