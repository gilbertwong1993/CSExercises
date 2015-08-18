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
            double Totalfare = totalfare * 10;
            double Fare = Math.Ceiling(Totalfare);
            double fare = Fare / 10;
            Console.WriteLine("The fare is {0:C}.", fare);
        }
    }
}
