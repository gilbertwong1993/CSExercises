using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*ABC Taxi Company has the following meter charges based on the kilometres travalled.
 Minimum charge:$2.40(first 0.5km no additional charges apply)
 For the next 8.5ksm the rate is 4 cents for every 100 meters
 After that:5 cents for every 100 meters
 In the above example you should assume that the meter falls every 100 meters.
 So assume that if the distance travelled(i.e. input) is 12.13km then it is rounded to 12.20 and the cost would be:
 $2.40(first 0.5km)+$85*0.04(next 8.5km)+$(122-90)*0.05(for distance over 9.0km)=$7.40*/
//Program written by Gilbert Wong
namespace CSExercises
{
    public class Ex19
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the distance.");
            double dis = Convert.ToDouble(Console.ReadLine());
            double Dis = dis * 10;
            double DIS = Math.Ceiling(Dis);
            double distance = DIS / 10;
            if (distance < 0)
                Console.WriteLine("**Error**");
            else if (distance <= 0.5 && distance > 0)
                {
                double fare = 2.40;
                Console.WriteLine("The fare is ${0:0.00}.",fare);
                }
            else if (distance <= 9 && distance > 0.5)
                {
                double fare = 2.40 + 0.4 * (distance - 0.5);
                Console.WriteLine("The fare is ${0:0.00}.", fare);
                }
            else
                {
                double fare = 2.40 + 8.5 * 0.4 + 0.5 * (distance - 9);
                Console.WriteLine("The fare is ${0:0.00}.", fare);
                }
        }
    }
}