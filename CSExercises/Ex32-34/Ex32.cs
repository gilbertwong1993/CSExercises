using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace CSExercises
{
    public class Ex32
    {
        public static void Main(string[] args)
        {
            double[] A;
            double whole = 0;
            A = new double[12];
            int i = 0;
            for (i = 0; i < 12; i++)
            {
                Console.Write("Enter sales for month {0}:", i);
                A[i] = Convert.ToDouble(Console.ReadLine());
                whole = whole + A[i];
            }
            double max = 0, min = whole;
            int maxmon = 0, minmon = 0;
            for (i = 0; i < 12; i++)
            {
                if (A[i] > max)
                {
                    max = A[i];
                    maxmon = i;
                }
            }
            Console.WriteLine("Maximum Sales:{0}", maxmon);
            for (i = 0; i < 12; i++)
            {
                if (A[i] < min)
                {
                    min = A[i];
                    minmon = i;
                }
            }
            Console.WriteLine("Minimum Sales:{0}", minmon);
            Console.WriteLine("Average Sales:{0}", whole / 12);
        }
    }
}

