using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//C#Exercises No.20
//Program written by Gilbert Wong
namespace CSExercises
{
    public class Ex20
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter quantity for TV:");
            int tv = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter quantity for DVD:");
            int dvd = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter quantity for MP3:");
            int mp3 = Convert.ToInt32(Console.ReadLine());
            int fare1 = 900 * tv + 500 * dvd;
                if (fare1 > 5000 && fare1 <= 10000)
                {
                    double fare2 = fare1 * 0.9 + mp3 * 700;
                    Console.WriteLine("Total price for this order is {0:C}.", fare2);
                }
                else if (fare1 > 10000)
                {
                    double fare2 = fare1 * 0.85 + mp3 * 700;
                    Console.WriteLine("Total price for this order is {0:C}.", fare2);
                }
                else if (fare1 >= 0 && fare1 < 5000)
                {
                    double fare2 = fare1 + mp3 * 700;
                    Console.WriteLine("Total price for this order is {0:C}.", fare2);
                }
        }
    }
}