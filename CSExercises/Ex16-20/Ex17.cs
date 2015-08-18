using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Write a program that would request for your name,gender and age and would print a greeting like this:
 Good Morning Uncle Sam(if Sam,M,45 is entered)
(any gentlemen 40 years or more is Uncle any lady 40 years or more is Aunty,if less than forty they become just Mr or Ms. as the case may be.)*/
//Program written by Gilbert Wong
namespace CSExercises
{
    public class Ex17
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("What's your name?");
            string YourName = Console.ReadLine();
            Console.WriteLine("What's your gender?(M or F assume capital letter)");
            string Gender = Console.ReadLine();
            Console.WriteLine("How old are you?");
            int Age = Convert.ToInt32(Console.ReadLine());
            if ((Gender == "M") && (Age >= 40))
                Console.WriteLine("Good Morning Uncle {0}.", YourName);
            else if ((Gender == "M") && (Age < 40) && (Age >= 0))
                Console.WriteLine("Good Morning Mr.{0}.", YourName);
            else if ((Gender == "F") && (Age >= 40))
                Console.WriteLine("Good Morning Aunty {0}.", YourName);
            else if ((Gender == "F") && (Age < 40) && (Age >= 0))
                Console.WriteLine("Good Morning Mrs.{0}.", YourName);
            else if ((Gender != "M") && (Gender != "F"))
                Console.WriteLine("Please enter your gender correctly.");
            else if (Age < 0)
                Console.WriteLine("Please enter your age correctly.");
        }
    }
}