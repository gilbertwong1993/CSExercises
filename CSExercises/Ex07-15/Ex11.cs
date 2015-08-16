using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*ABC Taxi Company has the following meter charges based on the kilometers travelled.
 Minimum fixed charge:$2.40
 In addition the fare would be computed at 40 cents per kilometer.
 E.g. If the distance traveled is 3.24 km then the total fare is 2.40 + 3.24 * 0.4
 Write a program that reads the distance and calculate the total fare.
 Print out the output without any number formatting.
 */
//Program written by Gilbert Wong
namespace CSExercises
{
    public class Ex11
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the distance");
            double distance = Convert.ToDouble(Console.ReadLine());
            double totalfare = 2.40 + 0.4 * distance;
            string A = String.Format("Total fare: {0:C}", totalfare);
            Console.WriteLine(A);
        }
    }
}
