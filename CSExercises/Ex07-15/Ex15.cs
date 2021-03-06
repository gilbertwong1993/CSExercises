using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Given a three-digit integer as input write a C# program to determine whether the number is an Armstrong number.
 An Armstrong number is one for which the sum of each digit raised to the power of number of digits results in the number itself.
 For a three digit number 153 = 1^3 + 5^3 + 3^3
 Confine the input to 3 digit examples only ie.,number values 100...999.*/
//Program written by Gilbert Wong
namespace CSExercises
{
    public class Ex15
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a 3 digit number");
            int N = Convert.ToInt32(Console.ReadLine());
            int a = N / 100;
            int b = (N - 100 * a) / 10;
            int c = (N - 100 * a - 10 * b);
            int M = a * a * a + b * b * b + c * c * c;
            if (M == N)
                Console.WriteLine("The number you gave is an Armstrong Number.");
            else
                Console.WriteLine("The number you gave is not an Armstrong Number.");      
        }
    }
}