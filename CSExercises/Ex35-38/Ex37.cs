using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex37
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Please enter a phrase:");
            string A = Console.ReadLine();
            char[] separater = { ' ' };
            string[] B = A.Split(separater);
            for (int i = 0; i < B.Length; i++)
            {
                char[] a = B[i].ToCharArray();
                string C = Convert.ToString(a[0]).ToUpper();
                char b = Convert.ToChar(C);
                a[0] = b;
                foreach (char letter in a)
                {
                    Console.Write("{0}", letter);
                }
            }
            Console.WriteLine();
        }
    }
}