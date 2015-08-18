using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
/*Write a program that would compute the grade for a mark that the student gets.
 The program should take an integer number between 0 and 100 and print the following:
 You scored 73 marks which is B grade.
 where 73 is the input and B is calculatee by the program.Use the following table for computing the grades:
   Marks        Grade
 80 to 100        A
 60 to 79         B
 40 to 59         C
 0  to 39         F
    <0        **Error**
   >100       **Error**             
*/
//Program written by Gilbert Wong
namespace CSExercises
{
    public class Ex18
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter your mark");
            int mark= Convert.ToInt32(Console.ReadLine());
                 if (mark > 79 && mark <= 100)
                     Console.WriteLine("You scored " + mark + " marks which is A grade.");
                 else if (mark > 59 && mark <= 79)
                     Console.WriteLine("You scored " + mark + " marks which is B grade.");
                 else if (mark > 39 && mark <= 59)
                     Console.WriteLine("You scored " + mark + " marks which is C grade.");
                 else if (mark >= 0 && mark <= 39)
                     Console.WriteLine("You scored " + mark + " marks which is F grade.");
                 else if (mark > 100 || mark < 0)
                     Console.WriteLine("**Error**");
        }
    }
}