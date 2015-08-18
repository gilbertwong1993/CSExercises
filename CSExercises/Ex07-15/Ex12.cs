using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*In the ABC Taxi Company example above,print the output so that the fare is the 
 output is printed always rounded to nearest 10 cents and printed to two decimal places.*/
//Program written by Gilbert Wong
namespace CSExercises
{
    public class Ex12
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the distance");
            double distance = Convert.ToDouble(Console.ReadLine());
            double totalfare = 2.40 + 0.4 * distance;
            double fare = Math.Round(totalfare, 1);
            Console.WriteLine("The fare is {0:C}.", fare);
        }
    }
}
