using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex36
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter a phrase:");
            string A = Console.ReadLine();
            int n, k = 0;
            for (n = 0; n < A.Length; n++)
            {
                char a = A[n];
                char b = A[A.Length - 1 - n];
                if (a == b)
                {
                    k = k + 1;
                }
            }
            if (k == A.Length)
            {
                Console.WriteLine("This phrase is a Palindrome.");
            }
            else
                Console.WriteLine("This phrase is not a Palindrome.");
            Console.WriteLine("************************************");
            Console.WriteLine("Please enter a phrase:");
            string E = Console.ReadLine();
            string D = E.ToLower();
            char[] separater = { ' ', ',', '.' };
            string[] C = D.Split(separater);
            string B = "";
            for (int x = 0; x < C.Length; x++)
            {
                B = B + C[x];
            }
            int m, r = 0;
            for (m = 0; m < B.Length; m++)
            {
                char a = B[m];
                char b = B[B.Length - 1 - m];
                if (a == b)
                {
                    r = r + 1;
                }
            }
            if (r == B.Length)
            {
                Console.WriteLine("This phrase is a Palindrome.");
            }
            else
                Console.WriteLine("This phrase is not a Palindrome.");
        }
    }
}
