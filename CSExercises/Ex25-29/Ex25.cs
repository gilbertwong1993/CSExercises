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
                if (N % a == 0) 
                    Console.WriteLine(a + " is a factorial of the number.");
            }
            Console.WriteLine("================================");
            for (a = 1; a <= N; a++)
            {
                if (N % a == 0) 
                    Console.WriteLine(a + " is a factorial of the number.");
            }
        }
    }
}
