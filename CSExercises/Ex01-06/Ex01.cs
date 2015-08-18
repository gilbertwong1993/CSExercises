using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Write a program that would request for your name and print a greeting like this:
 Good Morning Venkat
 where Venkat is the name you had input.*/
//Program written by Gilbert Wong
namespace CSExercises
{
    public class Ex01
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("What's your name?");
            string YourName = Console.ReadLine();
            Console.WriteLine("Good Morning {0}.",YourName);
        }
    }
}
