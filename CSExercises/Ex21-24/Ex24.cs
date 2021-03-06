using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//C#Exercises No.24
//Program written by Gilbert Wong
namespace CSExercises
{
    public class Ex24
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter a number");
            double N = Convert.ToDouble(Console.ReadLine());
            Random RND = new Random();
            double G = RND.Next(1,Convert.ToInt32(N)+1);
            while (N != Math.Round(G * G,9)) 
            {
                G = (G + N / G) / 2;
            }
            Console.WriteLine("The square root of the number is {0:0.#####}.",G);
        }
    }
}
