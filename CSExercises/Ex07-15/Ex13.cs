using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*In the above problem,if you have always to round upwards
 -how would you do that?*/
//Program written by Gilbert Wong
namespace CSExercises
{
    public class Ex13
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the distance");
            double distance = Convert.ToDouble(Console.ReadLine());
            double totalfare = 2.40 + 0.4 * distance;
            double fare = Math.Round(totalfare, 1);
            if (totalfare <= fare)
            {
                Console.WriteLine("The fare is ${0:0.00}.", fare);
            }
            else
            {
                Console.WriteLine("The fare is ${0:0.00}.", fare + 0.1);
            }
        }
    }
}
