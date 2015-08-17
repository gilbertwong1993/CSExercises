using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Write a program that would request for your name and gender(M or F assume capital letter)and print a greeting like this:
 Good Morning Mr.Venkat
 where you entered Venkat for name and M for gender,use Mr. for males and Ms. for females.*/
//Program written by Gilbert Wong
namespace CSExercises
{
    public class Ex16
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("What's your name?");
            string YourName = Console.ReadLine();
            Console.WriteLine("What's your gender?(M or F assume capital letter)");
            string Gender = Console.ReadLine();
            if (Gender == "M")
                Console.WriteLine("Good Morning Mr." + YourName);
            else if (Gender == "F")
                Console.WriteLine("Good Morning Mrs." + YourName);
            else 
                Console.WriteLine("Please enter your gender correctly.");
        }
    }
}