using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex33
    {
        public static void Main(string[] args)
        {
            int[] A = { 86, 35, 41, 49, 89, 51, 11, 71, 50, 75, 25, 58, 40, 14, 44, 3, 63, 81, 93, 79 };
            int i = 0, j = 0, n;
            for (i = 0; i < 20; i++)
            {
                for (j = i + 1; j < 20; j++)
                    if (A[i] < A[j])
                    {
                        n = A[i];
                        A[i] = A[j];
                        A[j] = n;
                    }
            }
            foreach (int a in A)
            {
                Console.Write("{0}\t", a);
            }
        }
    }
}
