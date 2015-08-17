using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//C#Exercises No.22
//Program written by Gilbert Wong
namespace CSExercises
{
    public class Ex22
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter A:");
            int A = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter B:");
            int B = Convert.ToInt32(Console.ReadLine());
            int C = A * B;
            while(A != B)
                 {
                     if (A > B)
                         {
                             A = A - B;
                         }
                     else if (A < B)
                         {
                             B = B - A;
                         }
                 }
             int HCF = A;
             int LCM = C / HCF;
             Console.WriteLine("HCF={0}", HCF);
             Console.WriteLine("LCM={0}", LCM);
        }
    }
}
