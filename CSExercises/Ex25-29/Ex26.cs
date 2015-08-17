using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//C#Exercises No.26
//Program written by Gilbert Wong
namespace CSExercises
{
    public class Ex26
    {
        public static void Main(string[] args)
        {
            double a, b, c, d;
            Console.WriteLine("NO\tINVERSE \tSQUARE ROOT \tSQUARE");
            Console.WriteLine("--------------------------------------------------");
            for (a = 1; a <= 10; a++)
            {
                b = 1 / a;
                c = Math.Sqrt(a);
                d = a * a;
                Console.WriteLine("{0:0.0} \t{1:0.000}      \t{2:0.000}   \t{3:0.0}", a, b, c, d);
            }
        }
    }
}
