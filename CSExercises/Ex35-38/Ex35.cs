using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex35
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter a phrase");
            string A = Console.ReadLine();
            int i = 0;
            int n = 0;
            for (i = 0; i < A.Length; i++)
            {
                char a = A[i];
                if ((a == 'a') || (a == 'e') || (a == 'i') || (a == 'o') || (a == 'u'))
                {
                    n = n + 1;
                }
            }
            Console.WriteLine("Total number of vowels:{0}", n);
            Console.WriteLine("*****************************");
            Console.WriteLine("Please enter a phrase");
            string B = Console.ReadLine();
            int t = 0;
            int p = 0, m = 0, x = 0, y = 0, z = 0;
            for (t = 0; t < B.Length; t++)
            {
                char b = B[t];
                if (b == 'a')
                {
                    p++;
                }
                else if (b == 'e')
                {
                    m++;
                }
                else if (b == 'i')
                {
                    x++;
                }
                else if (b == 'o')
                {
                    y++;
                }
                else if (b == 'u')
                {
                    z++;
                }
            }
            Console.WriteLine("Number of a:{0}", p);
            Console.WriteLine("Number of e:{0}", m);
            Console.WriteLine("Number of i:{0}", x);
            Console.WriteLine("Number of o:{0}", y);
            Console.WriteLine("Number of u:{0}", z);
        }
    }
}